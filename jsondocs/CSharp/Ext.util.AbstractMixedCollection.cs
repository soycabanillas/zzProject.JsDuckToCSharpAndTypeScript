using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.AbstractMixedCollection : Ext.Base {
                    
        private _allowFunctions_default = false;
                    
                    
        [JsonIgnore]
        public Boolean allowFunctions { get { return this.attributes.GetOrDefault<Boolean>("allowFunctions", false); } set { this.attributes["allowFunctions"] = value; } }                
                    
    }
}
