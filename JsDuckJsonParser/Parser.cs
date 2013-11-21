using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsDuckJsonParser {
    public class Parser : IDisposable {
        private IJsDuckJsonParser _classParser;

        public Parser(IJsDuckJsonParser classParser) {
            _classParser = classParser;
        }

        public void Begin(ISerializer serializer) {
            _classParser.Begin(serializer);
        }

        public void Parse(System.IO.StreamReader reader) {
            JsonSerializerSettings jss = new JsonSerializerSettings();
            jss.MissingMemberHandling = MissingMemberHandling.Ignore;

            jss.Error = new EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>(delegate(object o, Newtonsoft.Json.Serialization.ErrorEventArgs eea) {
                Debug.WriteLine(eea.ErrorContext);
            });

            var xb = (JsDuckJsonParser.Class.ClassDefinition)JsonConvert.DeserializeObject(reader.ReadToEnd(), typeof(JsDuckJsonParser.Class.ClassDefinition), jss);

            _classParser.Parse(xb);
        }

        public void End() {
            _classParser.End();
        }

        public void Abort() {
            _classParser.Abort();
        }

        public void Dispose() {
            _classParser.Dispose();
        }
    }
}
