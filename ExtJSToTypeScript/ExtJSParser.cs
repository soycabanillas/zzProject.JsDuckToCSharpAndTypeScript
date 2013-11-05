using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToTypeScript
{
    public class ExtJSParser : JsDuckJsonParser.IJsDuckJsonParser {

        private JsDuckJsonParser.ISerializer _serializer;
        private System.IO.StreamWriter _stream;

        #region Interface JsDuckJsonParser.IJsDuckJsonParser
        void JsDuckJsonParser.IJsDuckJsonParser.Begin(JsDuckJsonParser.ISerializer serializer) {
            this._serializer = serializer;
            this._stream = serializer.Serialize("output.d.ts");
        }

        void JsDuckJsonParser.IJsDuckJsonParser.Parse(JsDuckJsonParser.ClassDefinition classDefinition) {
            this.InnerParse(classDefinition);
        }

        void JsDuckJsonParser.IJsDuckJsonParser.End() {
            this._stream.Flush();
            this._stream.Close();
        }

        void JsDuckJsonParser.IJsDuckJsonParser.Abort() {
        }

        void IDisposable.Dispose() {
        }

        #endregion

        #region ParserMethods

        private void InnerParse(JsDuckJsonParser.ClassDefinition cd) {

            if ((cd.Name == "Array") ||
               (cd.Name == "Boolean") ||
               (cd.Name == "Date") ||
               (cd.Name == "Function") ||
               (cd.Name == "Number") ||
               (cd.Name == "Object") ||
               (cd.Name == "RegExp") ||
               (cd.Name == "String")) {
                System.Diagnostics.Debug.Assert(true);
                //return "/* internal JS type: " + xb.Name + "*/";
            }

            StringBuilder sb = new StringBuilder();
            var sinterface = "interface " + cd.Name.Replace(".", "_");
            if (cd.Extends != null) {
                sinterface += " extends " + cd.Extends.Replace(".", "_");
            }
            sb.Append(sinterface);

            sb.Append(" {" + Environment.NewLine);
            sb.Append("// Cfg" + Environment.NewLine);
            foreach (var prop in cd.Members.Where(m => m.Tagname == "cfg")) {
                if (prop.Private == true) continue;
                if (prop.Owner != cd.Name) continue;
                sb.Append("   " + getName(prop.Name) + " : " + getType(prop.HtmlType) + ";" + Environment.NewLine);
            }

            //todo: check if property not already exists

            sb.Append("// Properties" + Environment.NewLine);
            foreach (var prop in cd.Members.Where(m => m.Tagname == "property")) {
                if (prop.Private == true) continue;
                if (prop.Owner != cd.Name) continue;
                sb.Append("   " + getName(prop.Name) + " : " + getType(prop.HtmlType) + ";" + Environment.NewLine);
            }

            sb.Append("// Events" + Environment.NewLine);
            foreach (var events in cd.Members.Where(m => m.Tagname == "event")) {
                if (events.Owner != cd.Name) continue;
                sb.Append("   " + events.Name + "(");
                if (events.Params != null) {
                    for (int p = 0; p < events.Params.Count; p++) {
                        if (p > 0) sb.Append(",");
                        sb.Append(getName(events.Params[p].Name) + ":" + getType(events.Params[p].HtmlType));
                    }
                }
                sb.Append(") : void");

                sb.Append(";" + Environment.NewLine);
            }

            sb.Append("// Methods" + Environment.NewLine);
            foreach (var method in cd.Members.Where(m => m.Tagname == "method")) {
                if (method.Owner != cd.Name) continue;
                if (method.Private == true) continue;

                sb.Append("   " + method.Name + "(");
                if (method.Params != null) {
                    for (int p = 0; p < method.Params.Count; p++) {
                        if (p > 0) sb.Append(",");
                        sb.Append(getName(method.Params[p].Name) + ":" + getType(method.Params[p].HtmlType));
                    }
                }
                sb.Append(") : ");
                if (method.Return != null) {
                    sb.Append(getType(method.Return.HtmlType));
                } else {
                    sb.Append("void");
                }
                sb.Append(";" + Environment.NewLine);
            }
            sb.Append("}");
            sb.AppendLine();

            _stream.Write(sb);

            ////   todo ref path
            /////<reference path='c:\Users\4dotnet\Desktop\jsondocs\typescript\Ext.Base.d.ts' /> 
            ////var newfile = Path.GetDirectoryName(fileName) + "\\typescript\\" + Path.GetFileNameWithoutExtension(fileName) + ".d.ts";
            ////File.WriteAllText(newfile, output);
        }

        private string getName(string p) {
            if (p == "this") return "_this";
            if (p == "class") return "_class";
            if (p == "new") return "_new";
            return p.Replace('-', '_');
        }

        private string getType(string p) {
            if (p == "undefined") return "void";

            //String/String[] or String[]/Object
            if (p.Contains("/")) return "any" + " /*" + p + "*/";

            //Object...  becomes Object[] etc?
            if (p.EndsWith("...")) return p.Replace("...", "[]").Replace(".", "_");

            return p.Replace(".", "_");
        }
        #endregion
    }
}
