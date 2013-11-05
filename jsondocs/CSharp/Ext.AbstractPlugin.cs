using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.AbstractPlugin : Ext.Base {
                    
        [JsonIgnore]
        public String pluginId { get { return this.attributes.GetOrDefault<String>("pluginId", ); } set { this.attributes["pluginId"] = value; } }                
                    
    }
}
