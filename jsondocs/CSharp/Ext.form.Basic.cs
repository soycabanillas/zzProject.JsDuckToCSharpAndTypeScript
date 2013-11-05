using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.Basic : Ext.util.Observable {
                    
        [JsonIgnore]
        public Object api { get { return this.attributes.GetOrDefault<Object>("api", ); } set { this.attributes["api"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object baseParams { get { return this.attributes.GetOrDefault<Object>("baseParams", ); } set { this.attributes["baseParams"] = value; } }                
                    
                    
        public class MultiType_errorReader {
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
        public MultiType_errorReader errorReader { get { return this.attributes.GetOrDefault<MultiType_errorReader>("errorReader", ); } set { this.attributes["errorReader"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean jsonSubmit { get { return this.attributes.GetOrDefault<Boolean>("jsonSubmit", ); } set { this.attributes["jsonSubmit"] = value; } }                
                    
                    
        [JsonIgnore]
        public String method { get { return this.attributes.GetOrDefault<String>("method", ); } set { this.attributes["method"] = value; } }                
                    
                    
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

                    
                    
        private _paramsAsHash_default = false;
                    
                    
        [JsonIgnore]
        public Boolean paramsAsHash { get { return this.attributes.GetOrDefault<Boolean>("paramsAsHash", false); } set { this.attributes["paramsAsHash"] = value; } }                
                    
                    
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

                    
                    
        [JsonIgnore]
        public Boolean standardSubmit { get { return this.attributes.GetOrDefault<Boolean>("standardSubmit", ); } set { this.attributes["standardSubmit"] = value; } }                
                    
                    
        private _timeout_default = 30;
                    
                    
        [JsonIgnore]
        public Number timeout { get { return this.attributes.GetOrDefault<Number>("timeout", 30); } set { this.attributes["timeout"] = value; } }                
                    
                    
        private _trackResetOnLoad_default = false;
                    
                    
        [JsonIgnore]
        public Boolean trackResetOnLoad { get { return this.attributes.GetOrDefault<Boolean>("trackResetOnLoad", false); } set { this.attributes["trackResetOnLoad"] = value; } }                
                    
                    
        [JsonIgnore]
        public String url { get { return this.attributes.GetOrDefault<String>("url", ); } set { this.attributes["url"] = value; } }                
                    
                    
        public class MultiType_waitMsgTarget {
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
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_waitMsgTarget waitMsgTarget { get { return this.attributes.GetOrDefault<MultiType_waitMsgTarget>("waitMsgTarget", ); } set { this.attributes["waitMsgTarget"] = value; } }                

                    
                    
        private _waitTitle_default = 'Please Wait...';
                    
                    
        [JsonIgnore]
        public String waitTitle { get { return this.attributes.GetOrDefault<String>("waitTitle", 'Please Wait...'); } set { this.attributes["waitTitle"] = value; } }                
                    
    }
}
