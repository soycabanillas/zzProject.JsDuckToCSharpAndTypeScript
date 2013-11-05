using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Absolute : Ext.layout.container.Anchor {
                    
        private _ignoreOnContentChange_default = true;
                    
                    
        [JsonIgnore]
        public Boolean ignoreOnContentChange { get { return this.attributes.GetOrDefault<Boolean>("ignoreOnContentChange", true); } set { this.attributes["ignoreOnContentChange"] = value; } }                
                    
                    
        private _itemCls_default = Ext.baseCSSPrefix + 'abs-layout-item';
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", Ext.baseCSSPrefix + 'abs-layout-item'); } set { this.attributes["itemCls"] = value; } }                
                    
    }
}
