using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.Field : Ext.Base {
                    
        [JsonIgnore]
        public Function convert { get { return this.attributes.GetOrDefault<Function>("convert", ); } set { this.attributes["convert"] = value; } }                
                    
                    
        [JsonIgnore]
        public String dateFormat { get { return this.attributes.GetOrDefault<String>("dateFormat", ); } set { this.attributes["dateFormat"] = value; } }                
                    
                    
        [JsonIgnore]
        public String dateReadFormat { get { return this.attributes.GetOrDefault<String>("dateReadFormat", ); } set { this.attributes["dateReadFormat"] = value; } }                
                    
                    
        [JsonIgnore]
        public String dateWriteFormat { get { return this.attributes.GetOrDefault<String>("dateWriteFormat", ); } set { this.attributes["dateWriteFormat"] = value; } }                
                    
                    
        private _defaultValue_default = "";
                    
                    
        [JsonIgnore]
        public Object defaultValue { get { return this.attributes.GetOrDefault<Object>("defaultValue", ""); } set { this.attributes["defaultValue"] = value; } }                
                    
                    
        public class MultiType_mapping {
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
                            
                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_mapping mapping { get { return this.attributes.GetOrDefault<MultiType_mapping>("mapping", ); } set { this.attributes["mapping"] = value; } }                

                    
                    
        [JsonIgnore]
        public String name { get { return this.attributes.GetOrDefault<String>("name", ); } set { this.attributes["name"] = value; } }                
                    
                    
        private _persist_default = true;
                    
                    
        [JsonIgnore]
        public Boolean persist { get { return this.attributes.GetOrDefault<Boolean>("persist", true); } set { this.attributes["persist"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function serialize { get { return this.attributes.GetOrDefault<Function>("serialize", ); } set { this.attributes["serialize"] = value; } }                
                    
                    
        private _sortDir_default = "ASC";
                    
                    
        [JsonIgnore]
        public String sortDir { get { return this.attributes.GetOrDefault<String>("sortDir", "ASC"); } set { this.attributes["sortDir"] = value; } }                
                    
                    
        public class MultiType_sortType {
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
        public MultiType_sortType sortType { get { return this.attributes.GetOrDefault<MultiType_sortType>("sortType", ); } set { this.attributes["sortType"] = value; } }                

                    
                    
        public class MultiType_type {
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
        public MultiType_type type { get { return this.attributes.GetOrDefault<MultiType_type>("type", ); } set { this.attributes["type"] = value; } }                

                    
                    
        private _useNull_default = false;
                    
                    
        [JsonIgnore]
        public Boolean useNull { get { return this.attributes.GetOrDefault<Boolean>("useNull", false); } set { this.attributes["useNull"] = value; } }                
                    
    }
}
