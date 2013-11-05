using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.action.Action : Ext.Base {
                    
        [JsonIgnore]
        public Function failure { get { return this.attributes.GetOrDefault<Function>("failure", ); } set { this.attributes["failure"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.form.Basic form { get { return this.attributes.GetOrDefault<Ext.form.Basic>("form", ); } set { this.attributes["form"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object headers { get { return this.attributes.GetOrDefault<Object>("headers", ); } set { this.attributes["headers"] = value; } }                
                    
                    
        [JsonIgnore]
        public String method { get { return this.attributes.GetOrDefault<String>("method", ); } set { this.attributes["method"] = value; } }                
                    
                    
        public class MultiType_params {
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
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_params params { get { return this.attributes.GetOrDefault<MultiType_params>("params", ); } set { this.attributes["params"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean reset { get { return this.attributes.GetOrDefault<Boolean>("reset", ); } set { this.attributes["reset"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _submitEmptyText_default = true;
                    
                    
        [JsonIgnore]
        public Boolean submitEmptyText { get { return this.attributes.GetOrDefault<Boolean>("submitEmptyText", true); } set { this.attributes["submitEmptyText"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function success { get { return this.attributes.GetOrDefault<Function>("success", ); } set { this.attributes["success"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number timeout { get { return this.attributes.GetOrDefault<Number>("timeout", ); } set { this.attributes["timeout"] = value; } }                
                    
                    
        [JsonIgnore]
        public String url { get { return this.attributes.GetOrDefault<String>("url", ); } set { this.attributes["url"] = value; } }                
                    
                    
        [JsonIgnore]
        public String waitMsg { get { return this.attributes.GetOrDefault<String>("waitMsg", ); } set { this.attributes["waitMsg"] = value; } }                
                    
                    
        [JsonIgnore]
        public String waitTitle { get { return this.attributes.GetOrDefault<String>("waitTitle", ); } set { this.attributes["waitTitle"] = value; } }                
                    
    }
}
