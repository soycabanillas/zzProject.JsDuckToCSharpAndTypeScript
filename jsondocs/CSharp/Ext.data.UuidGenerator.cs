using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.UuidGenerator : Ext.data.IdGenerator {
                    
        private _version_default = 4;
                    
                    
        [JsonIgnore]
        public Number version { get { return this.attributes.GetOrDefault<Number>("version", 4); } set { this.attributes["version"] = value; } }                
                    
    }
}
