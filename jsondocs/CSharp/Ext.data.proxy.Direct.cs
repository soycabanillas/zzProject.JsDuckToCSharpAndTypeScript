using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.proxy.Direct : Ext.data.proxy.Server {
                    
        [JsonIgnore]
        public Object api { get { return this.attributes.GetOrDefault<Object>("api", ); } set { this.attributes["api"] = value; } }                
                    
                    
        public class MultiType_directFn {
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
        public MultiType_directFn directFn { get { return this.attributes.GetOrDefault<MultiType_directFn>("directFn", ); } set { this.attributes["directFn"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object extraParams { get { return this.attributes.GetOrDefault<Object>("extraParams", ); } set { this.attributes["extraParams"] = value; } }                
                    
                    
        public class MultiType_paramOrder {
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
                            
                            
            public static explicit operator int (String[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String[] (int m) {
                return new String[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_paramOrder paramOrder { get { return this.attributes.GetOrDefault<MultiType_paramOrder>("paramOrder", ); } set { this.attributes["paramOrder"] = value; } }                

                    
                    
        private _paramsAsHash_default = true;
                    
                    
        [JsonIgnore]
        public Boolean paramsAsHash { get { return this.attributes.GetOrDefault<Boolean>("paramsAsHash", true); } set { this.attributes["paramsAsHash"] = value; } }                
                    
    }
}
