using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.panel.Tool : Ext.Component {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'tool';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'tool'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function callback { get { return this.attributes.GetOrDefault<Function>("callback", ); } set { this.attributes["callback"] = value; } }                
                    
                    
        private _disabledCls_default = Ext.baseCSSPrefix + 'tool-disabled';
                    
                    
        [JsonIgnore]
        public String disabledCls { get { return this.attributes.GetOrDefault<String>("disabledCls", Ext.baseCSSPrefix + 'tool-disabled'); } set { this.attributes["disabledCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function handler { get { return this.attributes.GetOrDefault<Function>("handler", ); } set { this.attributes["handler"] = value; } }                
                    
                    
        private _height_default = 15;
                    
                    
        [JsonIgnore]
        public Number height { get { return this.attributes.GetOrDefault<Number>("height", 15); } set { this.attributes["height"] = value; } }                
                    
                    
        private _renderTpl_default = ['<img role="presentation" id="{id}-toolEl" src="{blank}" class="{baseCls}-img {baseCls}-{type}' + '{childElCls}" role="presentation"/>'];
                    
                    
        public class MultiType_renderTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<img role="presentation" id="{id}-toolEl" src="{blank}" class="{baseCls}-img {baseCls}-{type}' + '{childElCls}" role="presentation"/>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _stopEvent_default = true;
                    
                    
        [JsonIgnore]
        public Boolean stopEvent { get { return this.attributes.GetOrDefault<Boolean>("stopEvent", true); } set { this.attributes["stopEvent"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.Component toolOwner { get { return this.attributes.GetOrDefault<Ext.Component>("toolOwner", ); } set { this.attributes["toolOwner"] = value; } }                
                    
                    
        public class MultiType_tooltip {
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
        public MultiType_tooltip tooltip { get { return this.attributes.GetOrDefault<MultiType_tooltip>("tooltip", ); } set { this.attributes["tooltip"] = value; } }                

                    
                    
        private _tooltipType_default = 'qtip';
                    
                    
        [JsonIgnore]
        public String tooltipType { get { return this.attributes.GetOrDefault<String>("tooltipType", 'qtip'); } set { this.attributes["tooltipType"] = value; } }                
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", ); } set { this.attributes["type"] = value; } }                
                    
                    
        private _width_default = 15;
                    
                    
        [JsonIgnore]
        public Number width { get { return this.attributes.GetOrDefault<Number>("width", 15); } set { this.attributes["width"] = value; } }                
                    
    }
}
