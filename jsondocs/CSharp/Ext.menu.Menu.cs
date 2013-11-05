using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.menu.Menu : Ext.panel.Panel {
                    
        private _allowOtherMenus_default = false;
                    
                    
        [JsonIgnore]
        public Boolean allowOtherMenus { get { return this.attributes.GetOrDefault<Boolean>("allowOtherMenus", false); } set { this.attributes["allowOtherMenus"] = value; } }                
                    
                    
        private _enableKeyNav_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableKeyNav { get { return this.attributes.GetOrDefault<Boolean>("enableKeyNav", true); } set { this.attributes["enableKeyNav"] = value; } }                
                    
                    
        private _floating_default = true;
                    
                    
        [JsonIgnore]
        public Boolean floating { get { return this.attributes.GetOrDefault<Boolean>("floating", true); } set { this.attributes["floating"] = value; } }                
                    
                    
        private _hidden_default = undefined;
                    
                    
        [JsonIgnore]
        public Boolean hidden { get { return this.attributes.GetOrDefault<Boolean>("hidden", undefined); } set { this.attributes["hidden"] = value; } }                
                    
                    
        private _hideMode_default = 'visibility';
                    
                    
        [JsonIgnore]
        public String hideMode { get { return this.attributes.GetOrDefault<String>("hideMode", 'visibility'); } set { this.attributes["hideMode"] = value; } }                
                    
                    
        private _ignoreParentClicks_default = false;
                    
                    
        [JsonIgnore]
        public Boolean ignoreParentClicks { get { return this.attributes.GetOrDefault<Boolean>("ignoreParentClicks", false); } set { this.attributes["ignoreParentClicks"] = value; } }                
                    
                    
        private _minWidth_default = 120;
                    
                    
        [JsonIgnore]
        public Number minWidth { get { return this.attributes.GetOrDefault<Number>("minWidth", 120); } set { this.attributes["minWidth"] = value; } }                
                    
                    
        private _plain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean plain { get { return this.attributes.GetOrDefault<Boolean>("plain", false); } set { this.attributes["plain"] = value; } }                
                    
                    
        private _showSeparator_default = true;
                    
                    
        [JsonIgnore]
        public Boolean showSeparator { get { return this.attributes.GetOrDefault<Boolean>("showSeparator", true); } set { this.attributes["showSeparator"] = value; } }                
                    
    }
}
