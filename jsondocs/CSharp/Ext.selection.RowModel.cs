using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.selection.RowModel : Ext.selection.Model {
                    
        private _enableKeyNav_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableKeyNav { get { return this.attributes.GetOrDefault<Boolean>("enableKeyNav", true); } set { this.attributes["enableKeyNav"] = value; } }                
                    
                    
        private _ignoreRightMouseSelection_default = false;
                    
                    
        [JsonIgnore]
        public Boolean ignoreRightMouseSelection { get { return this.attributes.GetOrDefault<Boolean>("ignoreRightMouseSelection", false); } set { this.attributes["ignoreRightMouseSelection"] = value; } }                
                    
    }
}
