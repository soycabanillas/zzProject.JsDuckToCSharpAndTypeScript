using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.BufferStore : Ext.data.Store {
                    
        private _filterOnLoad_default = false;
                    
                    
        [JsonIgnore]
        public Boolean filterOnLoad { get { return this.attributes.GetOrDefault<Boolean>("filterOnLoad", false); } set { this.attributes["filterOnLoad"] = value; } }                
                    
                    
        private _sortOnLoad_default = false;
                    
                    
        [JsonIgnore]
        public Boolean sortOnLoad { get { return this.attributes.GetOrDefault<Boolean>("sortOnLoad", false); } set { this.attributes["sortOnLoad"] = value; } }                
                    
    }
}
