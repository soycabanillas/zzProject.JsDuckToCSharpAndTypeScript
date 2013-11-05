using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.FieldContainer : Ext.container.Container {
                    
        private _combineErrors_default = false;
                    
                    
        [JsonIgnore]
        public Boolean combineErrors { get { return this.attributes.GetOrDefault<Boolean>("combineErrors", false); } set { this.attributes["combineErrors"] = value; } }                
                    
                    
        private _combineLabels_default = false;
                    
                    
        [JsonIgnore]
        public Boolean combineLabels { get { return this.attributes.GetOrDefault<Boolean>("combineLabels", false); } set { this.attributes["combineLabels"] = value; } }                
                    
                    
        private _componentCls_default = Ext.baseCSSPrefix + 'form-fieldcontainer';
                    
                    
        [JsonIgnore]
        public String componentCls { get { return this.attributes.GetOrDefault<String>("componentCls", Ext.baseCSSPrefix + 'form-fieldcontainer'); } set { this.attributes["componentCls"] = value; } }                
                    
                    
        private _componentLayout_default = 'fieldcontainer';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'fieldcontainer'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _invalidCls_default = '';
                    
                    
        [JsonIgnore]
        public String invalidCls { get { return this.attributes.GetOrDefault<String>("invalidCls", ''); } set { this.attributes["invalidCls"] = value; } }                
                    
                    
        private _labelConnector_default = ', ';
                    
                    
        [JsonIgnore]
        public String labelConnector { get { return this.attributes.GetOrDefault<String>("labelConnector", ', '); } set { this.attributes["labelConnector"] = value; } }                
                    
    }
}
