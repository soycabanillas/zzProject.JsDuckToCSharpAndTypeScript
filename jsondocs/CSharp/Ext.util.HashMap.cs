using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.HashMap : Ext.Base {
                    
        [JsonIgnore]
        public Function keyFn { get { return this.attributes.GetOrDefault<Function>("keyFn", ); } set { this.attributes["keyFn"] = value; } }                
                    
    }
}
