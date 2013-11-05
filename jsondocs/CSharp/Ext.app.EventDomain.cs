using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.app.EventDomain : Ext.Base {
                    
        [JsonIgnore]
        public String idProperty { get { return this.attributes.GetOrDefault<String>("idProperty", ); } set { this.attributes["idProperty"] = value; } }                
                    
    }
}
