using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.Shadow : Ext.Base {
                    
        [JsonIgnore]
        public String mode { get { return this.attributes.GetOrDefault<String>("mode", ); } set { this.attributes["mode"] = value; } }                
                    
                    
        private _offset_default = 4;
                    
                    
        [JsonIgnore]
        public Number offset { get { return this.attributes.GetOrDefault<Number>("offset", 4); } set { this.attributes["offset"] = value; } }                
                    
    }
}
