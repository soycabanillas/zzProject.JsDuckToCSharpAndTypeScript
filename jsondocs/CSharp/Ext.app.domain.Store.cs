using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.app.domain.Store : Ext.app.EventDomain {
                    
        private _idProperty_default = 'storeId';
                    
                    
        [JsonIgnore]
        public String idProperty { get { return this.attributes.GetOrDefault<String>("idProperty", 'storeId'); } set { this.attributes["idProperty"] = value; } }                
                    
    }
}
