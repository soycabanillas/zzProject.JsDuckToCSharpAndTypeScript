using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.panel.Header : Ext.container.Container {
                    
        private _componentLayout_default = 'body';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'body'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _defaultType_default = 'tool';
                    
                    
        [JsonIgnore]
        public String defaultType { get { return this.attributes.GetOrDefault<String>("defaultType", 'tool'); } set { this.attributes["defaultType"] = value; } }                
                    
                    
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

                    
                    
        [JsonIgnore]
        public String icon { get { return this.attributes.GetOrDefault<String>("icon", ); } set { this.attributes["icon"] = value; } }                
                    
                    
        [JsonIgnore]
        public String iconCls { get { return this.attributes.GetOrDefault<String>("iconCls", ); } set { this.attributes["iconCls"] = value; } }                
                    
                    
        private _renderTpl_default = ['<div id="{id}-body" class="{headerCls}-body {baseCls}-body {bodyCls} {bodyTargetCls}', '<tpl for="uiCls"> {parent.baseCls}-body-{parent.ui}-{.}</tpl>"', '<tpl if="bodyStyle"> style="{bodyStyle}"</tpl>>', '{%this.renderContainer(out,values)%}', '</div>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<div id="{id}-body" class="{headerCls}-body {baseCls}-body {bodyCls} {bodyTargetCls}', '<tpl for="uiCls"> {parent.baseCls}-body-{parent.ui}-{.}</tpl>"', '<tpl if="bodyStyle"> style="{bodyStyle}"</tpl>>', '{%this.renderContainer(out,values)%}', '</div>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
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

                    
                    
        [JsonIgnore]
        public String title { get { return this.attributes.GetOrDefault<String>("title", ); } set { this.attributes["title"] = value; } }                
                    
                    
        [JsonIgnore]
        public String titleAlign { get { return this.attributes.GetOrDefault<String>("titleAlign", ); } set { this.attributes["titleAlign"] = value; } }                
                    
                    
        private _titlePosition_default = 0;
                    
                    
        [JsonIgnore]
        public Number titlePosition { get { return this.attributes.GetOrDefault<Number>("titlePosition", 0); } set { this.attributes["titlePosition"] = value; } }                
                    
    }
}
