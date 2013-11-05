using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.action.StandardSubmit : Ext.form.action.Submit {
                    
        [JsonIgnore]
        public String target { get { return this.attributes.GetOrDefault<String>("target", ); } set { this.attributes["target"] = value; } }                
                    
    }
}
