using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.window.Window : Ext.panel.Panel {
                    
        private _animateTarget_default = null;
                    
                    
        public class MultiType_animateTarget {
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
        public MultiType_animateTarget animateTarget { get { return this.attributes.GetOrDefault<MultiType_animateTarget>("animateTarget", null); } set { this.attributes["animateTarget"] = value; } }                

                    
                    
        private _autoRender_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoRender { get { return this.attributes.GetOrDefault<Boolean>("autoRender", true); } set { this.attributes["autoRender"] = value; } }                
                    
                    
        private _baseCls_default = 'x-window';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", 'x-window'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _closable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean closable { get { return this.attributes.GetOrDefault<Boolean>("closable", true); } set { this.attributes["closable"] = value; } }                
                    
                    
        private _collapsed_default = false;
                    
                    
        [JsonIgnore]
        public Boolean collapsed { get { return this.attributes.GetOrDefault<Boolean>("collapsed", false); } set { this.attributes["collapsed"] = value; } }                
                    
                    
        private _collapsible_default = false;
                    
                    
        [JsonIgnore]
        public Boolean collapsible { get { return this.attributes.GetOrDefault<Boolean>("collapsible", false); } set { this.attributes["collapsible"] = value; } }                
                    
                    
        private _constrain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", false); } set { this.attributes["constrain"] = value; } }                
                    
                    
        private _constrainHeader_default = false;
                    
                    
        [JsonIgnore]
        public Boolean constrainHeader { get { return this.attributes.GetOrDefault<Boolean>("constrainHeader", false); } set { this.attributes["constrainHeader"] = value; } }                
                    
                    
        public class MultiType_defaultFocus {
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
                            
                            
            public static explicit operator int (Ext.Component m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Component (int m) {
                return new Ext.Component { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_defaultFocus defaultFocus { get { return this.attributes.GetOrDefault<MultiType_defaultFocus>("defaultFocus", ); } set { this.attributes["defaultFocus"] = value; } }                

                    
                    
        private _draggable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean draggable { get { return this.attributes.GetOrDefault<Boolean>("draggable", true); } set { this.attributes["draggable"] = value; } }                
                    
                    
        private _expandOnShow_default = true;
                    
                    
        [JsonIgnore]
        public Boolean expandOnShow { get { return this.attributes.GetOrDefault<Boolean>("expandOnShow", true); } set { this.attributes["expandOnShow"] = value; } }                
                    
                    
        public class MultiType_ghost {
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
        public MultiType_ghost ghost { get { return this.attributes.GetOrDefault<MultiType_ghost>("ghost", ); } set { this.attributes["ghost"] = value; } }                

                    
                    
        private _hidden_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hidden { get { return this.attributes.GetOrDefault<Boolean>("hidden", true); } set { this.attributes["hidden"] = value; } }                
                    
                    
        private _hideMode_default = 'offsets';
                    
                    
        [JsonIgnore]
        public String hideMode { get { return this.attributes.GetOrDefault<String>("hideMode", 'offsets'); } set { this.attributes["hideMode"] = value; } }                
                    
                    
        private _hideShadowOnDeactivate_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideShadowOnDeactivate { get { return this.attributes.GetOrDefault<Boolean>("hideShadowOnDeactivate", false); } set { this.attributes["hideShadowOnDeactivate"] = value; } }                
                    
                    
        private _maximizable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean maximizable { get { return this.attributes.GetOrDefault<Boolean>("maximizable", false); } set { this.attributes["maximizable"] = value; } }                
                    
                    
        private _maximized_default = false;
                    
                    
        [JsonIgnore]
        public Boolean maximized { get { return this.attributes.GetOrDefault<Boolean>("maximized", false); } set { this.attributes["maximized"] = value; } }                
                    
                    
        private _minHeight_default = 50;
                    
                    
        [JsonIgnore]
        public Number minHeight { get { return this.attributes.GetOrDefault<Number>("minHeight", 50); } set { this.attributes["minHeight"] = value; } }                
                    
                    
        private _minWidth_default = 50;
                    
                    
        [JsonIgnore]
        public Number minWidth { get { return this.attributes.GetOrDefault<Number>("minWidth", 50); } set { this.attributes["minWidth"] = value; } }                
                    
                    
        private _minimizable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean minimizable { get { return this.attributes.GetOrDefault<Boolean>("minimizable", false); } set { this.attributes["minimizable"] = value; } }                
                    
                    
        private _modal_default = false;
                    
                    
        [JsonIgnore]
        public Boolean modal { get { return this.attributes.GetOrDefault<Boolean>("modal", false); } set { this.attributes["modal"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function onEsc { get { return this.attributes.GetOrDefault<Function>("onEsc", ); } set { this.attributes["onEsc"] = value; } }                
                    
                    
        private _overlapHeader_default = true;
                    
                    
        [JsonIgnore]
        public Boolean overlapHeader { get { return this.attributes.GetOrDefault<Boolean>("overlapHeader", true); } set { this.attributes["overlapHeader"] = value; } }                
                    
                    
        private _plain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean plain { get { return this.attributes.GetOrDefault<Boolean>("plain", false); } set { this.attributes["plain"] = value; } }                
                    
                    
        private _resizable_default = true;
                    
                    
        public class MultiType_resizable {
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
        public MultiType_resizable resizable { get { return this.attributes.GetOrDefault<MultiType_resizable>("resizable", true); } set { this.attributes["resizable"] = value; } }                

                    
                    
        [JsonIgnore]
        public Number x { get { return this.attributes.GetOrDefault<Number>("x", ); } set { this.attributes["x"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number y { get { return this.attributes.GetOrDefault<Number>("y", ); } set { this.attributes["y"] = value; } }                
                    
    }
}
