using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.state.Stateful : Ext.Base {
                    
        private _saveDelay_default = 100;
                    
                    
        [JsonIgnore]
        public Number saveDelay { get { return this.attributes.GetOrDefault<Number>("saveDelay", 100); } set { this.attributes["saveDelay"] = value; } }                
                    
                    
        [JsonIgnore]
        public String[] stateEvents { get { return this.attributes.GetOrDefault<String[]>("stateEvents", ); } set { this.attributes["stateEvents"] = value; } }                
                    
                    
        [JsonIgnore]
        public String stateId { get { return this.attributes.GetOrDefault<String>("stateId", ); } set { this.attributes["stateId"] = value; } }                
                    
                    
        private _stateful_default = false;
                    
                    
        [JsonIgnore]
        public Boolean stateful { get { return this.attributes.GetOrDefault<Boolean>("stateful", false); } set { this.attributes["stateful"] = value; } }                
                    
    }
}
