using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.view.BoundList : Ext.view.View {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'boundlist';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'boundlist'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _componentLayout_default = 'boundlist';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'boundlist'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _deferInitialRefresh_default = false;
                    
                    
        [JsonIgnore]
        public Boolean deferInitialRefresh { get { return this.attributes.GetOrDefault<Boolean>("deferInitialRefresh", false); } set { this.attributes["deferInitialRefresh"] = value; } }                
                    
                    
        private _displayField_default = "";
                    
                    
        [JsonIgnore]
        public String displayField { get { return this.attributes.GetOrDefault<String>("displayField", ""); } set { this.attributes["displayField"] = value; } }                
                    
                    
        private _itemCls_default = Ext.baseCSSPrefix + 'boundlist-item';
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", Ext.baseCSSPrefix + 'boundlist-item'); } set { this.attributes["itemCls"] = value; } }                
                    
                    
        private _pageSize_default = 0;
                    
                    
        [JsonIgnore]
        public Number pageSize { get { return this.attributes.GetOrDefault<Number>("pageSize", 0); } set { this.attributes["pageSize"] = value; } }                
                    
                    
        private _renderTpl_default = '{%this.renderContent(out,values)%}';
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", '{%this.renderContent(out,values)%}'); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        private _shadow_default = false;
                    
                    
        public class MultiType_shadow {
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
                            
                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_shadow shadow { get { return this.attributes.GetOrDefault<MultiType_shadow>("shadow", false); } set { this.attributes["shadow"] = value; } }                

                    
                    
        public class MultiType_tpl {
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
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_tpl tpl { get { return this.attributes.GetOrDefault<MultiType_tpl>("tpl", ); } set { this.attributes["tpl"] = value; } }                

                    
                    
        private _trackOver_default = true;
                    
                    
        [JsonIgnore]
        public Boolean trackOver { get { return this.attributes.GetOrDefault<Boolean>("trackOver", true); } set { this.attributes["trackOver"] = value; } }                
                    
    }
}
