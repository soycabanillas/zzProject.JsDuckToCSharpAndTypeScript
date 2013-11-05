using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.direct.RemotingProvider : Ext.direct.JsonProvider {
                    
        [JsonIgnore]
        public Object actions { get { return this.attributes.GetOrDefault<Object>("actions", ); } set { this.attributes["actions"] = value; } }                
                    
                    
        private _disableNestedActions_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disableNestedActions { get { return this.attributes.GetOrDefault<Boolean>("disableNestedActions", false); } set { this.attributes["disableNestedActions"] = value; } }                
                    
                    
        private _enableBuffer_default = 10;
                    
                    
        public class MultiType_enableBuffer {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            
                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_enableBuffer enableBuffer { get { return this.attributes.GetOrDefault<MultiType_enableBuffer>("enableBuffer", 10); } set { this.attributes["enableBuffer"] = value; } }                

                    
                    
        private _enableUrlEncode_default = data;
                    
                    
        [JsonIgnore]
        public String enableUrlEncode { get { return this.attributes.GetOrDefault<String>("enableUrlEncode", data); } set { this.attributes["enableUrlEncode"] = value; } }                
                    
                    
        private _maxRetries_default = 1;
                    
                    
        [JsonIgnore]
        public Number maxRetries { get { return this.attributes.GetOrDefault<Number>("maxRetries", 1); } set { this.attributes["maxRetries"] = value; } }                
                    
                    
        public class MultiType_namespace {
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
        public MultiType_namespace namespace { get { return this.attributes.GetOrDefault<MultiType_namespace>("namespace", ); } set { this.attributes["namespace"] = value; } }                

                    
                    
        [JsonIgnore]
        public Number timeout { get { return this.attributes.GetOrDefault<Number>("timeout", ); } set { this.attributes["timeout"] = value; } }                
                    
                    
        [JsonIgnore]
        public String url { get { return this.attributes.GetOrDefault<String>("url", ); } set { this.attributes["url"] = value; } }                
                    
    }
}
