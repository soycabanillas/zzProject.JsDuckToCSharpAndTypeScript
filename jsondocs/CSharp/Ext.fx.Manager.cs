using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.fx.Manager : Ext.Base {
                    
        private _forceJS_default = true;
                    
                    
        [JsonIgnore]
        public Boolean forceJS { get { return this.attributes.GetOrDefault<Boolean>("forceJS", true); } set { this.attributes["forceJS"] = value; } }                
                    
                    
        private _interval_default = 16;
                    
                    
        [JsonIgnore]
        public Number interval { get { return this.attributes.GetOrDefault<Number>("interval", 16); } set { this.attributes["interval"] = value; } }                
                    
    }
}
