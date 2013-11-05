using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Field : Ext.Base {
                    
        private _disabled_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disabled { get { return this.attributes.GetOrDefault<Boolean>("disabled", false); } set { this.attributes["disabled"] = value; } }                
                    
                    
        [JsonIgnore]
        public String name { get { return this.attributes.GetOrDefault<String>("name", ); } set { this.attributes["name"] = value; } }                
                    
                    
        private _submitValue_default = true;
                    
                    
        [JsonIgnore]
        public Boolean submitValue { get { return this.attributes.GetOrDefault<Boolean>("submitValue", true); } set { this.attributes["submitValue"] = value; } }                
                    
                    
        private _validateOnChange_default = true;
                    
                    
        [JsonIgnore]
        public Boolean validateOnChange { get { return this.attributes.GetOrDefault<Boolean>("validateOnChange", true); } set { this.attributes["validateOnChange"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object value { get { return this.attributes.GetOrDefault<Object>("value", ); } set { this.attributes["value"] = value; } }                
                    
    }
}
