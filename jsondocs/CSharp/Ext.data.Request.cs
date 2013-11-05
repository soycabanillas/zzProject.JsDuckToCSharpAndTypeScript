using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.Request : Ext.Base {
                    
        [JsonIgnore]
        public String action { get { return this.attributes.GetOrDefault<String>("action", ); } set { this.attributes["action"] = value; } }                
                    
                    
        private _method_default = 'GET';
                    
                    
        [JsonIgnore]
        public String method { get { return this.attributes.GetOrDefault<String>("method", 'GET'); } set { this.attributes["method"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object params { get { return this.attributes.GetOrDefault<Object>("params", ); } set { this.attributes["params"] = value; } }                
                    
                    
        [JsonIgnore]
        public String url { get { return this.attributes.GetOrDefault<String>("url", ); } set { this.attributes["url"] = value; } }                
                    
    }
}
