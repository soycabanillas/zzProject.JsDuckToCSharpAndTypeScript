using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.KeyNav : Ext.Base {
                    
        private _defaultEventAction_default = "stopEvent";
                    
                    
        [JsonIgnore]
        public String defaultEventAction { get { return this.attributes.GetOrDefault<String>("defaultEventAction", "stopEvent"); } set { this.attributes["defaultEventAction"] = value; } }                
                    
                    
        private _disabled_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disabled { get { return this.attributes.GetOrDefault<Boolean>("disabled", false); } set { this.attributes["disabled"] = value; } }                
                    
                    
        private _eventName_default = 'keypress';
                    
                    
        [JsonIgnore]
        public String eventName { get { return this.attributes.GetOrDefault<String>("eventName", 'keypress'); } set { this.attributes["eventName"] = value; } }                
                    
                    
        private _forceKeyDown_default = false;
                    
                    
        [JsonIgnore]
        public Boolean forceKeyDown { get { return this.attributes.GetOrDefault<Boolean>("forceKeyDown", false); } set { this.attributes["forceKeyDown"] = value; } }                
                    
                    
        private _ignoreInputFields_default = false;
                    
                    
        [JsonIgnore]
        public Boolean ignoreInputFields { get { return this.attributes.GetOrDefault<Boolean>("ignoreInputFields", false); } set { this.attributes["ignoreInputFields"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.util.KeyMap keyMap { get { return this.attributes.GetOrDefault<Ext.util.KeyMap>("keyMap", ); } set { this.attributes["keyMap"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function processEvent { get { return this.attributes.GetOrDefault<Function>("processEvent", ); } set { this.attributes["processEvent"] = value; } }                
                    
                    
        private _processEventScope_default = this;
                    
                    
        [JsonIgnore]
        public Object processEventScope { get { return this.attributes.GetOrDefault<Object>("processEventScope", this); } set { this.attributes["processEventScope"] = value; } }                
                    
                    
        public class MultiType_target {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.Component m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Component (int m) {
                return new Ext.Component { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.Element m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Element (int m) {
                return new Ext.Element { _value = m };
            }
                            
                            
            public static explicit operator int (HTMLElement m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator HTMLElement (int m) {
                return new HTMLElement { _value = m };
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
        public MultiType_target target { get { return this.attributes.GetOrDefault<MultiType_target>("target", ); } set { this.attributes["target"] = value; } }                

                    
    }
}
