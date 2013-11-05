using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.CheckboxGroup : Ext.layout.container.Container {
                    
        private _autoFlex_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoFlex { get { return this.attributes.GetOrDefault<Boolean>("autoFlex", true); } set { this.attributes["autoFlex"] = value; } }                
                    
    }
}
