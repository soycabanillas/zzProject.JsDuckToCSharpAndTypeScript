using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.proxy.Ajax : Ext.data.proxy.Server {
                    
        private _binary_default = false;
                    
                    
        [JsonIgnore]
        public Boolean binary { get { return this.attributes.GetOrDefault<Boolean>("binary", false); } set { this.attributes["binary"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object headers { get { return this.attributes.GetOrDefault<Object>("headers", ); } set { this.attributes["headers"] = value; } }                
                    
    }
}
