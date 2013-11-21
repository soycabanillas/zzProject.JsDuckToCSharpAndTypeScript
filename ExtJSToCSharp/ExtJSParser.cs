using JsDuckJsonParser.Class;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace zzProject.ExtJSToCSharp {
    public class ExtJSParser : JsDuckJsonParser.IJsDuckJsonParser {

        private const string RESOURCE_TEMPLATE = "ExtJSToCSharp.ClassTemplate.cshtml";
        private const string CACHE_TEMPLATE_NAME = "classTemplate";

        private JsDuckJsonParser.ISerializer _serializer;

        //TODO: Borrar
        private System.Collections.Generic.SortedSet<String> _typeNames;

        #region Interface JsDuckJsonParser.IJsDuckJsonParser
        void JsDuckJsonParser.IJsDuckJsonParser.Begin(JsDuckJsonParser.ISerializer serializer) {
            //TODO: BORRAR
            Test.test();
            _typeNames = new SortedSet<string>();

            this._serializer = serializer;

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = RESOURCE_TEMPLATE;

            using (System.IO.Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream)) {
                string template = reader.ReadToEnd();
                var config = new FluentTemplateServiceConfiguration(c => c.WithEncoding(RazorEngine.Encoding.Raw));
                var templateService = new TemplateService(config);
                Razor.SetTemplateService(templateService);
                Razor.Compile<JsDuckJsonParser.Class.ClassDefinition>(template, CACHE_TEMPLATE_NAME);
            }
        }

        void JsDuckJsonParser.IJsDuckJsonParser.Parse(ClassDefinition classDefinition) {
            this.InnerParse(classDefinition);
        }

        void JsDuckJsonParser.IJsDuckJsonParser.End() {
        }

        void JsDuckJsonParser.IJsDuckJsonParser.Abort() {
        }

        void IDisposable.Dispose() {
        }

        #endregion

        #region ParserMethods

        private void InnerParse(JsDuckJsonParser.Class.ClassDefinition cd) {
            if ((cd.Name == "Array") ||
               (cd.Name == "Boolean") ||
               (cd.Name == "Date") ||
               (cd.Name == "Function") ||
               (cd.Name == "Number") ||
               (cd.Name == "Object") ||
               (cd.Name == "RegExp") ||
               (cd.Name == "String")) {
                return;
            }

            var stream = this._serializer.Serialize(cd.Name + ".cs");

            foreach (var prop in cd.GetMembers(JsDuckJsonParser.Class.MemberTypeEnum.cfg)) {
                if (prop.Private == true) continue;
                if (prop.Owner != cd.Name) continue;
                if (prop.Default == null) continue;
                //if (!prop.Type.Contains("/")) continue;
                var _types = prop.Type.Split('/');
                foreach (var typeName in _types) {
                    if (!_typeNames.Any(t => t == typeName.ToUpperInvariant()))
                    {
                        _typeNames.Add(typeName.ToUpperInvariant());
                        System.Diagnostics.Debug.WriteLine(typeName);
                        //System.Console.WriteLine(typeName);
                        //ExtJSToCSharp.JsToCSharp.JsValue.ToTypeAndValue(typeName);
//                        Newtonsoft.Json.Schema.JsonSchema schema1 = Newtonsoft.Json.Schema.JsonSchema.Parse(String.Format(@"{{'type':'{0}'}}", typeName));
                    }
                }
                //ExtJSToCSharp.ClassGeneratorHelper.GenerateFromType(prop.Type, "");
                int i = 3;
                //TODO: Eliminar el código:
                //ExtJSToCSharp.JsToCSharp.JsValue.ToTypeAndValue("{ myObject : 44 }");
            }

            //stream.Write(Razor.Run(CACHE_TEMPLATE_NAME, cd));
            
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CodeGeneratorOptions options = new CodeGeneratorOptions();
            options.BracingStyle = "C";

            var targetUnit = JsToCSharp.Compiler.GenerateCSharpCode(cd, provider.CreateValidIdentifier);
            //StringBuilder result = new StringBuilder();
            //System.IO.StringWriter sourceWriter = new System.IO.StringWriter(result);
            //provider.GenerateCodeFromCompileUnit(targetUnit, sourceWriter, options);
            //System.Diagnostics.Debug.Write(result);


            //stream.Write(Razor.Run(CACHE_TEMPLATE_NAME, cd));
            provider.GenerateCodeFromCompileUnit(targetUnit, stream, options);
            var prueba = "'esto es una prueba'";
            stream.Flush();
            stream.Close();
        }
        #endregion
    }
}
