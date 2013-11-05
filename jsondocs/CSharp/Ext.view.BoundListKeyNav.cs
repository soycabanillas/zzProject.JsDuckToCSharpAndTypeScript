using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.view.BoundListKeyNav : Ext.util.KeyNav {
                    
        [JsonIgnore]
        public Ext.view.BoundList boundList { get { return this.attributes.GetOrDefault<Ext.view.BoundList>("boundList", ); } set { this.attributes["boundList"] = value; } }                
                    
    }
}
