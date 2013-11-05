using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.proxy.Memory : Ext.data.proxy.Client {
                    
        [JsonIgnore]
        public Object data { get { return this.attributes.GetOrDefault<Object>("data", ); } set { this.attributes["data"] = value; } }                
                    
                    
        private _enablePaging_default = false;
                    
                    
        [JsonIgnore]
        public Boolean enablePaging { get { return this.attributes.GetOrDefault<Boolean>("enablePaging", false); } set { this.attributes["enablePaging"] = value; } }                
                    
    }
}
