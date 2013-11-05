using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.direct.Transaction : Ext.Base {
                    
        [JsonIgnore]
        public Ext.direct.Provider provider { get { return this.attributes.GetOrDefault<Ext.direct.Provider>("provider", ); } set { this.attributes["provider"] = value; } }                
                    
    }
}
