using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.MixedCollection : Ext.util.AbstractMixedCollection {
                    
        [JsonIgnore]
        public Boolean allowFunctions { get { return this.attributes.GetOrDefault<Boolean>("allowFunctions", ); } set { this.attributes["allowFunctions"] = value; } }                
                    
    }
}
