using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.direct.Provider : Ext.Base {
                    
        [JsonIgnore]
        public String id { get { return this.attributes.GetOrDefault<String>("id", ); } set { this.attributes["id"] = value; } }                
                    
                    
        [JsonIgnore]
        public String[] relayedEvents { get { return this.attributes.GetOrDefault<String[]>("relayedEvents", ); } set { this.attributes["relayedEvents"] = value; } }                
                    
    }
}
