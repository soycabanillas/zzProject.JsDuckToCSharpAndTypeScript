using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.axis.Abstract : Ext.Base {
                    
        [JsonIgnore]
        public String[] fields { get { return this.attributes.GetOrDefault<String[]>("fields", ); } set { this.attributes["fields"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.chart.Label label { get { return this.attributes.GetOrDefault<Ext.chart.Label>("label", ); } set { this.attributes["label"] = value; } }                
                    
    }
}
