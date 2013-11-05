using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.column.Action : Ext.grid.column.Column {
                    
        private _altText_default = '';
                    
                    
        [JsonIgnore]
        public String altText { get { return this.attributes.GetOrDefault<String>("altText", ''); } set { this.attributes["altText"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean disabled { get { return this.attributes.GetOrDefault<Boolean>("disabled", ); } set { this.attributes["disabled"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function getClass { get { return this.attributes.GetOrDefault<Function>("getClass", ); } set { this.attributes["getClass"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function getTip { get { return this.attributes.GetOrDefault<Function>("getTip", ); } set { this.attributes["getTip"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function handler { get { return this.attributes.GetOrDefault<Function>("handler", ); } set { this.attributes["handler"] = value; } }                
                    
                    
        [JsonIgnore]
        public String icon { get { return this.attributes.GetOrDefault<String>("icon", ); } set { this.attributes["icon"] = value; } }                
                    
                    
        [JsonIgnore]
        public String iconCls { get { return this.attributes.GetOrDefault<String>("iconCls", ); } set { this.attributes["iconCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function isDisabled { get { return this.attributes.GetOrDefault<Function>("isDisabled", ); } set { this.attributes["isDisabled"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object[] items { get { return this.attributes.GetOrDefault<Object[]>("items", ); } set { this.attributes["items"] = value; } }                
                    
                    
        private _menuText_default = <i>Actions</i>;
                    
                    
        [JsonIgnore]
        public String menuText { get { return this.attributes.GetOrDefault<String>("menuText", <i>Actions</i>); } set { this.attributes["menuText"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _sortable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean sortable { get { return this.attributes.GetOrDefault<Boolean>("sortable", false); } set { this.attributes["sortable"] = value; } }                
                    
                    
        private _stopSelection_default = true;
                    
                    
        [JsonIgnore]
        public Boolean stopSelection { get { return this.attributes.GetOrDefault<Boolean>("stopSelection", true); } set { this.attributes["stopSelection"] = value; } }                
                    
                    
        [JsonIgnore]
        public String tooltip { get { return this.attributes.GetOrDefault<String>("tooltip", ); } set { this.attributes["tooltip"] = value; } }                
                    
    }
}
