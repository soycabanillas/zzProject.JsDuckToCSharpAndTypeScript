using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.feature.Summary : Ext.grid.feature.AbstractSummary {
                    
        [JsonIgnore]
        public String dock { get { return this.attributes.GetOrDefault<String>("dock", ); } set { this.attributes["dock"] = value; } }                
                    
    }
}
