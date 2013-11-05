using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.ClickRepeater : Ext.util.Observable {
                    
        [JsonIgnore]
        public Boolean accelerate { get { return this.attributes.GetOrDefault<Boolean>("accelerate", ); } set { this.attributes["accelerate"] = value; } }                
                    
                    
        private _delay_default = 250;
                    
                    
        [JsonIgnore]
        public Number delay { get { return this.attributes.GetOrDefault<Number>("delay", 250); } set { this.attributes["delay"] = value; } }                
                    
                    
        public class MultiType_el {
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
        public MultiType_el el { get { return this.attributes.GetOrDefault<MultiType_el>("el", ); } set { this.attributes["el"] = value; } }                

                    
                    
        private _interval_default = 20;
                    
                    
        [JsonIgnore]
        public Number interval { get { return this.attributes.GetOrDefault<Number>("interval", 20); } set { this.attributes["interval"] = value; } }                
                    
                    
        [JsonIgnore]
        public String pressedCls { get { return this.attributes.GetOrDefault<String>("pressedCls", ); } set { this.attributes["pressedCls"] = value; } }                
                    
                    
        private _preventDefault_default = true;
                    
                    
        [JsonIgnore]
        public Boolean preventDefault { get { return this.attributes.GetOrDefault<Boolean>("preventDefault", true); } set { this.attributes["preventDefault"] = value; } }                
                    
                    
        private _stopDefault_default = false;
                    
                    
        [JsonIgnore]
        public Boolean stopDefault { get { return this.attributes.GetOrDefault<Boolean>("stopDefault", false); } set { this.attributes["stopDefault"] = value; } }                
                    
    }
}
