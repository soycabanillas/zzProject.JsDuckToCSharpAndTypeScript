using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.SequentialIdGenerator : Ext.data.IdGenerator {
                    
        private _prefix_default = '';
                    
                    
        [JsonIgnore]
        public String prefix { get { return this.attributes.GetOrDefault<String>("prefix", ''); } set { this.attributes["prefix"] = value; } }                
                    
                    
        private _seed_default = 1;
                    
                    
        [JsonIgnore]
        public Number seed { get { return this.attributes.GetOrDefault<Number>("seed", 1); } set { this.attributes["seed"] = value; } }                
                    
    }
}
