using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.toolbar.Item : Ext.Component {
                    
        [JsonIgnore]
        public String overflowText { get { return this.attributes.GetOrDefault<String>("overflowText", ); } set { this.attributes["overflowText"] = value; } }                
                    
    }
}
