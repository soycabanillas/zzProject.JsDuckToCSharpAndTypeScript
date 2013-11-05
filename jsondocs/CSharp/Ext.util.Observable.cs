using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.Observable : Ext.Base {
                    
        [JsonIgnore]
        public Object listeners { get { return this.attributes.GetOrDefault<Object>("listeners", ); } set { this.attributes["listeners"] = value; } }                
                    
    }
}
