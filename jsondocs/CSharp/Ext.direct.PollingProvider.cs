using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.direct.PollingProvider : Ext.direct.JsonProvider {
                    
        [JsonIgnore]
        public Object baseParams { get { return this.attributes.GetOrDefault<Object>("baseParams", ); } set { this.attributes["baseParams"] = value; } }                
                    
                    
        private _interval_default = 3000;
                    
                    
        [JsonIgnore]
        public Number interval { get { return this.attributes.GetOrDefault<Number>("interval", 3000); } set { this.attributes["interval"] = value; } }                
                    
                    
        public class MultiType_url {
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
        public MultiType_url url { get { return this.attributes.GetOrDefault<MultiType_url>("url", ); } set { this.attributes["url"] = value; } }                

                    
    }
}
