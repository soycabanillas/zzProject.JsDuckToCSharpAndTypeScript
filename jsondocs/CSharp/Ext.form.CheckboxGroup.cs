using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.CheckboxGroup : Ext.form.FieldContainer {
                    
        private _allowBlank_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowBlank { get { return this.attributes.GetOrDefault<Boolean>("allowBlank", true); } set { this.attributes["allowBlank"] = value; } }                
                    
                    
        private _blankText_default = "You must select at least one item in this group";
                    
                    
        [JsonIgnore]
        public String blankText { get { return this.attributes.GetOrDefault<String>("blankText", "You must select at least one item in this group"); } set { this.attributes["blankText"] = value; } }                
                    
                    
        private _columns_default = 'auto';
                    
                    
        public class MultiType_columns {
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
                            
                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            
                            
            public static explicit operator int (Number[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Number[] (int m) {
                return new Number[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_columns columns { get { return this.attributes.GetOrDefault<MultiType_columns>("columns", 'auto'); } set { this.attributes["columns"] = value; } }                

                    
                    
        private _componentCls_default = Ext.baseCSSPrefix + 'form-checkboxgroup';
                    
                    
        [JsonIgnore]
        public String componentCls { get { return this.attributes.GetOrDefault<String>("componentCls", Ext.baseCSSPrefix + 'form-checkboxgroup'); } set { this.attributes["componentCls"] = value; } }                
                    
                    
        private _defaultType_default = 'checkboxfield';
                    
                    
        [JsonIgnore]
        public String defaultType { get { return this.attributes.GetOrDefault<String>("defaultType", 'checkboxfield'); } set { this.attributes["defaultType"] = value; } }                
                    
                    
        public class MultiType_items {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.form.field.Checkbox[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.form.field.Checkbox[] (int m) {
                return new Ext.form.field.Checkbox[] { _value = m };
            }
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_items items { get { return this.attributes.GetOrDefault<MultiType_items>("items", ); } set { this.attributes["items"] = value; } }                

                    
                    
        private _layout_default = 'checkboxgroup';
                    
                    
        public class MultiType_layout {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.enums.Layout m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.enums.Layout (int m) {
                return new Ext.enums.Layout { _value = m };
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", 'checkboxgroup'); } set { this.attributes["layout"] = value; } }                

                    
                    
        private _vertical_default = false;
                    
                    
        [JsonIgnore]
        public Boolean vertical { get { return this.attributes.GetOrDefault<Boolean>("vertical", false); } set { this.attributes["vertical"] = value; } }                
                    
    }
}
