using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.ElementLoader : Ext.Base {
                    
        [JsonIgnore]
        public Object ajaxOptions { get { return this.attributes.GetOrDefault<Object>("ajaxOptions", ); } set { this.attributes["ajaxOptions"] = value; } }                
                    
                    
        private _autoLoad_default = false;
                    
                    
        public class MultiType_autoLoad {
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
        public MultiType_autoLoad autoLoad { get { return this.attributes.GetOrDefault<MultiType_autoLoad>("autoLoad", false); } set { this.attributes["autoLoad"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object baseParams { get { return this.attributes.GetOrDefault<Object>("baseParams", ); } set { this.attributes["baseParams"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function callback { get { return this.attributes.GetOrDefault<Function>("callback", ); } set { this.attributes["callback"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function failure { get { return this.attributes.GetOrDefault<Function>("failure", ); } set { this.attributes["failure"] = value; } }                
                    
                    
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
        public MultiType_loadMask loadMask { get { return this.attributes.GetOrDefault<MultiType_loadMask>("loadMask", false); } set { this.attributes["loadMask"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object params { get { return this.attributes.GetOrDefault<Object>("params", ); } set { this.attributes["params"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function renderer { get { return this.attributes.GetOrDefault<Function>("renderer", ); } set { this.attributes["renderer"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _scripts_default = false;
                    
                    
        [JsonIgnore]
        public Boolean scripts { get { return this.attributes.GetOrDefault<Boolean>("scripts", false); } set { this.attributes["scripts"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function success { get { return this.attributes.GetOrDefault<Function>("success", ); } set { this.attributes["success"] = value; } }                
                    
                    
        public class MultiType_target {
            public new Type GetType()
            {
                return _value.GetType();
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

                    
                    
        [JsonIgnore]
        public String url { get { return this.attributes.GetOrDefault<String>("url", ); } set { this.attributes["url"] = value; } }                
                    
    }
}
