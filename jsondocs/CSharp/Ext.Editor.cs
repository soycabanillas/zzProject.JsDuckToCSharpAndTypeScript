using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.Editor : Ext.container.Container {
                    
        private _alignment_default = 'c-c?';
                    
                    
        [JsonIgnore]
        public String alignment { get { return this.attributes.GetOrDefault<String>("alignment", 'c-c?'); } set { this.attributes["alignment"] = value; } }                
                    
                    
        private _allowBlur_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowBlur { get { return this.attributes.GetOrDefault<Boolean>("allowBlur", true); } set { this.attributes["allowBlur"] = value; } }                
                    
                    
        public class MultiType_autoSize {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
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
        public MultiType_autoSize autoSize { get { return this.attributes.GetOrDefault<MultiType_autoSize>("autoSize", ); } set { this.attributes["autoSize"] = value; } }                

                    
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'editor';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'editor'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _cancelOnEsc_default = true;
                    
                    
        [JsonIgnore]
        public Boolean cancelOnEsc { get { return this.attributes.GetOrDefault<Boolean>("cancelOnEsc", true); } set { this.attributes["cancelOnEsc"] = value; } }                
                    
                    
        private _completeOnEnter_default = true;
                    
                    
        [JsonIgnore]
        public Boolean completeOnEnter { get { return this.attributes.GetOrDefault<Boolean>("completeOnEnter", true); } set { this.attributes["completeOnEnter"] = value; } }                
                    
                    
        private _constrain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", false); } set { this.attributes["constrain"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.form.field.Field field { get { return this.attributes.GetOrDefault<Ext.form.field.Field>("field", ); } set { this.attributes["field"] = value; } }                
                    
                    
        private _focusOnToFront_default = false;
                    
                    
        [JsonIgnore]
        public Boolean focusOnToFront { get { return this.attributes.GetOrDefault<Boolean>("focusOnToFront", false); } set { this.attributes["focusOnToFront"] = value; } }                
                    
                    
        private _hidden_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hidden { get { return this.attributes.GetOrDefault<Boolean>("hidden", true); } set { this.attributes["hidden"] = value; } }                
                    
                    
        private _hideEl_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hideEl { get { return this.attributes.GetOrDefault<Boolean>("hideEl", true); } set { this.attributes["hideEl"] = value; } }                
                    
                    
        private _ignoreNoChange_default = false;
                    
                    
        [JsonIgnore]
        public Boolean ignoreNoChange { get { return this.attributes.GetOrDefault<Boolean>("ignoreNoChange", false); } set { this.attributes["ignoreNoChange"] = value; } }                
                    
                    
        private _layout_default = 'editor';
                    
                    
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", 'editor'); } set { this.attributes["layout"] = value; } }                

                    
                    
        private _offsets_default = [0, 0];
                    
                    
        [JsonIgnore]
        public Number[] offsets { get { return this.attributes.GetOrDefault<Number[]>("offsets", [0, 0]); } set { this.attributes["offsets"] = value; } }                
                    
                    
        private _parentEl_default = document.body;
                    
                    
        public class MultiType_parentEl {
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
                            
                            
            public static explicit operator int (HTMLElement m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator HTMLElement (int m) {
                return new HTMLElement { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.Element m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Element (int m) {
                return new Ext.Element { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_parentEl parentEl { get { return this.attributes.GetOrDefault<MultiType_parentEl>("parentEl", document.body); } set { this.attributes["parentEl"] = value; } }                

                    
                    
        private _revertInvalid_default = true;
                    
                    
        [JsonIgnore]
        public Boolean revertInvalid { get { return this.attributes.GetOrDefault<Boolean>("revertInvalid", true); } set { this.attributes["revertInvalid"] = value; } }                
                    
                    
        private _shadow_default = 'frame';
                    
                    
        public class MultiType_shadow {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
            }
                            
                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_shadow shadow { get { return this.attributes.GetOrDefault<MultiType_shadow>("shadow", 'frame'); } set { this.attributes["shadow"] = value; } }                

                    
                    
        private _swallowKeys_default = true;
                    
                    
        [JsonIgnore]
        public Boolean swallowKeys { get { return this.attributes.GetOrDefault<Boolean>("swallowKeys", true); } set { this.attributes["swallowKeys"] = value; } }                
                    
                    
        private _updateEl_default = false;
                    
                    
        [JsonIgnore]
        public Boolean updateEl { get { return this.attributes.GetOrDefault<Boolean>("updateEl", false); } set { this.attributes["updateEl"] = value; } }                
                    
                    
        private _value_default = '';
                    
                    
        [JsonIgnore]
        public Object value { get { return this.attributes.GetOrDefault<Object>("value", ''); } set { this.attributes["value"] = value; } }                
                    
    }
}
