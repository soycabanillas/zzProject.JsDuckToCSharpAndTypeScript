using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.axis.Radial : Ext.chart.axis.Numeric {
                    
        [JsonIgnore]
        public Number maximum { get { return this.attributes.GetOrDefault<Number>("maximum", ); } set { this.attributes["maximum"] = value; } }                
                    
                    
        private _position_default = 'radial';
                    
                    
        [JsonIgnore]
        public String position { get { return this.attributes.GetOrDefault<String>("position", 'radial'); } set { this.attributes["position"] = value; } }                
                    
                    
        private _steps_default = 10;
                    
                    
        [JsonIgnore]
        public Number steps { get { return this.attributes.GetOrDefault<Number>("steps", 10); } set { this.attributes["steps"] = value; } }                
                    
    }
}
