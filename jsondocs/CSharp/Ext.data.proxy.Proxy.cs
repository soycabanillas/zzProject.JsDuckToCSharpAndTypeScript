using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.proxy.Proxy : Ext.Base {
                    
        private _batchActions_default = true;
                    
                    
        [JsonIgnore]
        public Boolean batchActions { get { return this.attributes.GetOrDefault<Boolean>("batchActions", true); } set { this.attributes["batchActions"] = value; } }                
                    
                    
        private _batchOrder_default = 'create,update,destroy';
                    
                    
        [JsonIgnore]
        public String batchOrder { get { return this.attributes.GetOrDefault<String>("batchOrder", 'create,update,destroy'); } set { this.attributes["batchOrder"] = value; } }                
                    
                    
        public class MultiType_model {
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
                            
                            
            public static explicit operator int (Ext.data.Model m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.Model (int m) {
                return new Ext.data.Model { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_model model { get { return this.attributes.GetOrDefault<MultiType_model>("model", ); } set { this.attributes["model"] = value; } }                

                    
                    
        public class MultiType_reader {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
            }
                            
                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.data.reader.Reader m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.reader.Reader (int m) {
                return new Ext.data.reader.Reader { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_reader reader { get { return this.attributes.GetOrDefault<MultiType_reader>("reader", ); } set { this.attributes["reader"] = value; } }                

                    
                    
        public class MultiType_writer {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
            }
                            
                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.data.writer.Writer m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.writer.Writer (int m) {
                return new Ext.data.writer.Writer { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_writer writer { get { return this.attributes.GetOrDefault<MultiType_writer>("writer", ); } set { this.attributes["writer"] = value; } }                

                    
    }
}
