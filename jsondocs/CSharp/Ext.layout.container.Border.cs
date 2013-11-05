using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Border : Ext.layout.container.Container {
                    
        private _itemCls_default = [Ext.baseCSSPrefix + 'border-item', Ext.baseCSSPrefix + 'box-item'];
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", [Ext.baseCSSPrefix + 'border-item', Ext.baseCSSPrefix + 'box-item']); } set { this.attributes["itemCls"] = value; } }                
                    
                    
        public class MultiType_padding {
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
        public MultiType_padding padding { get { return this.attributes.GetOrDefault<MultiType_padding>("padding", ); } set { this.attributes["padding"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object regionWeights { get { return this.attributes.GetOrDefault<Object>("regionWeights", ); } set { this.attributes["regionWeights"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean split { get { return this.attributes.GetOrDefault<Boolean>("split", ); } set { this.attributes["split"] = value; } }                
                    
                    
        private _splitterResize_default = true;
                    
                    
        [JsonIgnore]
        public Boolean splitterResize { get { return this.attributes.GetOrDefault<Boolean>("splitterResize", true); } set { this.attributes["splitterResize"] = value; } }                
                    
    }
}
