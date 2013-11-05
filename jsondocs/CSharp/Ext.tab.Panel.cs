using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tab.Panel : Ext.panel.Panel {
                    
        public class MultiType_activeItem {
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
        public MultiType_activeItem activeItem { get { return this.attributes.GetOrDefault<MultiType_activeItem>("activeItem", ); } set { this.attributes["activeItem"] = value; } }                

                    
                    
        public class MultiType_activeTab {
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
                            
                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
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
        public MultiType_activeTab activeTab { get { return this.attributes.GetOrDefault<MultiType_activeTab>("activeTab", ); } set { this.attributes["activeTab"] = value; } }                

                    
                    
        private _deferredRender_default = true;
                    
                    
        [JsonIgnore]
        public Boolean deferredRender { get { return this.attributes.GetOrDefault<Boolean>("deferredRender", true); } set { this.attributes["deferredRender"] = value; } }                
                    
                    
        private _itemCls_default = 'x-tabpanel-child';
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", 'x-tabpanel-child'); } set { this.attributes["itemCls"] = value; } }                
                    
                    
        public class MultiType_layout {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.enums.Layout m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.enums.Layout (int m) {
                return new Ext.enums.Layout { _value = m };
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", ); } set { this.attributes["layout"] = value; } }                

                    
                    
        [JsonIgnore]
        public Number maxTabWidth { get { return this.attributes.GetOrDefault<Number>("maxTabWidth", ); } set { this.attributes["maxTabWidth"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minTabWidth { get { return this.attributes.GetOrDefault<Number>("minTabWidth", ); } set { this.attributes["minTabWidth"] = value; } }                
                    
                    
        private _plain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean plain { get { return this.attributes.GetOrDefault<Boolean>("plain", false); } set { this.attributes["plain"] = value; } }                
                    
                    
        private _removePanelHeader_default = true;
                    
                    
        [JsonIgnore]
        public Boolean removePanelHeader { get { return this.attributes.GetOrDefault<Boolean>("removePanelHeader", true); } set { this.attributes["removePanelHeader"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object tabBar { get { return this.attributes.GetOrDefault<Object>("tabBar", ); } set { this.attributes["tabBar"] = value; } }                
                    
                    
        private _tabPosition_default = 'top';
                    
                    
        public class MultiType_tabPosition {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int ("top" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "top" (int m) {
                return new "top" { _value = m };
            }
                            
                            
            public static explicit operator int ("bottom" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "bottom" (int m) {
                return new "bottom" { _value = m };
            }
                            
                            
            public static explicit operator int ("left" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "left" (int m) {
                return new "left" { _value = m };
            }
                            
                            
            public static explicit operator int ("right" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "right" (int m) {
                return new "right" { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_tabPosition tabPosition { get { return this.attributes.GetOrDefault<MultiType_tabPosition>("tabPosition", 'top'); } set { this.attributes["tabPosition"] = value; } }                

                    
    }
}
