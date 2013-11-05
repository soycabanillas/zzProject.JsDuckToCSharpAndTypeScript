using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Auto : Ext.layout.container.Container {
                    
        private _reserveScrollbar_default = false;
                    
                    
        [JsonIgnore]
        public Boolean reserveScrollbar { get { return this.attributes.GetOrDefault<Boolean>("reserveScrollbar", false); } set { this.attributes["reserveScrollbar"] = value; } }                
                    
    }
}
