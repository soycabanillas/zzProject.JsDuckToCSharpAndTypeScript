using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.FieldAncestor : Ext.Base {
                    
        [JsonIgnore]
        public Object fieldDefaults { get { return this.attributes.GetOrDefault<Object>("fieldDefaults", ); } set { this.attributes["fieldDefaults"] = value; } }                
                    
    }
}
