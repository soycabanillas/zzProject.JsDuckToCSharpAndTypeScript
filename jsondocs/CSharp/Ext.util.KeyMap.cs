using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.KeyMap : Ext.Base {
                    
        public class MultiType_binding {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
            }
                            
                            
            public static explicit operator int (Object[][] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[][] (int m) {
                return new Object[][] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_binding binding { get { return this.attributes.GetOrDefault<MultiType_binding>("binding", ); } set { this.attributes["binding"] = value; } }                

                    
                    
        private _eventName_default = 'keydown';
                    
                    
        [JsonIgnore]
        public String eventName { get { return this.attributes.GetOrDefault<String>("eventName", 'keydown'); } set { this.attributes["eventName"] = value; } }                
                    
                    
        private _ignoreInputFields_default = false;
                    
                    
        [JsonIgnore]
        public Boolean ignoreInputFields { get { return this.attributes.GetOrDefault<Boolean>("ignoreInputFields", false); } set { this.attributes["ignoreInputFields"] = value; } }                
                    
                    
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
