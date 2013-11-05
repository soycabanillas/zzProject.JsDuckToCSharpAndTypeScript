using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.Model : Ext.Base {
                    
        [JsonIgnore]
        public Object[] associations { get { return this.attributes.GetOrDefault<Object[]>("associations", ); } set { this.attributes["associations"] = value; } }                
                    
                    
        public class MultiType_belongsTo {
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
                            
                            
            public static explicit operator int (String[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String[] (int m) {
                return new String[] { _value = m };
            }
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_belongsTo belongsTo { get { return this.attributes.GetOrDefault<MultiType_belongsTo>("belongsTo", ); } set { this.attributes["belongsTo"] = value; } }                

                    
                    
        [JsonIgnore]
        public String clientIdProperty { get { return this.attributes.GetOrDefault<String>("clientIdProperty", ); } set { this.attributes["clientIdProperty"] = value; } }                
                    
                    
        private _defaultProxyType_default = 'ajax';
                    
                    
        [JsonIgnore]
        public String defaultProxyType { get { return this.attributes.GetOrDefault<String>("defaultProxyType", 'ajax'); } set { this.attributes["defaultProxyType"] = value; } }                
                    
                    
        public class MultiType_fields {
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
        public MultiType_fields fields { get { return this.attributes.GetOrDefault<MultiType_fields>("fields", ); } set { this.attributes["fields"] = value; } }                

                    
                    
        public class MultiType_hasMany {
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
                            
                            
            public static explicit operator int (String[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String[] (int m) {
                return new String[] { _value = m };
            }
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_hasMany hasMany { get { return this.attributes.GetOrDefault<MultiType_hasMany>("hasMany", ); } set { this.attributes["hasMany"] = value; } }                

                    
                    
        private _idProperty_default = 'id';
                    
                    
        public class MultiType_idProperty {
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
                            
                            
            public static explicit operator int (Ext.data.Field m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.Field (int m) {
                return new Ext.data.Field { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_idProperty idProperty { get { return this.attributes.GetOrDefault<MultiType_idProperty>("idProperty", 'id'); } set { this.attributes["idProperty"] = value; } }                

                    
                    
        public class MultiType_idgen {
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
        public MultiType_idgen idgen { get { return this.attributes.GetOrDefault<MultiType_idgen>("idgen", ); } set { this.attributes["idgen"] = value; } }                

                    
                    
        private _persistenceProperty_default = 'data';
                    
                    
        [JsonIgnore]
        public String persistenceProperty { get { return this.attributes.GetOrDefault<String>("persistenceProperty", 'data'); } set { this.attributes["persistenceProperty"] = value; } }                
                    
                    
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
                            
                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.data.proxy.Proxy m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.proxy.Proxy (int m) {
                return new Ext.data.proxy.Proxy { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_proxy proxy { get { return this.attributes.GetOrDefault<MultiType_proxy>("proxy", ); } set { this.attributes["proxy"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object[] validations { get { return this.attributes.GetOrDefault<Object[]>("validations", ); } set { this.attributes["validations"] = value; } }                
                    
    }
}
