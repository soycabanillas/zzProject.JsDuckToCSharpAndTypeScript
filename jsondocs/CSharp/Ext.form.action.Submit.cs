using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.action.Submit : Ext.form.action.Action {
                    
        private _clientValidation_default = true;
                    
                    
        [JsonIgnore]
        public Boolean clientValidation { get { return this.attributes.GetOrDefault<Boolean>("clientValidation", true); } set { this.attributes["clientValidation"] = value; } }                
                    
    }
}
