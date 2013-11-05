using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tree.Column : Ext.grid.column.Column {
                    
        private _hideable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideable { get { return this.attributes.GetOrDefault<Boolean>("hideable", false); } set { this.attributes["hideable"] = value; } }                
                    
                    
        private _lockable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean lockable { get { return this.attributes.GetOrDefault<Boolean>("lockable", false); } set { this.attributes["lockable"] = value; } }                
                    
                    
        private _tdCls_default = Ext.baseCSSPrefix + 'grid-cell-treecolumn';
                    
                    
        [JsonIgnore]
        public String tdCls { get { return this.attributes.GetOrDefault<String>("tdCls", Ext.baseCSSPrefix + 'grid-cell-treecolumn'); } set { this.attributes["tdCls"] = value; } }                
                    
    }
}
