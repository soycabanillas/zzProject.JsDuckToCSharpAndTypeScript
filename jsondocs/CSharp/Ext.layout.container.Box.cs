using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Box : Ext.layout.container.Container {
                    
        private _defaultMargins_default = {top: 0, right: 0, bottom: 0, left: 0};
                    
                    
        [JsonIgnore]
        public Object defaultMargins { get { return this.attributes.GetOrDefault<Object>("defaultMargins", {top: 0, right: 0, bottom: 0, left: 0}); } set { this.attributes["defaultMargins"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number flex { get { return this.attributes.GetOrDefault<Number>("flex", ); } set { this.attributes["flex"] = value; } }                
                    
                    
        private _itemCls_default = Ext.baseCSSPrefix + 'box-item';
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", Ext.baseCSSPrefix + 'box-item'); } set { this.attributes["itemCls"] = value; } }                
                    
                    
        private _pack_default = 'start';
                    
                    
        [JsonIgnore]
        public String pack { get { return this.attributes.GetOrDefault<String>("pack", 'start'); } set { this.attributes["pack"] = value; } }                
                    
                    
        private _padding_default = 0;
                    
                    
        [JsonIgnore]
        public String padding { get { return this.attributes.GetOrDefault<String>("padding", 0); } set { this.attributes["padding"] = value; } }                
                    
                    
        public class MultiType_stretchMaxPartner {
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
                            
                            
            public static explicit operator int (Ext.Component m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Component (int m) {
                return new Ext.Component { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_stretchMaxPartner stretchMaxPartner { get { return this.attributes.GetOrDefault<MultiType_stretchMaxPartner>("stretchMaxPartner", ); } set { this.attributes["stretchMaxPartner"] = value; } }                

                    
    }
}
