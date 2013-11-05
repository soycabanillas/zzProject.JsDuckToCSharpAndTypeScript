using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.series.Area : Ext.chart.series.Cartesian {
                    
        private _style_default = {};
                    
                    
        [JsonIgnore]
        public Object style { get { return this.attributes.GetOrDefault<Object>("style", {}); } set { this.attributes["style"] = value; } }                
                    
                    
        private _type_default = 'area';
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", 'area'); } set { this.attributes["type"] = value; } }                
                    
    }
}
