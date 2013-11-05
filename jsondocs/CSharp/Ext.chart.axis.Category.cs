using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.axis.Category : Ext.chart.axis.Axis {
                    
        private _calculateCategoryCount_default = false;
                    
                    
        [JsonIgnore]
        public Boolean calculateCategoryCount { get { return this.attributes.GetOrDefault<Boolean>("calculateCategoryCount", false); } set { this.attributes["calculateCategoryCount"] = value; } }                
                    
                    
        [JsonIgnore]
        public String categoryNames { get { return this.attributes.GetOrDefault<String>("categoryNames", ); } set { this.attributes["categoryNames"] = value; } }                
                    
    }
}
