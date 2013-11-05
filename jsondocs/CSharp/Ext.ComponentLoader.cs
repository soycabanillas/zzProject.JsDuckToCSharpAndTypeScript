using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.ComponentLoader : Ext.ElementLoader {
                    
        private _loadMask_default = false;
                    
                    
        public class MultiType_loadMask {
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
        public MultiType_loadMask loadMask { get { return this.attributes.GetOrDefault<MultiType_loadMask>("loadMask", false); } set { this.attributes["loadMask"] = value; } }                

                    
                    
        private _renderer_default = 'html';
                    
                    
        public class MultiType_renderer {
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
        public MultiType_renderer renderer { get { return this.attributes.GetOrDefault<MultiType_renderer>("renderer", 'html'); } set { this.attributes["renderer"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean scripts { get { return this.attributes.GetOrDefault<Boolean>("scripts", ); } set { this.attributes["scripts"] = value; } }                
                    
                    
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
