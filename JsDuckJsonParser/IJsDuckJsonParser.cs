using JsDuckJsonParser.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsDuckJsonParser {
    public interface IJsDuckJsonParser : IDisposable {
        void Begin(ISerializer serializer);
        void Parse(ClassDefinition classDefinition);
        void End();
        void Abort();
    }
}
