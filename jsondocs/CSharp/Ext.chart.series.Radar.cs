using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.series.Radar : Ext.chart.series.Series {
                    
        [JsonIgnore]
        public Object markerConfig { get { return this.attributes.GetOrDefault<Object>("markerConfig", ); } set { this.attributes["markerConfig"] = value; } }                
                    
                    
        private _showInLegend_default = false;
                    
                    
        [JsonIgnore]
        public Boolean showInLegend { get { return this.attributes.GetOrDefault<Boolean>("showInLegend", false); } set { this.attributes["showInLegend"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean showMarkers { get { return this.attributes.GetOrDefault<Boolean>("showMarkers", ); } set { this.attributes["showMarkers"] = value; } }                
                    
                    
        private _style_default = {};
                    
                    
        [JsonIgnore]
        public Object style { get { return this.attributes.GetOrDefault<Object>("style", {}); } set { this.attributes["style"] = value; } }                
                    
                    
        private _type_default = "radar";
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", "radar"); } set { this.attributes["type"] = value; } }                
                    
                    
        [JsonIgnore]
        public String xField { get { return this.attributes.GetOrDefault<String>("xField", ); } set { this.attributes["xField"] = value; } }                
                    
                    
        [JsonIgnore]
        public String yField { get { return this.attributes.GetOrDefault<String>("yField", ); } set { this.attributes["yField"] = value; } }                
                    
    }
}
