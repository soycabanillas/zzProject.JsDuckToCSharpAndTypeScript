using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.button.Cycle : Ext.button.Split {
                    
        [JsonIgnore]
        public Function changeHandler { get { return this.attributes.GetOrDefault<Function>("changeHandler", ); } set { this.attributes["changeHandler"] = value; } }                
                    
                    
        public class MultiType_forceGlyph {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
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
        public MultiType_forceGlyph forceGlyph { get { return this.attributes.GetOrDefault<MultiType_forceGlyph>("forceGlyph", ); } set { this.attributes["forceGlyph"] = value; } }                

                    
                    
        [JsonIgnore]
        public String forceIcon { get { return this.attributes.GetOrDefault<String>("forceIcon", ); } set { this.attributes["forceIcon"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object[] items { get { return this.attributes.GetOrDefault<Object[]>("items", ); } set { this.attributes["items"] = value; } }                
                    
                    
        private _prependText_default = '';
                    
                    
        [JsonIgnore]
        public String prependText { get { return this.attributes.GetOrDefault<String>("prependText", ''); } set { this.attributes["prependText"] = value; } }                
                    
                    
        private _showText_default = false;
                    
                    
        [JsonIgnore]
        public Boolean showText { get { return this.attributes.GetOrDefault<Boolean>("showText", false); } set { this.attributes["showText"] = value; } }                
                    
    }
}
