using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.state.Provider : Ext.Base {
                    
        private _prefix_default = 'ext-';
                    
                    
        [JsonIgnore]
        public String prefix { get { return this.attributes.GetOrDefault<String>("prefix", 'ext-'); } set { this.attributes["prefix"] = value; } }                
                    
    }
}
