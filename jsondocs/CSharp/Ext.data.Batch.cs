using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.Batch : Ext.Base {
                    
        private _autoStart_default = false;
                    
                    
        [JsonIgnore]
        public Boolean autoStart { get { return this.attributes.GetOrDefault<Boolean>("autoStart", false); } set { this.attributes["autoStart"] = value; } }                
                    
                    
        private _pauseOnException_default = false;
                    
                    
        [JsonIgnore]
        public Boolean pauseOnException { get { return this.attributes.GetOrDefault<Boolean>("pauseOnException", false); } set { this.attributes["pauseOnException"] = value; } }                
                    
    }
}
