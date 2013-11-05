using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.Filter : Ext.Base {
                    
        private _anyMatch_default = false;
                    
                    
        [JsonIgnore]
        public Boolean anyMatch { get { return this.attributes.GetOrDefault<Boolean>("anyMatch", false); } set { this.attributes["anyMatch"] = value; } }                
                    
                    
        private _caseSensitive_default = false;
                    
                    
        [JsonIgnore]
        public Boolean caseSensitive { get { return this.attributes.GetOrDefault<Boolean>("caseSensitive", false); } set { this.attributes["caseSensitive"] = value; } }                
                    
                    
        private _exactMatch_default = false;
                    
                    
        [JsonIgnore]
        public Boolean exactMatch { get { return this.attributes.GetOrDefault<Boolean>("exactMatch", false); } set { this.attributes["exactMatch"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function filterFn { get { return this.attributes.GetOrDefault<Function>("filterFn", ); } set { this.attributes["filterFn"] = value; } }                
                    
                    
        [JsonIgnore]
        public String id { get { return this.attributes.GetOrDefault<String>("id", ); } set { this.attributes["id"] = value; } }                
                    
                    
        [JsonIgnore]
        public String operator { get { return this.attributes.GetOrDefault<String>("operator", ); } set { this.attributes["operator"] = value; } }                
                    
                    
        [JsonIgnore]
        public String property { get { return this.attributes.GetOrDefault<String>("property", ); } set { this.attributes["property"] = value; } }                
                    
                    
        [JsonIgnore]
        public String root { get { return this.attributes.GetOrDefault<String>("root", ); } set { this.attributes["root"] = value; } }                
                    
                    
        [JsonIgnore]
        public Mixed value { get { return this.attributes.GetOrDefault<Mixed>("value", ); } set { this.attributes["value"] = value; } }                
                    
    }
}
