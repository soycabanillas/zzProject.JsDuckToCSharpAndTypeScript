using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.feature.GroupingSummary : Ext.grid.feature.Grouping {
                    
        private _showSummaryRow_default = true;
                    
                    
        [JsonIgnore]
        public Boolean showSummaryRow { get { return this.attributes.GetOrDefault<Boolean>("showSummaryRow", true); } set { this.attributes["showSummaryRow"] = value; } }                
                    
    }
}
