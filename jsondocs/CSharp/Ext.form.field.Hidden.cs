using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Hidden : Ext.form.field.Base {
                    
        private _hidden_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hidden { get { return this.attributes.GetOrDefault<Boolean>("hidden", true); } set { this.attributes["hidden"] = value; } }                
                    
                    
        private _hideLabel_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hideLabel { get { return this.attributes.GetOrDefault<Boolean>("hideLabel", true); } set { this.attributes["hideLabel"] = value; } }                
                    
                    
        private _inputType_default = 'hidden';
                    
                    
        [JsonIgnore]
        public String inputType { get { return this.attributes.GetOrDefault<String>("inputType", 'hidden'); } set { this.attributes["inputType"] = value; } }                
                    
    }
}
