using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tip.Tip : Ext.panel.Panel {
                    
        private _autoRender_default = true;
                    
                    
        public class MultiType_autoRender {
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
        public MultiType_autoRender autoRender { get { return this.attributes.GetOrDefault<MultiType_autoRender>("autoRender", true); } set { this.attributes["autoRender"] = value; } }                

                    
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'tip';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'tip'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _closable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean closable { get { return this.attributes.GetOrDefault<Boolean>("closable", false); } set { this.attributes["closable"] = value; } }                
                    
                    
        private _closeAction_default = 'hide';
                    
                    
        [JsonIgnore]
        public String closeAction { get { return this.attributes.GetOrDefault<String>("closeAction", 'hide'); } set { this.attributes["closeAction"] = value; } }                
                    
                    
        private _constrainPosition_default = true;
                    
                    
        [JsonIgnore]
        public Boolean constrainPosition { get { return this.attributes.GetOrDefault<Boolean>("constrainPosition", true); } set { this.attributes["constrainPosition"] = value; } }                
                    
                    
        private _defaultAlign_default = "tl-bl?";
                    
                    
        [JsonIgnore]
        public String defaultAlign { get { return this.attributes.GetOrDefault<String>("defaultAlign", "tl-bl?"); } set { this.attributes["defaultAlign"] = value; } }                
                    
                    
        private _floating_default = {shadow: true, shim: true};
                    
                    
        [JsonIgnore]
        public Boolean floating { get { return this.attributes.GetOrDefault<Boolean>("floating", {shadow: true, shim: true}); } set { this.attributes["floating"] = value; } }                
                    
                    
        private _focusOnToFront_default = false;
                    
                    
        [JsonIgnore]
        public Boolean focusOnToFront { get { return this.attributes.GetOrDefault<Boolean>("focusOnToFront", false); } set { this.attributes["focusOnToFront"] = value; } }                
                    
                    
        private _frameHeader_default = false;
                    
                    
        [JsonIgnore]
        public Boolean frameHeader { get { return this.attributes.GetOrDefault<Boolean>("frameHeader", false); } set { this.attributes["frameHeader"] = value; } }                
                    
                    
        private _hidden_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hidden { get { return this.attributes.GetOrDefault<Boolean>("hidden", true); } set { this.attributes["hidden"] = value; } }                
                    
                    
        private _maxWidth_default = 500;
                    
                    
        [JsonIgnore]
        public Number maxWidth { get { return this.attributes.GetOrDefault<Number>("maxWidth", 500); } set { this.attributes["maxWidth"] = value; } }                
                    
                    
        private _minWidth_default = 40;
                    
                    
        [JsonIgnore]
        public Number minWidth { get { return this.attributes.GetOrDefault<Number>("minWidth", 40); } set { this.attributes["minWidth"] = value; } }                
                    
                    
        private _shadow_default = "sides";
                    
                    
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
        public MultiType_shadow shadow { get { return this.attributes.GetOrDefault<MultiType_shadow>("shadow", "sides"); } set { this.attributes["shadow"] = value; } }                

                    
                    
        private _width_default = 'auto';
                    
                    
        [JsonIgnore]
        public Number width { get { return this.attributes.GetOrDefault<Number>("width", 'auto'); } set { this.attributes["width"] = value; } }                
                    
    }
}
