using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Column : Ext.layout.container.Auto {
                    
        private _itemCls_default = Ext.baseCSSPrefix + 'column';
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", Ext.baseCSSPrefix + 'column'); } set { this.attributes["itemCls"] = value; } }                
                    
    }
}
