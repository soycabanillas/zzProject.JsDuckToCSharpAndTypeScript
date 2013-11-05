using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.Label : Ext.Component {
                    
        private _autoEl_default = 'label';
                    
                    
        public class MultiType_autoEl {
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
        public MultiType_autoEl autoEl { get { return this.attributes.GetOrDefault<MultiType_autoEl>("autoEl", 'label'); } set { this.attributes["autoEl"] = value; } }                

                    
                    
        [JsonIgnore]
        public String forId { get { return this.attributes.GetOrDefault<String>("forId", ); } set { this.attributes["forId"] = value; } }                
                    
                    
        private _html_default = '';
                    
                    
        [JsonIgnore]
        public String html { get { return this.attributes.GetOrDefault<String>("html", ''); } set { this.attributes["html"] = value; } }                
                    
                    
        private _text_default = '';
                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", ''); } set { this.attributes["text"] = value; } }                
                    
    }
}
