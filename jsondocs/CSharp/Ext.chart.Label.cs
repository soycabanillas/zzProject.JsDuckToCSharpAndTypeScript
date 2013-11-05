using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.Label : Ext.Base {
                    
        [JsonIgnore]
        public Object label { get { return this.attributes.GetOrDefault<Object>("label", ); } set { this.attributes["label"] = value; } }                
                    
    }
}
