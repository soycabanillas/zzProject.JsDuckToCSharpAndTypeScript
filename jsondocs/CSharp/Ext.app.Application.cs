using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.app.Application : Ext.app.Controller {
                    
        private _appFolder_default = 'app';
                    
                    
        [JsonIgnore]
        public String appFolder { get { return this.attributes.GetOrDefault<String>("appFolder", 'app'); } set { this.attributes["appFolder"] = value; } }                
                    
                    
        private _appProperty_default = 'app';
                    
                    
        [JsonIgnore]
        public String appProperty { get { return this.attributes.GetOrDefault<String>("appProperty", 'app'); } set { this.attributes["appProperty"] = value; } }                
                    
                    
        private _autoCreateViewport_default = false;
                    
                    
        [JsonIgnore]
        public Boolean autoCreateViewport { get { return this.attributes.GetOrDefault<Boolean>("autoCreateViewport", false); } set { this.attributes["autoCreateViewport"] = value; } }                
                    
                    
        public class MultiType_controllers {
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
        public MultiType_controllers controllers { get { return this.attributes.GetOrDefault<MultiType_controllers>("controllers", ); } set { this.attributes["controllers"] = value; } }                

                    
                    
        private _enableQuickTips_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableQuickTips { get { return this.attributes.GetOrDefault<Boolean>("enableQuickTips", true); } set { this.attributes["enableQuickTips"] = value; } }                
                    
                    
        [JsonIgnore]
        public String name { get { return this.attributes.GetOrDefault<String>("name", ); } set { this.attributes["name"] = value; } }                
                    
                    
        private _namespaces_default = [];
                    
                    
        public class MultiType_namespaces {
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
        public MultiType_namespaces namespaces { get { return this.attributes.GetOrDefault<MultiType_namespaces>("namespaces", []); } set { this.attributes["namespaces"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object paths { get { return this.attributes.GetOrDefault<Object>("paths", ); } set { this.attributes["paths"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
    }
}
