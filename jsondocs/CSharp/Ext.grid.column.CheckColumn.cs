using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.column.CheckColumn : Ext.grid.column.Column {
                    
        private _stopSelection_default = true;
                    
                    
        [JsonIgnore]
        public Boolean stopSelection { get { return this.attributes.GetOrDefault<Boolean>("stopSelection", true); } set { this.attributes["stopSelection"] = value; } }                
                    
                    
        private _tdCls_default = Ext.baseCSSPrefix + 'grid-cell-checkcolumn';
                    
                    
        [JsonIgnore]
        public String tdCls { get { return this.attributes.GetOrDefault<String>("tdCls", Ext.baseCSSPrefix + 'grid-cell-checkcolumn'); } set { this.attributes["tdCls"] = value; } }                
                    
    }
}
