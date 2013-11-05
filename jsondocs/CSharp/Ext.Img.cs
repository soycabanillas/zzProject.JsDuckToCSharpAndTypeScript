using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.Img : Ext.Component {
                    
        private _alt_default = '';
                    
                    
        [JsonIgnore]
        public String alt { get { return this.attributes.GetOrDefault<String>("alt", ''); } set { this.attributes["alt"] = value; } }                
                    
                    
        private _autoEl_default = 'img';
                    
                    
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
        public MultiType_autoEl autoEl { get { return this.attributes.GetOrDefault<MultiType_autoEl>("autoEl", 'img'); } set { this.attributes["autoEl"] = value; } }                

                    
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'img';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'img'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        public class MultiType_glyph {
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
        public MultiType_glyph glyph { get { return this.attributes.GetOrDefault<MultiType_glyph>("glyph", ); } set { this.attributes["glyph"] = value; } }                

                    
                    
        private _imgCls_default = '';
                    
                    
        [JsonIgnore]
        public String imgCls { get { return this.attributes.GetOrDefault<String>("imgCls", ''); } set { this.attributes["imgCls"] = value; } }                
                    
                    
        private _src_default = '';
                    
                    
        [JsonIgnore]
        public String src { get { return this.attributes.GetOrDefault<String>("src", ''); } set { this.attributes["src"] = value; } }                
                    
                    
        private _title_default = '';
                    
                    
        [JsonIgnore]
        public String title { get { return this.attributes.GetOrDefault<String>("title", ''); } set { this.attributes["title"] = value; } }                
                    
    }
}
