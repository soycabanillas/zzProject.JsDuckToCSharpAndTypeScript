using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.plugin.RowExpander : Ext.AbstractPlugin {
                    
        private _expandOnDblClick_default = true;
                    
                    
        [JsonIgnore]
        public Boolean expandOnDblClick { get { return this.attributes.GetOrDefault<Boolean>("expandOnDblClick", true); } set { this.attributes["expandOnDblClick"] = value; } }                
                    
                    
        private _expandOnEnter_default = true;
                    
                    
        [JsonIgnore]
        public Boolean expandOnEnter { get { return this.attributes.GetOrDefault<Boolean>("expandOnEnter", true); } set { this.attributes["expandOnEnter"] = value; } }                
                    
                    
        private _selectRowOnExpand_default = false;
                    
                    
        [JsonIgnore]
        public Boolean selectRowOnExpand { get { return this.attributes.GetOrDefault<Boolean>("selectRowOnExpand", false); } set { this.attributes["selectRowOnExpand"] = value; } }                
                    
    }
}
