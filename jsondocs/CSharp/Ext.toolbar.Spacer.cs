using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.toolbar.Spacer : Ext.Component {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'toolbar-spacer';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'toolbar-spacer'); } set { this.attributes["baseCls"] = value; } }                
                    
    }
}
