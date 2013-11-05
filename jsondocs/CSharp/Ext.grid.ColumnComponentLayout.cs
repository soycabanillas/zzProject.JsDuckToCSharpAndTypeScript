using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.ColumnComponentLayout : Ext.layout.component.Auto {
                    
        private _setWidthInDom_default = true;
                    
                    
        [JsonIgnore]
        public Boolean setWidthInDom { get { return this.attributes.GetOrDefault<Boolean>("setWidthInDom", true); } set { this.attributes["setWidthInDom"] = value; } }                
                    
    }
}
