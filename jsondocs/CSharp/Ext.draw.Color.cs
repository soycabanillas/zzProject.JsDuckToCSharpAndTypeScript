using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.draw.Color : Ext.Base {
                    
        private _lightnessFactor_default = 0.2;
                    
                    
        [JsonIgnore]
        public Number lightnessFactor { get { return this.attributes.GetOrDefault<Number>("lightnessFactor", 0.2); } set { this.attributes["lightnessFactor"] = value; } }                
                    
    }
}
