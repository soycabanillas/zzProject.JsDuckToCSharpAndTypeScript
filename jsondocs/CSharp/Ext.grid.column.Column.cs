using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.column.Column : Ext.grid.header.Container {
                    
        private _align_default = 'left';
                    
                    
        [JsonIgnore]
        public String align { get { return this.attributes.GetOrDefault<String>("align", 'left'); } set { this.attributes["align"] = value; } }                
                    
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'column-header';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'column-header'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object[] columns { get { return this.attributes.GetOrDefault<Object[]>("columns", ); } set { this.attributes["columns"] = value; } }                
                    
                    
        private _componentLayout_default = 'columncomponent';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'columncomponent'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        [JsonIgnore]
        public String dataIndex { get { return this.attributes.GetOrDefault<String>("dataIndex", ); } set { this.attributes["dataIndex"] = value; } }                
                    
                    
        private _detachOnRemove_default = true;
                    
                    
        [JsonIgnore]
        public Boolean detachOnRemove { get { return this.attributes.GetOrDefault<Boolean>("detachOnRemove", true); } set { this.attributes["detachOnRemove"] = value; } }                
                    
                    
        private _draggable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean draggable { get { return this.attributes.GetOrDefault<Boolean>("draggable", true); } set { this.attributes["draggable"] = value; } }                
                    
                    
        private _editRenderer_default = false;
                    
                    
        [JsonIgnore]
        public Function editRenderer { get { return this.attributes.GetOrDefault<Function>("editRenderer", false); } set { this.attributes["editRenderer"] = value; } }                
                    
                    
        public class MultiType_editor {
            public new Type GetType()
            {
                return _value.GetType();
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
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_editor editor { get { return this.attributes.GetOrDefault<MultiType_editor>("editor", ); } set { this.attributes["editor"] = value; } }                

                    
                    
        private _emptyCellText_default = undefined;
                    
                    
        [JsonIgnore]
        public String emptyCellText { get { return this.attributes.GetOrDefault<String>("emptyCellText", undefined); } set { this.attributes["emptyCellText"] = value; } }                
                    
                    
        public class MultiType_field {
            public new Type GetType()
            {
                return _value.GetType();
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
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_field field { get { return this.attributes.GetOrDefault<MultiType_field>("field", ); } set { this.attributes["field"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean fixed { get { return this.attributes.GetOrDefault<Boolean>("fixed", ); } set { this.attributes["fixed"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean groupable { get { return this.attributes.GetOrDefault<Boolean>("groupable", ); } set { this.attributes["groupable"] = value; } }                
                    
                    
        [JsonIgnore]
        public String header { get { return this.attributes.GetOrDefault<String>("header", ); } set { this.attributes["header"] = value; } }                
                    
                    
        private _hideable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hideable { get { return this.attributes.GetOrDefault<Boolean>("hideable", true); } set { this.attributes["hideable"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean lockable { get { return this.attributes.GetOrDefault<Boolean>("lockable", ); } set { this.attributes["lockable"] = value; } }                
                    
                    
        private _locked_default = false;
                    
                    
        [JsonIgnore]
        public Boolean locked { get { return this.attributes.GetOrDefault<Boolean>("locked", false); } set { this.attributes["locked"] = value; } }                
                    
                    
        private _menuDisabled_default = false;
                    
                    
        [JsonIgnore]
        public Boolean menuDisabled { get { return this.attributes.GetOrDefault<Boolean>("menuDisabled", false); } set { this.attributes["menuDisabled"] = value; } }                
                    
                    
        [JsonIgnore]
        public String menuText { get { return this.attributes.GetOrDefault<String>("menuText", ); } set { this.attributes["menuText"] = value; } }                
                    
                    
        private _renderTpl_default = '<div id="{id}-titleEl" {tipMarkup}class="' + Ext.baseCSSPrefix + 'column-header-inner">' + '<span id="{id}-textEl" class="' + Ext.baseCSSPrefix + 'column-header-text' + '{childElCls}">' + '{text}' + '</span>' + '<tpl if="!menuDisabled">' + '<div id="{id}-triggerEl" class="' + Ext.baseCSSPrefix + 'column-header-trigger' + '{childElCls}"></div>' + '</tpl>' + '</div>' + '{%this.renderContainer(out,values)%}';
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", '<div id="{id}-titleEl" {tipMarkup}class="' + Ext.baseCSSPrefix + 'column-header-inner">' + '<span id="{id}-textEl" class="' + Ext.baseCSSPrefix + 'column-header-text' + '{childElCls}">' + '{text}' + '</span>' + '<tpl if="!menuDisabled">' + '<div id="{id}-triggerEl" class="' + Ext.baseCSSPrefix + 'column-header-trigger' + '{childElCls}"></div>' + '</tpl>' + '</div>' + '{%this.renderContainer(out,values)%}'); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        private _renderer_default = false;
                    
                    
        public class MultiType_renderer {
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
        public MultiType_renderer renderer { get { return this.attributes.GetOrDefault<MultiType_renderer>("renderer", false); } set { this.attributes["renderer"] = value; } }                

                    
                    
        private _resizable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean resizable { get { return this.attributes.GetOrDefault<Boolean>("resizable", true); } set { this.attributes["resizable"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _sortable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean sortable { get { return this.attributes.GetOrDefault<Boolean>("sortable", true); } set { this.attributes["sortable"] = value; } }                
                    
                    
        [JsonIgnore]
        public String stateId { get { return this.attributes.GetOrDefault<String>("stateId", ); } set { this.attributes["stateId"] = value; } }                
                    
                    
        private _tdCls_default = '';
                    
                    
        [JsonIgnore]
        public String tdCls { get { return this.attributes.GetOrDefault<String>("tdCls", ''); } set { this.attributes["tdCls"] = value; } }                
                    
                    
        private _text_default = '&#160;';
                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", '&#160;'); } set { this.attributes["text"] = value; } }                
                    
                    
        [JsonIgnore]
        public String tooltip { get { return this.attributes.GetOrDefault<String>("tooltip", ); } set { this.attributes["tooltip"] = value; } }                
                    
                    
        private _tooltipType_default = "qtip";
                    
                    
        [JsonIgnore]
        public String tooltipType { get { return this.attributes.GetOrDefault<String>("tooltipType", "qtip"); } set { this.attributes["tooltipType"] = value; } }                
                    
    }
}
