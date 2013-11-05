using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Fit : Ext.layout.container.Container {
                    
        private _defaultMargins_default = {top: 0, right: 0, bottom: 0, left: 0};
                    
                    
        [JsonIgnore]
        public Object defaultMargins { get { return this.attributes.GetOrDefault<Object>("defaultMargins", {top: 0, right: 0, bottom: 0, left: 0}); } set { this.attributes["defaultMargins"] = value; } }                
                    
                    
        private _itemCls_default = Ext.baseCSSPrefix + 'fit-item';
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", Ext.baseCSSPrefix + 'fit-item'); } set { this.attributes["itemCls"] = value; } }                
                    
    }
}
