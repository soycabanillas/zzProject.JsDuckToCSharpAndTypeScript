using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.plugin.HeaderResizer : Ext.AbstractPlugin {
                    
        private _dynamic_default = false;
                    
                    
        [JsonIgnore]
        public Boolean dynamic { get { return this.attributes.GetOrDefault<Boolean>("dynamic", false); } set { this.attributes["dynamic"] = value; } }                
                    
    }
}
