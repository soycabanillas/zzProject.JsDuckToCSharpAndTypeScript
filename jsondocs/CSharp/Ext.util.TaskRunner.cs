using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.TaskRunner : Ext.Base {
                    
        private _fireIdleEvent_default = true;
                    
                    
        [JsonIgnore]
        public Boolean fireIdleEvent { get { return this.attributes.GetOrDefault<Boolean>("fireIdleEvent", true); } set { this.attributes["fireIdleEvent"] = value; } }                
                    
                    
        private _interval_default = 10;
                    
                    
        [JsonIgnore]
        public Number interval { get { return this.attributes.GetOrDefault<Number>("interval", 10); } set { this.attributes["interval"] = value; } }                
                    
    }
}
