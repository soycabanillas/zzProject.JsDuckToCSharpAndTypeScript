using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsDuckJsonParser.Class.Helpers {
    public class TypesAndConstants {
        public List<string> Types { get; private set; }
        public List<string> Constants { get; private set; }
        public string Default { get; private set; }

        public TypesAndConstants(List<string> types, List<string> constants, string @default) {
            this.Types = types;
            this.Constants = constants;
            this.Default = @default;
        }
    }
}
