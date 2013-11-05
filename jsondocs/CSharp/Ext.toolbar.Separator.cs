using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.toolbar.Separator : Ext.toolbar.Item {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'toolbar-separator';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'toolbar-separator'); } set { this.attributes["baseCls"] = value; } }                
                    
    }
}
