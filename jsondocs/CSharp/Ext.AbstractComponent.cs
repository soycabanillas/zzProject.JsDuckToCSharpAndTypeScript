using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.AbstractComponent : Ext.Base {
                    
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
        public MultiType_autoEl autoEl { get { return this.attributes.GetOrDefault<MultiType_autoEl>("autoEl", ); } set { this.attributes["autoEl"] = value; } }                

                    
                    
        public class MultiType_autoLoad {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.ComponentLoader m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.ComponentLoader (int m) {
                return new Ext.ComponentLoader { _value = m };
            }
                            
                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
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
        public MultiType_autoLoad autoLoad { get { return this.attributes.GetOrDefault<MultiType_autoLoad>("autoLoad", ); } set { this.attributes["autoLoad"] = value; } }                

                    
                    
        private _autoRender_default = false;
                    
                    
        public class MultiType_autoRender {
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
        public MultiType_autoRender autoRender { get { return this.attributes.GetOrDefault<MultiType_autoRender>("autoRender", false); } set { this.attributes["autoRender"] = value; } }                

                    
                    
        private _autoShow_default = false;
                    
                    
        [JsonIgnore]
        public Boolean autoShow { get { return this.attributes.GetOrDefault<Boolean>("autoShow", false); } set { this.attributes["autoShow"] = value; } }                
                    
                    
        private _baseCls_default = 'x-component';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", 'x-component'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        public class MultiType_border {
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
        public MultiType_border border { get { return this.attributes.GetOrDefault<MultiType_border>("border", ); } set { this.attributes["border"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object[] childEls { get { return this.attributes.GetOrDefault<Object[]>("childEls", ); } set { this.attributes["childEls"] = value; } }                
                    
                    
        private _cls_default = '';
                    
                    
        [JsonIgnore]
        public String cls { get { return this.attributes.GetOrDefault<String>("cls", ''); } set { this.attributes["cls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String componentCls { get { return this.attributes.GetOrDefault<String>("componentCls", ); } set { this.attributes["componentCls"] = value; } }                
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", ); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        [JsonIgnore]
        public String contentEl { get { return this.attributes.GetOrDefault<String>("contentEl", ); } set { this.attributes["contentEl"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object data { get { return this.attributes.GetOrDefault<Object>("data", ); } set { this.attributes["data"] = value; } }                
                    
                    
        private _disabled_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disabled { get { return this.attributes.GetOrDefault<Boolean>("disabled", false); } set { this.attributes["disabled"] = value; } }                
                    
                    
        private _disabledCls_default = 'x-item-disabled';
                    
                    
        [JsonIgnore]
        public String disabledCls { get { return this.attributes.GetOrDefault<String>("disabledCls", 'x-item-disabled'); } set { this.attributes["disabledCls"] = value; } }                
                    
                    
        private _draggable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean draggable { get { return this.attributes.GetOrDefault<Boolean>("draggable", false); } set { this.attributes["draggable"] = value; } }                
                    
                    
        private _floating_default = false;
                    
                    
        [JsonIgnore]
        public Boolean floating { get { return this.attributes.GetOrDefault<Boolean>("floating", false); } set { this.attributes["floating"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean frame { get { return this.attributes.GetOrDefault<Boolean>("frame", ); } set { this.attributes["frame"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number height { get { return this.attributes.GetOrDefault<Number>("height", ); } set { this.attributes["height"] = value; } }                
                    
                    
        private _hidden_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hidden { get { return this.attributes.GetOrDefault<Boolean>("hidden", false); } set { this.attributes["hidden"] = value; } }                
                    
                    
        private _hideMode_default = 'display';
                    
                    
        [JsonIgnore]
        public String hideMode { get { return this.attributes.GetOrDefault<String>("hideMode", 'display'); } set { this.attributes["hideMode"] = value; } }                
                    
                    
        private _html_default = '';
                    
                    
        public class MultiType_html {
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
        public MultiType_html html { get { return this.attributes.GetOrDefault<MultiType_html>("html", ''); } set { this.attributes["html"] = value; } }                

                    
                    
        [JsonIgnore]
        public String id { get { return this.attributes.GetOrDefault<String>("id", ); } set { this.attributes["id"] = value; } }                
                    
                    
        [JsonIgnore]
        public String itemId { get { return this.attributes.GetOrDefault<String>("itemId", ); } set { this.attributes["itemId"] = value; } }                
                    
                    
        public class MultiType_loader {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.ComponentLoader m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.ComponentLoader (int m) {
                return new Ext.ComponentLoader { _value = m };
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
        public MultiType_loader loader { get { return this.attributes.GetOrDefault<MultiType_loader>("loader", ); } set { this.attributes["loader"] = value; } }                

                    
                    
        public class MultiType_margin {
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
        public MultiType_margin margin { get { return this.attributes.GetOrDefault<MultiType_margin>("margin", ); } set { this.attributes["margin"] = value; } }                

                    
                    
        [JsonIgnore]
        public Number maxHeight { get { return this.attributes.GetOrDefault<Number>("maxHeight", ); } set { this.attributes["maxHeight"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number maxWidth { get { return this.attributes.GetOrDefault<Number>("maxWidth", ); } set { this.attributes["maxWidth"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minHeight { get { return this.attributes.GetOrDefault<Number>("minHeight", ); } set { this.attributes["minHeight"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minWidth { get { return this.attributes.GetOrDefault<Number>("minWidth", ); } set { this.attributes["minWidth"] = value; } }                
                    
                    
        private _overCls_default = '';
                    
                    
        [JsonIgnore]
        public String overCls { get { return this.attributes.GetOrDefault<String>("overCls", ''); } set { this.attributes["overCls"] = value; } }                
                    
                    
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
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_padding padding { get { return this.attributes.GetOrDefault<MultiType_padding>("padding", ); } set { this.attributes["padding"] = value; } }                

                    
                    
        public class MultiType_plugins {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.AbstractPlugin[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.AbstractPlugin[] (int m) {
                return new Ext.AbstractPlugin[] { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.AbstractPlugin m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.AbstractPlugin (int m) {
                return new Ext.AbstractPlugin { _value = m };
            }
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            
                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.enums.Plugin[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.enums.Plugin[] (int m) {
                return new Ext.enums.Plugin[] { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.enums.Plugin m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.enums.Plugin (int m) {
                return new Ext.enums.Plugin { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_plugins plugins { get { return this.attributes.GetOrDefault<MultiType_plugins>("plugins", ); } set { this.attributes["plugins"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object renderData { get { return this.attributes.GetOrDefault<Object>("renderData", ); } set { this.attributes["renderData"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object renderSelectors { get { return this.attributes.GetOrDefault<Object>("renderSelectors", ); } set { this.attributes["renderSelectors"] = value; } }                
                    
                    
        public class MultiType_renderTo {
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
        public MultiType_renderTo renderTo { get { return this.attributes.GetOrDefault<MultiType_renderTo>("renderTo", ); } set { this.attributes["renderTo"] = value; } }                

                    
                    
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

                    
                    
        [JsonIgnore]
        public Boolean rtl { get { return this.attributes.GetOrDefault<Boolean>("rtl", ); } set { this.attributes["rtl"] = value; } }                
                    
                    
        private _shrinkWrap_default = 2;
                    
                    
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
        public MultiType_shrinkWrap shrinkWrap { get { return this.attributes.GetOrDefault<MultiType_shrinkWrap>("shrinkWrap", 2); } set { this.attributes["shrinkWrap"] = value; } }                

                    
                    
        public class MultiType_style {
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
        public MultiType_style style { get { return this.attributes.GetOrDefault<MultiType_style>("style", ); } set { this.attributes["style"] = value; } }                

                    
                    
        public class MultiType_tpl {
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
                            
                            
            public static explicit operator int (Ext.Template m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Template (int m) {
                return new Ext.Template { _value = m };
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
        public MultiType_tpl tpl { get { return this.attributes.GetOrDefault<MultiType_tpl>("tpl", ); } set { this.attributes["tpl"] = value; } }                

                    
                    
        private _tplWriteMode_default = 'overwrite';
                    
                    
        [JsonIgnore]
        public String tplWriteMode { get { return this.attributes.GetOrDefault<String>("tplWriteMode", 'overwrite'); } set { this.attributes["tplWriteMode"] = value; } }                
                    
                    
        private _ui_default = 'default';
                    
                    
        [JsonIgnore]
        public String ui { get { return this.attributes.GetOrDefault<String>("ui", 'default'); } set { this.attributes["ui"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number width { get { return this.attributes.GetOrDefault<Number>("width", ); } set { this.attributes["width"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.enums.Widget xtype { get { return this.attributes.GetOrDefault<Ext.enums.Widget>("xtype", ); } set { this.attributes["xtype"] = value; } }                
                    
    }
}
