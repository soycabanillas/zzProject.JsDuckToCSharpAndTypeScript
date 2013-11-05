using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.File : Ext.form.field.Trigger {
                    
        [JsonIgnore]
        public Object buttonConfig { get { return this.attributes.GetOrDefault<Object>("buttonConfig", ); } set { this.attributes["buttonConfig"] = value; } }                
                    
                    
        private _buttonMargin_default = 3;
                    
                    
        [JsonIgnore]
        public Number buttonMargin { get { return this.attributes.GetOrDefault<Number>("buttonMargin", 3); } set { this.attributes["buttonMargin"] = value; } }                
                    
                    
        private _buttonOnly_default = false;
                    
                    
        [JsonIgnore]
        public Boolean buttonOnly { get { return this.attributes.GetOrDefault<Boolean>("buttonOnly", false); } set { this.attributes["buttonOnly"] = value; } }                
                    
                    
        private _buttonText_default = 'Browse...';
                    
                    
        [JsonIgnore]
        public String buttonText { get { return this.attributes.GetOrDefault<String>("buttonText", 'Browse...'); } set { this.attributes["buttonText"] = value; } }                
                    
                    
        private _clearOnSubmit_default = true;
                    
                    
        [JsonIgnore]
        public Boolean clearOnSubmit { get { return this.attributes.GetOrDefault<Boolean>("clearOnSubmit", true); } set { this.attributes["clearOnSubmit"] = value; } }                
                    
                    
        private _componentLayout_default = 'triggerfield';
                    
                    
        public class MultiType_componentLayout {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'triggerfield'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _readOnly_default = true;
                    
                    
        [JsonIgnore]
        public Boolean readOnly { get { return this.attributes.GetOrDefault<Boolean>("readOnly", true); } set { this.attributes["readOnly"] = value; } }                
                    
    }
}
