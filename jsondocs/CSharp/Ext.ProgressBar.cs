using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.ProgressBar : Ext.Component {
                    
        private _animate_default = false;
                    
                    
        public class MultiType_animate {
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
        public MultiType_animate animate { get { return this.attributes.GetOrDefault<MultiType_animate>("animate", false); } set { this.attributes["animate"] = value; } }                

                    
                    
        private _baseCls_default = 'x-progress';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", 'x-progress'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _componentLayout_default = 'progressbar';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'progressbar'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        [JsonIgnore]
        public String id { get { return this.attributes.GetOrDefault<String>("id", ); } set { this.attributes["id"] = value; } }                
                    
                    
        private _renderTpl_default = ['<tpl if="internalText">', '<div class="{baseCls}-text {baseCls}-text-back">{text}</div>', '</tpl>', '<div id="{id}-bar" class="{baseCls}-bar {baseCls}-bar-{ui}" style="width:{percentage}%">', '<tpl if="internalText">', '<div class="{baseCls}-text">', '<div>{text}</div>', '</div>', '</tpl>', '</div>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<tpl if="internalText">', '<div class="{baseCls}-text {baseCls}-text-back">{text}</div>', '</tpl>', '<div id="{id}-bar" class="{baseCls}-bar {baseCls}-bar-{ui}" style="width:{percentage}%">', '<tpl if="internalText">', '<div class="{baseCls}-text">', '<div>{text}</div>', '</div>', '</tpl>', '</div>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        private _text_default = '';
                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", ''); } set { this.attributes["text"] = value; } }                
                    
                    
        public class MultiType_textEl {
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
                            
                            
            public static explicit operator int (HTMLElement m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator HTMLElement (int m) {
                return new HTMLElement { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.Element m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Element (int m) {
                return new Ext.Element { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_textEl textEl { get { return this.attributes.GetOrDefault<MultiType_textEl>("textEl", ); } set { this.attributes["textEl"] = value; } }                

                    
                    
        private _value_default = 0;
                    
                    
        [JsonIgnore]
        public Number value { get { return this.attributes.GetOrDefault<Number>("value", 0); } set { this.attributes["value"] = value; } }                
                    
    }
}
