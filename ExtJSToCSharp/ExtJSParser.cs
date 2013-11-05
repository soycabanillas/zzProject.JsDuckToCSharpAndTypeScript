using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public class ExtJSParser : JsDuckJsonParser.IJsDuckJsonParser {

        private const string RESOURCE_TEMPLATE = "ExtJSToCSharp.ClassTemplate.cshtml";
        private const string CACHE_TEMPLATE_NAME = "classTemplate";

        private JsDuckJsonParser.ISerializer _serializer;

        #region Interface JsDuckJsonParser.IJsDuckJsonParser
        void JsDuckJsonParser.IJsDuckJsonParser.Begin(JsDuckJsonParser.ISerializer serializer) {
            Test.test();

            this._serializer = serializer;

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = RESOURCE_TEMPLATE;

            using (System.IO.Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream)) {
                string template = reader.ReadToEnd();
                var config = new FluentTemplateServiceConfiguration(c => c.WithEncoding(RazorEngine.Encoding.Raw));
                var templateService = new TemplateService(config);
                Razor.SetTemplateService(templateService);
                Razor.Compile<JsDuckJsonParser.ClassDefinition>(template, CACHE_TEMPLATE_NAME);
            }
        }

        void JsDuckJsonParser.IJsDuckJsonParser.Parse(JsDuckJsonParser.ClassDefinition classDefinition) {
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

        private void InnerParse(JsDuckJsonParser.ClassDefinition cd) {
            var stream = this._serializer.Serialize(cd.Name + ".cs");

            foreach (var prop in cd.GetMembers(JsDuckJsonParser.MemberTypeEnum.cfg)) {
                if (prop.Private == true) continue;
                if (prop.Owner != cd.Name) continue;
                if (prop.Default == null) continue;
                if (!prop.Type.Contains("/")) continue;
                int i = 3;
            }

            stream.Write(Razor.Run(CACHE_TEMPLATE_NAME, cd));
            stream.Flush();
            stream.Close();
        }
        #endregion
    }
}
