using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.state.CookieProvider : Ext.state.Provider {
                    
        [JsonIgnore]
        public String domain { get { return this.attributes.GetOrDefault<String>("domain", ); } set { this.attributes["domain"] = value; } }                
                    
                    
        [JsonIgnore]
        public Date expires { get { return this.attributes.GetOrDefault<Date>("expires", ); } set { this.attributes["expires"] = value; } }                
                    
                    
        [JsonIgnore]
        public String path { get { return this.attributes.GetOrDefault<String>("path", ); } set { this.attributes["path"] = value; } }                
                    
                    
        private _secure_default = false;
                    
                    
        [JsonIgnore]
        public Boolean secure { get { return this.attributes.GetOrDefault<Boolean>("secure", false); } set { this.attributes["secure"] = value; } }                
                    
    }
}
