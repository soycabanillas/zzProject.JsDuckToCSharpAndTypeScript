using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.AbstractStore : Ext.Base {
                    
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
        public MultiType_autoLoad autoLoad { get { return this.attributes.GetOrDefault<MultiType_autoLoad>("autoLoad", ); } set { this.attributes["autoLoad"] = value; } }                

                    
                    
        private _autoSync_default = false;
                    
                    
        [JsonIgnore]
        public Boolean autoSync { get { return this.attributes.GetOrDefault<Boolean>("autoSync", false); } set { this.attributes["autoSync"] = value; } }                
                    
                    
        private _batchUpdateMode_default = 'operation';
                    
                    
        [JsonIgnore]
        public String batchUpdateMode { get { return this.attributes.GetOrDefault<String>("batchUpdateMode", 'operation'); } set { this.attributes["batchUpdateMode"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object[] fields { get { return this.attributes.GetOrDefault<Object[]>("fields", ); } set { this.attributes["fields"] = value; } }                
                    
                    
        private _filterOnLoad_default = true;
                    
                    
        [JsonIgnore]
        public Boolean filterOnLoad { get { return this.attributes.GetOrDefault<Boolean>("filterOnLoad", true); } set { this.attributes["filterOnLoad"] = value; } }                
                    
                    
        public class MultiType_filters {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            
                            
            public static explicit operator int (Function[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Function[] (int m) {
                return new Function[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_filters filters { get { return this.attributes.GetOrDefault<MultiType_filters>("filters", ); } set { this.attributes["filters"] = value; } }                

                    
                    
        [JsonIgnore]
        public String model { get { return this.attributes.GetOrDefault<String>("model", ); } set { this.attributes["model"] = value; } }                
                    
                    
        public class MultiType_proxy {
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
                            
                            
            public static explicit operator int (Ext.data.proxy.Proxy m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.proxy.Proxy (int m) {
                return new Ext.data.proxy.Proxy { _value = m };
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
        public MultiType_proxy proxy { get { return this.attributes.GetOrDefault<MultiType_proxy>("proxy", ); } set { this.attributes["proxy"] = value; } }                

                    
                    
        private _remoteFilter_default = false;
                    
                    
        [JsonIgnore]
        public Boolean remoteFilter { get { return this.attributes.GetOrDefault<Boolean>("remoteFilter", false); } set { this.attributes["remoteFilter"] = value; } }                
                    
                    
        private _remoteSort_default = false;
                    
                    
        [JsonIgnore]
        public Boolean remoteSort { get { return this.attributes.GetOrDefault<Boolean>("remoteSort", false); } set { this.attributes["remoteSort"] = value; } }                
                    
                    
        private _sortOnLoad_default = true;
                    
                    
        [JsonIgnore]
        public Boolean sortOnLoad { get { return this.attributes.GetOrDefault<Boolean>("sortOnLoad", true); } set { this.attributes["sortOnLoad"] = value; } }                
                    
                    
        private _statefulFilters_default = false;
                    
                    
        [JsonIgnore]
        public Boolean statefulFilters { get { return this.attributes.GetOrDefault<Boolean>("statefulFilters", false); } set { this.attributes["statefulFilters"] = value; } }                
                    
                    
        [JsonIgnore]
        public String storeId { get { return this.attributes.GetOrDefault<String>("storeId", ); } set { this.attributes["storeId"] = value; } }                
                    
    }
}
