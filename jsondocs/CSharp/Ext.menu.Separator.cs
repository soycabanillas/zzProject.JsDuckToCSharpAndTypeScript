using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.menu.Separator : Ext.menu.Item {
                    
        private _separatorCls_default = Ext.baseCSSPrefix + 'menu-item-separator';
                    
                    
        [JsonIgnore]
        public String separatorCls { get { return this.attributes.GetOrDefault<String>("separatorCls", Ext.baseCSSPrefix + 'menu-item-separator'); } set { this.attributes["separatorCls"] = value; } }                
                    
    }
}
