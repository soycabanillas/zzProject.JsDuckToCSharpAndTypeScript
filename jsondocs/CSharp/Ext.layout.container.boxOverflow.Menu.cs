using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.boxOverflow.Menu : Ext.layout.container.boxOverflow.None {
                    
        [JsonIgnore]
        public String triggerButtonCls { get { return this.attributes.GetOrDefault<String>("triggerButtonCls", ); } set { this.attributes["triggerButtonCls"] = value; } }                
                    
    }
}
