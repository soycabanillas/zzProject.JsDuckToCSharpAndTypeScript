using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.Action : Ext.Base {
                    
        private _disabled_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disabled { get { return this.attributes.GetOrDefault<Boolean>("disabled", false); } set { this.attributes["disabled"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function handler { get { return this.attributes.GetOrDefault<Function>("handler", ); } set { this.attributes["handler"] = value; } }                
                    
                    
        private _hidden_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hidden { get { return this.attributes.GetOrDefault<Boolean>("hidden", false); } set { this.attributes["hidden"] = value; } }                
                    
                    
        private _iconCls_default = '';
                    
                    
        [JsonIgnore]
        public String iconCls { get { return this.attributes.GetOrDefault<String>("iconCls", ''); } set { this.attributes["iconCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String itemId { get { return this.attributes.GetOrDefault<String>("itemId", ); } set { this.attributes["itemId"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _text_default = '';
                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", ''); } set { this.attributes["text"] = value; } }                
                    
    }
}
