using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Base : Ext.Component {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'field';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'field'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _checkChangeBuffer_default = 50;
                    
                    
        [JsonIgnore]
        public Number checkChangeBuffer { get { return this.attributes.GetOrDefault<Number>("checkChangeBuffer", 50); } set { this.attributes["checkChangeBuffer"] = value; } }                
                    
                    
        [JsonIgnore]
        public String[] checkChangeEvents { get { return this.attributes.GetOrDefault<String[]>("checkChangeEvents", ); } set { this.attributes["checkChangeEvents"] = value; } }                
                    
                    
        private _componentLayout_default = 'field';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'field'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _dirtyCls_default = Ext.baseCSSPrefix + 'form-dirty';
                    
                    
        [JsonIgnore]
        public String dirtyCls { get { return this.attributes.GetOrDefault<String>("dirtyCls", Ext.baseCSSPrefix + 'form-dirty'); } set { this.attributes["dirtyCls"] = value; } }                
                    
                    
        private _fieldCls_default = 'x-form-field';
                    
                    
        [JsonIgnore]
        public String fieldCls { get { return this.attributes.GetOrDefault<String>("fieldCls", 'x-form-field'); } set { this.attributes["fieldCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String fieldStyle { get { return this.attributes.GetOrDefault<String>("fieldStyle", ); } set { this.attributes["fieldStyle"] = value; } }                
                    
                    
        private _focusCls_default = 'x-form-focus';
                    
                    
        [JsonIgnore]
        public String focusCls { get { return this.attributes.GetOrDefault<String>("focusCls", 'x-form-focus'); } set { this.attributes["focusCls"] = value; } }                
                    
                    
        public class MultiType_inputAttrTpl {
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
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_inputAttrTpl inputAttrTpl { get { return this.attributes.GetOrDefault<MultiType_inputAttrTpl>("inputAttrTpl", ); } set { this.attributes["inputAttrTpl"] = value; } }                

                    
                    
        [JsonIgnore]
        public String inputId { get { return this.attributes.GetOrDefault<String>("inputId", ); } set { this.attributes["inputId"] = value; } }                
                    
                    
        private _inputType_default = 'text';
                    
                    
        [JsonIgnore]
        public String inputType { get { return this.attributes.GetOrDefault<String>("inputType", 'text'); } set { this.attributes["inputType"] = value; } }                
                    
                    
        private _invalidText_default = 'The value in this field is invalid';
                    
                    
        [JsonIgnore]
        public String invalidText { get { return this.attributes.GetOrDefault<String>("invalidText", 'The value in this field is invalid'); } set { this.attributes["invalidText"] = value; } }                
                    
                    
        [JsonIgnore]
        public String name { get { return this.attributes.GetOrDefault<String>("name", ); } set { this.attributes["name"] = value; } }                
                    
                    
        private _readOnly_default = false;
                    
                    
        [JsonIgnore]
        public Boolean readOnly { get { return this.attributes.GetOrDefault<Boolean>("readOnly", false); } set { this.attributes["readOnly"] = value; } }                
                    
                    
        private _readOnlyCls_default = Ext.baseCSSPrefix + 'form-readonly';
                    
                    
        [JsonIgnore]
        public String readOnlyCls { get { return this.attributes.GetOrDefault<String>("readOnlyCls", Ext.baseCSSPrefix + 'form-readonly'); } set { this.attributes["readOnlyCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number tabIndex { get { return this.attributes.GetOrDefault<Number>("tabIndex", ); } set { this.attributes["tabIndex"] = value; } }                
                    
                    
        private _validateOnBlur_default = true;
                    
                    
        [JsonIgnore]
        public Boolean validateOnBlur { get { return this.attributes.GetOrDefault<Boolean>("validateOnBlur", true); } set { this.attributes["validateOnBlur"] = value; } }                
                    
    }
}
