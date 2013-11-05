using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.axis.Gauge : Ext.chart.axis.Abstract {
                    
        private _margin_default = 10;
                    
                    
        [JsonIgnore]
        public Number margin { get { return this.attributes.GetOrDefault<Number>("margin", 10); } set { this.attributes["margin"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number maximum { get { return this.attributes.GetOrDefault<Number>("maximum", ); } set { this.attributes["maximum"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minimum { get { return this.attributes.GetOrDefault<Number>("minimum", ); } set { this.attributes["minimum"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number steps { get { return this.attributes.GetOrDefault<Number>("steps", ); } set { this.attributes["steps"] = value; } }                
                    
                    
        [JsonIgnore]
        public String title { get { return this.attributes.GetOrDefault<String>("title", ); } set { this.attributes["title"] = value; } }                
                    
    }
}
