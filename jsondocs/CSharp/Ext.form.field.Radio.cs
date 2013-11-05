using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Radio : Ext.form.field.Checkbox {
                    
        private _focusCls_default = 'x-form-radio-focus';
                    
                    
        [JsonIgnore]
        public String focusCls { get { return this.attributes.GetOrDefault<String>("focusCls", 'x-form-radio-focus'); } set { this.attributes["focusCls"] = value; } }                
                    
                    
        private _inputType_default = 'radio';
                    
                    
        [JsonIgnore]
        public String inputType { get { return this.attributes.GetOrDefault<String>("inputType", 'radio'); } set { this.attributes["inputType"] = value; } }                
                    
    }
}
