using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tab.Bar : Ext.panel.Header {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'tab-bar';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'tab-bar'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number maxTabWidth { get { return this.attributes.GetOrDefault<Number>("maxTabWidth", ); } set { this.attributes["maxTabWidth"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minTabWidth { get { return this.attributes.GetOrDefault<Number>("minTabWidth", ); } set { this.attributes["minTabWidth"] = value; } }                
                    
                    
        private _plain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean plain { get { return this.attributes.GetOrDefault<Boolean>("plain", false); } set { this.attributes["plain"] = value; } }                
                    
    }
}
