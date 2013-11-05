using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.Class :  {
                    
        [JsonIgnore]
        public String[] alias { get { return this.attributes.GetOrDefault<String[]>("alias", ); } set { this.attributes["alias"] = value; } }                
                    
                    
        public class MultiType_alternateClassName {
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
        public MultiType_alternateClassName alternateClassName { get { return this.attributes.GetOrDefault<MultiType_alternateClassName>("alternateClassName", ); } set { this.attributes["alternateClassName"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object config { get { return this.attributes.GetOrDefault<Object>("config", ); } set { this.attributes["config"] = value; } }                
                    
                    
        [JsonIgnore]
        public String extend { get { return this.attributes.GetOrDefault<String>("extend", ); } set { this.attributes["extend"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object inheritableStatics { get { return this.attributes.GetOrDefault<Object>("inheritableStatics", ); } set { this.attributes["inheritableStatics"] = value; } }                
                    
                    
        public class MultiType_mixins {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String[] (int m) {
                return new String[] { _value = m };
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
        public MultiType_mixins mixins { get { return this.attributes.GetOrDefault<MultiType_mixins>("mixins", ); } set { this.attributes["mixins"] = value; } }                

                    
                    
        [JsonIgnore]
        public String[] requires { get { return this.attributes.GetOrDefault<String[]>("requires", ); } set { this.attributes["requires"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean singleton { get { return this.attributes.GetOrDefault<Boolean>("singleton", ); } set { this.attributes["singleton"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object statics { get { return this.attributes.GetOrDefault<Object>("statics", ); } set { this.attributes["statics"] = value; } }                
                    
                    
        [JsonIgnore]
        public String[] uses { get { return this.attributes.GetOrDefault<String[]>("uses", ); } set { this.attributes["uses"] = value; } }                
                    
    }
}
