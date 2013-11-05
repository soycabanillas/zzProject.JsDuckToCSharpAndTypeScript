using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.draw.Component : Ext.Component {
                    
        private _autoSize_default = false;
                    
                    
        [JsonIgnore]
        public Boolean autoSize { get { return this.attributes.GetOrDefault<Boolean>("autoSize", false); } set { this.attributes["autoSize"] = value; } }                
                    
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'surface';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'surface'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _componentLayout_default = 'draw';
                    
                    
        public class MultiType_componentLayout {
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'draw'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _enginePriority_default = ['Svg', 'Vml'];
                    
                    
        [JsonIgnore]
        public String[] enginePriority { get { return this.attributes.GetOrDefault<String[]>("enginePriority", ['Svg', 'Vml']); } set { this.attributes["enginePriority"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object[] gradients { get { return this.attributes.GetOrDefault<Object[]>("gradients", ); } set { this.attributes["gradients"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.draw.Sprite[] items { get { return this.attributes.GetOrDefault<Ext.draw.Sprite[]>("items", ); } set { this.attributes["items"] = value; } }                
                    
                    
        private _shrinkWrap_default = 3;
                    
                    
        public class MultiType_shrinkWrap {
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
                            
                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_shrinkWrap shrinkWrap { get { return this.attributes.GetOrDefault<MultiType_shrinkWrap>("shrinkWrap", 3); } set { this.attributes["shrinkWrap"] = value; } }                

                    
                    
        private _viewBox_default = true;
                    
                    
        [JsonIgnore]
        public Boolean viewBox { get { return this.attributes.GetOrDefault<Boolean>("viewBox", true); } set { this.attributes["viewBox"] = value; } }                
                    
    }
}
