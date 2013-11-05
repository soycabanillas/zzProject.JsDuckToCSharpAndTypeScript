using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Spinner : Ext.form.field.Trigger {
                    
        private _keyNavEnabled_default = true;
                    
                    
        [JsonIgnore]
        public Boolean keyNavEnabled { get { return this.attributes.GetOrDefault<Boolean>("keyNavEnabled", true); } set { this.attributes["keyNavEnabled"] = value; } }                
                    
                    
        private _mouseWheelEnabled_default = true;
                    
                    
        [JsonIgnore]
        public Boolean mouseWheelEnabled { get { return this.attributes.GetOrDefault<Boolean>("mouseWheelEnabled", true); } set { this.attributes["mouseWheelEnabled"] = value; } }                
                    
                    
        private _repeatTriggerClick_default = true;
                    
                    
        [JsonIgnore]
        public Boolean repeatTriggerClick { get { return this.attributes.GetOrDefault<Boolean>("repeatTriggerClick", true); } set { this.attributes["repeatTriggerClick"] = value; } }                
                    
                    
        private _spinDownEnabled_default = true;
                    
                    
        [JsonIgnore]
        public Boolean spinDownEnabled { get { return this.attributes.GetOrDefault<Boolean>("spinDownEnabled", true); } set { this.attributes["spinDownEnabled"] = value; } }                
                    
                    
        private _spinUpEnabled_default = true;
                    
                    
        [JsonIgnore]
        public Boolean spinUpEnabled { get { return this.attributes.GetOrDefault<Boolean>("spinUpEnabled", true); } set { this.attributes["spinUpEnabled"] = value; } }                
                    
    }
}
