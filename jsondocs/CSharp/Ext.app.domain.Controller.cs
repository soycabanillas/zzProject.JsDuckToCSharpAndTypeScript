using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.app.domain.Controller : Ext.app.EventDomain {
                    
        private _idProperty_default = 'id';
                    
                    
        [JsonIgnore]
        public String idProperty { get { return this.attributes.GetOrDefault<String>("idProperty", 'id'); } set { this.attributes["idProperty"] = value; } }                
                    
    }
}
