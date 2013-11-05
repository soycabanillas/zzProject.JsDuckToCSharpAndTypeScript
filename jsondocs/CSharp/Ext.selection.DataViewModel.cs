using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.selection.DataViewModel : Ext.selection.Model {
                    
        private _enableKeyNav_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableKeyNav { get { return this.attributes.GetOrDefault<Boolean>("enableKeyNav", true); } set { this.attributes["enableKeyNav"] = value; } }                
                    
    }
}
