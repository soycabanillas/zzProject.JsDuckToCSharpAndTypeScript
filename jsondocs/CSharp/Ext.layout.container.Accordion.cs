using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Accordion : Ext.layout.container.VBox {
                    
        private _activeOnTop_default = false;
                    
                    
        [JsonIgnore]
        public Boolean activeOnTop { get { return this.attributes.GetOrDefault<Boolean>("activeOnTop", false); } set { this.attributes["activeOnTop"] = value; } }                
                    
                    
        private _align_default = 'stretch';
                    
                    
        [JsonIgnore]
        public String align { get { return this.attributes.GetOrDefault<String>("align", 'stretch'); } set { this.attributes["align"] = value; } }                
                    
                    
        private _animate_default = true;
                    
                    
        [JsonIgnore]
        public Boolean animate { get { return this.attributes.GetOrDefault<Boolean>("animate", true); } set { this.attributes["animate"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean autoWidth { get { return this.attributes.GetOrDefault<Boolean>("autoWidth", ); } set { this.attributes["autoWidth"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean collapseFirst { get { return this.attributes.GetOrDefault<Boolean>("collapseFirst", ); } set { this.attributes["collapseFirst"] = value; } }                
                    
                    
        private _fill_default = true;
                    
                    
        [JsonIgnore]
        public Boolean fill { get { return this.attributes.GetOrDefault<Boolean>("fill", true); } set { this.attributes["fill"] = value; } }                
                    
                    
        private _hideCollapseTool_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideCollapseTool { get { return this.attributes.GetOrDefault<Boolean>("hideCollapseTool", false); } set { this.attributes["hideCollapseTool"] = value; } }                
                    
                    
        private _itemCls_default = [Ext.baseCSSPrefix + 'box-item', Ext.baseCSSPrefix + 'accordion-item'];
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", [Ext.baseCSSPrefix + 'box-item', Ext.baseCSSPrefix + 'accordion-item']); } set { this.attributes["itemCls"] = value; } }                
                    
                    
        private _multi_default = false;
                    
                    
        [JsonIgnore]
        public Boolean multi { get { return this.attributes.GetOrDefault<Boolean>("multi", false); } set { this.attributes["multi"] = value; } }                
                    
                    
        private _titleCollapse_default = true;
                    
                    
        [JsonIgnore]
        public Boolean titleCollapse { get { return this.attributes.GetOrDefault<Boolean>("titleCollapse", true); } set { this.attributes["titleCollapse"] = value; } }                
                    
    }
}
