using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.property.Store : Ext.data.Store {
                    
        private _sortOnLoad_default = false;
                    
                    
        [JsonIgnore]
        public Boolean sortOnLoad { get { return this.attributes.GetOrDefault<Boolean>("sortOnLoad", false); } set { this.attributes["sortOnLoad"] = value; } }                
                    
    }
}
