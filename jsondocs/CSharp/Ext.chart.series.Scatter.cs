using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.series.Scatter : Ext.chart.series.Cartesian {
                    
        [JsonIgnore]
        public Object markerConfig { get { return this.attributes.GetOrDefault<Object>("markerConfig", ); } set { this.attributes["markerConfig"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object style { get { return this.attributes.GetOrDefault<Object>("style", ); } set { this.attributes["style"] = value; } }                
                    
                    
        private _type_default = 'scatter';
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", 'scatter'); } set { this.attributes["type"] = value; } }                
                    
    }
}
