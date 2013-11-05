using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.feature.AbstractSummary : Ext.grid.feature.Feature {
                    
        private _remoteRoot_default = undefined;
                    
                    
        [JsonIgnore]
        public String remoteRoot { get { return this.attributes.GetOrDefault<String>("remoteRoot", undefined); } set { this.attributes["remoteRoot"] = value; } }                
                    
                    
        private _showSummaryRow_default = true;
                    
                    
        [JsonIgnore]
        public Boolean showSummaryRow { get { return this.attributes.GetOrDefault<Boolean>("showSummaryRow", true); } set { this.attributes["showSummaryRow"] = value; } }                
                    
    }
}
