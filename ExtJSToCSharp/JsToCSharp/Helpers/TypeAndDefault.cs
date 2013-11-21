using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzProject.ExtJSToCSharp.JsToCSharp.Helpers {
    public class TypeAndDefault {
        public Type Type { get; private set; }
        public string TypeName { get; private set; }
        //public string Default { get; private set; }

        public TypeAndDefault(Type type/*, string @default*/) {
            this.Type = type;
            this.TypeName = zzProject.ExtJSToCSharp.JsToCSharp.CSharp.GetTypeName(type);
            //this.Default = @default;
        }

        public TypeAndDefault(string typeName/*, string @default*/) {
            this.TypeName = typeName;
            //this.Default = @default;
        }
    }
}
