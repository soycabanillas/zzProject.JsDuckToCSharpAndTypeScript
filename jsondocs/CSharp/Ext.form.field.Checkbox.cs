using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Checkbox : Ext.form.field.Base {
                    
        public class MultiType_afterBoxLabelTextTpl {
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
        public MultiType_afterBoxLabelTextTpl afterBoxLabelTextTpl { get { return this.attributes.GetOrDefault<MultiType_afterBoxLabelTextTpl>("afterBoxLabelTextTpl", ); } set { this.attributes["afterBoxLabelTextTpl"] = value; } }                

                    
                    
        public class MultiType_afterBoxLabelTpl {
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
        public MultiType_afterBoxLabelTpl afterBoxLabelTpl { get { return this.attributes.GetOrDefault<MultiType_afterBoxLabelTpl>("afterBoxLabelTpl", ); } set { this.attributes["afterBoxLabelTpl"] = value; } }                

                    
                    
        public class MultiType_beforeBoxLabelTextTpl {
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
        public MultiType_beforeBoxLabelTextTpl beforeBoxLabelTextTpl { get { return this.attributes.GetOrDefault<MultiType_beforeBoxLabelTextTpl>("beforeBoxLabelTextTpl", ); } set { this.attributes["beforeBoxLabelTextTpl"] = value; } }                

                    
                    
        public class MultiType_beforeBoxLabelTpl {
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
        public MultiType_beforeBoxLabelTpl beforeBoxLabelTpl { get { return this.attributes.GetOrDefault<MultiType_beforeBoxLabelTpl>("beforeBoxLabelTpl", ); } set { this.attributes["beforeBoxLabelTpl"] = value; } }                

                    
                    
        [JsonIgnore]
        public String boxLabel { get { return this.attributes.GetOrDefault<String>("boxLabel", ); } set { this.attributes["boxLabel"] = value; } }                
                    
                    
        private _boxLabelAlign_default = 'after';
                    
                    
        [JsonIgnore]
        public String boxLabelAlign { get { return this.attributes.GetOrDefault<String>("boxLabelAlign", 'after'); } set { this.attributes["boxLabelAlign"] = value; } }                
                    
                    
        public class MultiType_boxLabelAttrTpl {
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
        public MultiType_boxLabelAttrTpl boxLabelAttrTpl { get { return this.attributes.GetOrDefault<MultiType_boxLabelAttrTpl>("boxLabelAttrTpl", ); } set { this.attributes["boxLabelAttrTpl"] = value; } }                

                    
                    
        private _boxLabelCls_default = 'x-form-cb-label';
                    
                    
        [JsonIgnore]
        public String boxLabelCls { get { return this.attributes.GetOrDefault<String>("boxLabelCls", 'x-form-cb-label'); } set { this.attributes["boxLabelCls"] = value; } }                
                    
                    
        private _checkChangeEvents_default = [];
                    
                    
        [JsonIgnore]
        public String[] checkChangeEvents { get { return this.attributes.GetOrDefault<String[]>("checkChangeEvents", []); } set { this.attributes["checkChangeEvents"] = value; } }                
                    
                    
        private _checked_default = false;
                    
                    
        [JsonIgnore]
        public Boolean checked { get { return this.attributes.GetOrDefault<Boolean>("checked", false); } set { this.attributes["checked"] = value; } }                
                    
                    
        private _checkedCls_default = 'x-form-cb-checked';
                    
                    
        [JsonIgnore]
        public String checkedCls { get { return this.attributes.GetOrDefault<String>("checkedCls", 'x-form-cb-checked'); } set { this.attributes["checkedCls"] = value; } }                
                    
                    
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

                    
                    
        private _fieldCls_default = 'x-form-field';
                    
                    
        [JsonIgnore]
        public String fieldCls { get { return this.attributes.GetOrDefault<String>("fieldCls", 'x-form-field'); } set { this.attributes["fieldCls"] = value; } }                
                    
                    
        private _focusCls_default = 'x-form-checkbox-focus';
                    
                    
        [JsonIgnore]
        public String focusCls { get { return this.attributes.GetOrDefault<String>("focusCls", 'x-form-checkbox-focus'); } set { this.attributes["focusCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function handler { get { return this.attributes.GetOrDefault<Function>("handler", ); } set { this.attributes["handler"] = value; } }                
                    
                    
        private _inputType_default = 'checkbox';
                    
                    
        [JsonIgnore]
        public String inputType { get { return this.attributes.GetOrDefault<String>("inputType", 'checkbox'); } set { this.attributes["inputType"] = value; } }                
                    
                    
        private _inputValue_default = 'on';
                    
                    
        [JsonIgnore]
        public String inputValue { get { return this.attributes.GetOrDefault<String>("inputValue", 'on'); } set { this.attributes["inputValue"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        [JsonIgnore]
        public String uncheckedValue { get { return this.attributes.GetOrDefault<String>("uncheckedValue", ); } set { this.attributes["uncheckedValue"] = value; } }                
                    
    }
}
