using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.plugin.Editing : Ext.AbstractPlugin {
                    
        private _clicksToEdit_default = 2;
                    
                    
        [JsonIgnore]
        public Number clicksToEdit { get { return this.attributes.GetOrDefault<Number>("clicksToEdit", 2); } set { this.attributes["clicksToEdit"] = value; } }                
                    
                    
        [JsonIgnore]
        public String triggerEvent { get { return this.attributes.GetOrDefault<String>("triggerEvent", ); } set { this.attributes["triggerEvent"] = value; } }                
                    
    }
}
