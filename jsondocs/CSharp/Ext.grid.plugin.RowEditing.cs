using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.plugin.RowEditing : Ext.grid.plugin.Editing {
                    
        private _autoCancel_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoCancel { get { return this.attributes.GetOrDefault<Boolean>("autoCancel", true); } set { this.attributes["autoCancel"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number clicksToMoveEditor { get { return this.attributes.GetOrDefault<Number>("clicksToMoveEditor", ); } set { this.attributes["clicksToMoveEditor"] = value; } }                
                    
                    
        private _errorSummary_default = true;
                    
                    
        [JsonIgnore]
        public Boolean errorSummary { get { return this.attributes.GetOrDefault<Boolean>("errorSummary", true); } set { this.attributes["errorSummary"] = value; } }                
                    
    }
}
