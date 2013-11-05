using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.menu.Item : Ext.Component {
                    
        private _activeCls_default = Ext.baseCSSPrefix + 'menu-item-active';
                    
                    
        [JsonIgnore]
        public String activeCls { get { return this.attributes.GetOrDefault<String>("activeCls", Ext.baseCSSPrefix + 'menu-item-active'); } set { this.attributes["activeCls"] = value; } }                
                    
                    
        private _canActivate_default = true;
                    
                    
        [JsonIgnore]
        public Boolean canActivate { get { return this.attributes.GetOrDefault<Boolean>("canActivate", true); } set { this.attributes["canActivate"] = value; } }                
                    
                    
        private _clickHideDelay_default = 0;
                    
                    
        [JsonIgnore]
        public Number clickHideDelay { get { return this.attributes.GetOrDefault<Number>("clickHideDelay", 0); } set { this.attributes["clickHideDelay"] = value; } }                
                    
                    
        private _destroyMenu_default = true;
                    
                    
        [JsonIgnore]
        public Boolean destroyMenu { get { return this.attributes.GetOrDefault<Boolean>("destroyMenu", true); } set { this.attributes["destroyMenu"] = value; } }                
                    
                    
        private _disabledCls_default = Ext.baseCSSPrefix + 'menu-item-disabled';
                    
                    
        [JsonIgnore]
        public String disabledCls { get { return this.attributes.GetOrDefault<String>("disabledCls", Ext.baseCSSPrefix + 'menu-item-disabled'); } set { this.attributes["disabledCls"] = value; } }                
                    
                    
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
        public Function handler { get { return this.attributes.GetOrDefault<Function>("handler", ); } set { this.attributes["handler"] = value; } }                
                    
                    
        private _hideOnClick_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hideOnClick { get { return this.attributes.GetOrDefault<Boolean>("hideOnClick", true); } set { this.attributes["hideOnClick"] = value; } }                
                    
                    
        private _href_default = '#';
                    
                    
        [JsonIgnore]
        public String href { get { return this.attributes.GetOrDefault<String>("href", '#'); } set { this.attributes["href"] = value; } }                
                    
                    
        [JsonIgnore]
        public String hrefTarget { get { return this.attributes.GetOrDefault<String>("hrefTarget", ); } set { this.attributes["hrefTarget"] = value; } }                
                    
                    
        [JsonIgnore]
        public String icon { get { return this.attributes.GetOrDefault<String>("icon", ); } set { this.attributes["icon"] = value; } }                
                    
                    
        [JsonIgnore]
        public String iconCls { get { return this.attributes.GetOrDefault<String>("iconCls", ); } set { this.attributes["iconCls"] = value; } }                
                    
                    
        public class MultiType_menu {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.menu.Menu m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.menu.Menu (int m) {
                return new Ext.menu.Menu { _value = m };
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
        public MultiType_menu menu { get { return this.attributes.GetOrDefault<MultiType_menu>("menu", ); } set { this.attributes["menu"] = value; } }                

                    
                    
        private _menuAlign_default = 'tl-tr?';
                    
                    
        [JsonIgnore]
        public String menuAlign { get { return this.attributes.GetOrDefault<String>("menuAlign", 'tl-tr?'); } set { this.attributes["menuAlign"] = value; } }                
                    
                    
        private _menuExpandDelay_default = 200;
                    
                    
        [JsonIgnore]
        public Number menuExpandDelay { get { return this.attributes.GetOrDefault<Number>("menuExpandDelay", 200); } set { this.attributes["menuExpandDelay"] = value; } }                
                    
                    
        private _menuHideDelay_default = 200;
                    
                    
        [JsonIgnore]
        public Number menuHideDelay { get { return this.attributes.GetOrDefault<Number>("menuHideDelay", 200); } set { this.attributes["menuHideDelay"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean plain { get { return this.attributes.GetOrDefault<Boolean>("plain", ); } set { this.attributes["plain"] = value; } }                
                    
                    
        private _renderTpl_default = ['<tpl if="plain">', '{text}', '<tpl else>', '<a id="{id}-itemEl"', ' class="' + Ext.baseCSSPrefix + 'menu-item-link{childElCls}"', ' href="{href}"', '<tpl if="hrefTarget"> target="{hrefTarget}"</tpl>', ' hidefocus="true"', ' unselectable="on"', '<tpl if="tabIndex">', ' tabIndex="{tabIndex}"', '</tpl>', '>', '<div role="img" id="{id}-iconEl" class="' + Ext.baseCSSPrefix + 'menu-item-icon {iconCls}', '{childElCls} {glyphCls}" style="<tpl if="icon">background-image:url({icon});</tpl>', '<tpl if="glyph && glyphFontFamily">font-family:{glyphFontFamily};</tpl>">', '<tpl if="glyph">&#{glyph};</tpl>', '</div>', '<span id="{id}-textEl" class="' + Ext.baseCSSPrefix + 'menu-item-text" unselectable="on">{text}</span>', '<img id="{id}-arrowEl" src="{blank}" class="{arrowCls}', '{childElCls}"/>', '</a>', '</tpl>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<tpl if="plain">', '{text}', '<tpl else>', '<a id="{id}-itemEl"', ' class="' + Ext.baseCSSPrefix + 'menu-item-link{childElCls}"', ' href="{href}"', '<tpl if="hrefTarget"> target="{hrefTarget}"</tpl>', ' hidefocus="true"', ' unselectable="on"', '<tpl if="tabIndex">', ' tabIndex="{tabIndex}"', '</tpl>', '>', '<div role="img" id="{id}-iconEl" class="' + Ext.baseCSSPrefix + 'menu-item-icon {iconCls}', '{childElCls} {glyphCls}" style="<tpl if="icon">background-image:url({icon});</tpl>', '<tpl if="glyph && glyphFontFamily">font-family:{glyphFontFamily};</tpl>">', '<tpl if="glyph">&#{glyph};</tpl>', '</div>', '<span id="{id}-textEl" class="' + Ext.baseCSSPrefix + 'menu-item-text" unselectable="on">{text}</span>', '<img id="{id}-arrowEl" src="{blank}" class="{arrowCls}', '{childElCls}"/>', '</a>', '</tpl>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", ); } set { this.attributes["text"] = value; } }                
                    
                    
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
                    
    }
}
