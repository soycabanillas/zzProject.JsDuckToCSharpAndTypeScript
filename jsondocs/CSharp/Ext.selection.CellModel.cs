using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.selection.CellModel : Ext.selection.Model {
                    
        private _enableKeyNav_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableKeyNav { get { return this.attributes.GetOrDefault<Boolean>("enableKeyNav", true); } set { this.attributes["enableKeyNav"] = value; } }                
                    
                    
        [JsonIgnore]
        public "SINGLE" mode { get { return this.attributes.GetOrDefault<"SINGLE">("mode", ); } set { this.attributes["mode"] = value; } }                
                    
                    
        private _preventWrap_default = false;
                    
                    
        [JsonIgnore]
        public Boolean preventWrap { get { return this.attributes.GetOrDefault<Boolean>("preventWrap", false); } set { this.attributes["preventWrap"] = value; } }                
                    
    }
}
