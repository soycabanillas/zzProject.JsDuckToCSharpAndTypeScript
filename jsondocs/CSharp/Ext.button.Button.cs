using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.button.Button : Ext.Component {
                    
        private _allowDepress_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowDepress { get { return this.attributes.GetOrDefault<Boolean>("allowDepress", true); } set { this.attributes["allowDepress"] = value; } }                
                    
                    
        private _arrowAlign_default = 'right';
                    
                    
        [JsonIgnore]
        public String arrowAlign { get { return this.attributes.GetOrDefault<String>("arrowAlign", 'right'); } set { this.attributes["arrowAlign"] = value; } }                
                    
                    
        private _arrowCls_default = 'arrow';
                    
                    
        [JsonIgnore]
        public String arrowCls { get { return this.attributes.GetOrDefault<String>("arrowCls", 'arrow'); } set { this.attributes["arrowCls"] = value; } }                
                    
                    
        private _baseCls_default = 'x-btn';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", 'x-btn'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object baseParams { get { return this.attributes.GetOrDefault<Object>("baseParams", ); } set { this.attributes["baseParams"] = value; } }                
                    
                    
        private _clickEvent_default = 'click';
                    
                    
        [JsonIgnore]
        public String clickEvent { get { return this.attributes.GetOrDefault<String>("clickEvent", 'click'); } set { this.attributes["clickEvent"] = value; } }                
                    
                    
        [JsonIgnore]
        public String cls { get { return this.attributes.GetOrDefault<String>("cls", ); } set { this.attributes["cls"] = value; } }                
                    
                    
        private _componentLayout_default = 'button';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'button'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean destroyMenu { get { return this.attributes.GetOrDefault<Boolean>("destroyMenu", ); } set { this.attributes["destroyMenu"] = value; } }                
                    
                    
        private _disabled_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disabled { get { return this.attributes.GetOrDefault<Boolean>("disabled", false); } set { this.attributes["disabled"] = value; } }                
                    
                    
        private _enableToggle_default = false;
                    
                    
        [JsonIgnore]
        public Boolean enableToggle { get { return this.attributes.GetOrDefault<Boolean>("enableToggle", false); } set { this.attributes["enableToggle"] = value; } }                
                    
                    
        private _focusCls_default = 'focus';
                    
                    
        [JsonIgnore]
        public String focusCls { get { return this.attributes.GetOrDefault<String>("focusCls", 'focus'); } set { this.attributes["focusCls"] = value; } }                
                    
                    
        private _frame_default = true;
                    
                    
        [JsonIgnore]
        public Boolean frame { get { return this.attributes.GetOrDefault<Boolean>("frame", true); } set { this.attributes["frame"] = value; } }                
                    
                    
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

                    
                    
        private _handleMouseEvents_default = true;
                    
                    
        [JsonIgnore]
        public Boolean handleMouseEvents { get { return this.attributes.GetOrDefault<Boolean>("handleMouseEvents", true); } set { this.attributes["handleMouseEvents"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function handler { get { return this.attributes.GetOrDefault<Function>("handler", ); } set { this.attributes["handler"] = value; } }                
                    
                    
        private _hidden_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hidden { get { return this.attributes.GetOrDefault<Boolean>("hidden", false); } set { this.attributes["hidden"] = value; } }                
                    
                    
        [JsonIgnore]
        public String href { get { return this.attributes.GetOrDefault<String>("href", ); } set { this.attributes["href"] = value; } }                
                    
                    
        private _hrefTarget_default = "_blank";
                    
                    
        [JsonIgnore]
        public String hrefTarget { get { return this.attributes.GetOrDefault<String>("hrefTarget", "_blank"); } set { this.attributes["hrefTarget"] = value; } }                
                    
                    
        [JsonIgnore]
        public String icon { get { return this.attributes.GetOrDefault<String>("icon", ); } set { this.attributes["icon"] = value; } }                
                    
                    
        private _iconAlign_default = 'left';
                    
                    
        [JsonIgnore]
        public String iconAlign { get { return this.attributes.GetOrDefault<String>("iconAlign", 'left'); } set { this.attributes["iconAlign"] = value; } }                
                    
                    
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
        public MultiType_menu menu { get { return this.attributes.GetOrDefault<MultiType_menu>("menu", ); } set { this.attributes["menu"] = value; } }                

                    
                    
        private _menuActiveCls_default = 'menu-active';
                    
                    
        [JsonIgnore]
        public String menuActiveCls { get { return this.attributes.GetOrDefault<String>("menuActiveCls", 'menu-active'); } set { this.attributes["menuActiveCls"] = value; } }                
                    
                    
        private _menuAlign_default = 'tl-bl?';
                    
                    
        [JsonIgnore]
        public String menuAlign { get { return this.attributes.GetOrDefault<String>("menuAlign", 'tl-bl?'); } set { this.attributes["menuAlign"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minWidth { get { return this.attributes.GetOrDefault<Number>("minWidth", ); } set { this.attributes["minWidth"] = value; } }                
                    
                    
        private _overCls_default = 'over';
                    
                    
        [JsonIgnore]
        public String overCls { get { return this.attributes.GetOrDefault<String>("overCls", 'over'); } set { this.attributes["overCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String overflowText { get { return this.attributes.GetOrDefault<String>("overflowText", ); } set { this.attributes["overflowText"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object params { get { return this.attributes.GetOrDefault<Object>("params", ); } set { this.attributes["params"] = value; } }                
                    
                    
        private _pressed_default = false;
                    
                    
        [JsonIgnore]
        public Boolean pressed { get { return this.attributes.GetOrDefault<Boolean>("pressed", false); } set { this.attributes["pressed"] = value; } }                
                    
                    
        private _pressedCls_default = 'pressed';
                    
                    
        [JsonIgnore]
        public String pressedCls { get { return this.attributes.GetOrDefault<String>("pressedCls", 'pressed'); } set { this.attributes["pressedCls"] = value; } }                
                    
                    
        private _preventDefault_default = true;
                    
                    
        [JsonIgnore]
        public Boolean preventDefault { get { return this.attributes.GetOrDefault<Boolean>("preventDefault", true); } set { this.attributes["preventDefault"] = value; } }                
                    
                    
        private _renderTpl_default = ['<span id="{id}-btnWrap" class="{baseCls}-wrap', '<tpl if="splitCls"> {splitCls}</tpl>', '{childElCls}" unselectable="on">', '<span id="{id}-btnEl" class="{baseCls}-button">', '<span id="{id}-btnInnerEl" class="{baseCls}-inner {innerCls}', '{childElCls}" unselectable="on">', '{text}', '</span>', '<span role="img" id="{id}-btnIconEl" class="{baseCls}-icon-el {iconCls}', '{childElCls} {glyphCls}" unselectable="on" style="', '<tpl if="iconUrl">background-image:url({iconUrl});</tpl>', '<tpl if="glyph && glyphFontFamily">font-family:{glyphFontFamily};</tpl>">', '<tpl if="glyph">&#{glyph};</tpl><tpl if="iconCls || iconUrl">&#160;</tpl>', '</span>', '</span>', '</span>', '<tpl if="closable">', '<span id="{id}-closeEl" class="{baseCls}-close-btn" title="{closeText}" tabIndex="0"></span>', '</tpl>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<span id="{id}-btnWrap" class="{baseCls}-wrap', '<tpl if="splitCls"> {splitCls}</tpl>', '{childElCls}" unselectable="on">', '<span id="{id}-btnEl" class="{baseCls}-button">', '<span id="{id}-btnInnerEl" class="{baseCls}-inner {innerCls}', '{childElCls}" unselectable="on">', '{text}', '</span>', '<span role="img" id="{id}-btnIconEl" class="{baseCls}-icon-el {iconCls}', '{childElCls} {glyphCls}" unselectable="on" style="', '<tpl if="iconUrl">background-image:url({iconUrl});</tpl>', '<tpl if="glyph && glyphFontFamily">font-family:{glyphFontFamily};</tpl>">', '<tpl if="glyph">&#{glyph};</tpl><tpl if="iconCls || iconUrl">&#160;</tpl>', '</span>', '</span>', '</span>', '<tpl if="closable">', '<span id="{id}-closeEl" class="{baseCls}-close-btn" title="{closeText}" tabIndex="0"></span>', '</tpl>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        private _repeat_default = false;
                    
                    
        public class MultiType_repeat {
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
        public MultiType_repeat repeat { get { return this.attributes.GetOrDefault<MultiType_repeat>("repeat", false); } set { this.attributes["repeat"] = value; } }                

                    
                    
        private _scale_default = 'small';
                    
                    
        public class MultiType_scale {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int ("small" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "small" (int m) {
                return new "small" { _value = m };
            }
                            
                            
            public static explicit operator int ("medium" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "medium" (int m) {
                return new "medium" { _value = m };
            }
                            
                            
            public static explicit operator int ("large" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "large" (int m) {
                return new "large" { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_scale scale { get { return this.attributes.GetOrDefault<MultiType_scale>("scale", 'small'); } set { this.attributes["scale"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _showEmptyMenu_default = false;
                    
                    
        [JsonIgnore]
        public Boolean showEmptyMenu { get { return this.attributes.GetOrDefault<Boolean>("showEmptyMenu", false); } set { this.attributes["showEmptyMenu"] = value; } }                
                    
                    
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

                    
                    
        private _tabIndex_default = 0;
                    
                    
        [JsonIgnore]
        public Number tabIndex { get { return this.attributes.GetOrDefault<Number>("tabIndex", 0); } set { this.attributes["tabIndex"] = value; } }                
                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", ); } set { this.attributes["text"] = value; } }                
                    
                    
        private _textAlign_default = 'center';
                    
                    
        [JsonIgnore]
        public String textAlign { get { return this.attributes.GetOrDefault<String>("textAlign", 'center'); } set { this.attributes["textAlign"] = value; } }                
                    
                    
        [JsonIgnore]
        public String toggleGroup { get { return this.attributes.GetOrDefault<String>("toggleGroup", ); } set { this.attributes["toggleGroup"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function toggleHandler { get { return this.attributes.GetOrDefault<Function>("toggleHandler", ); } set { this.attributes["toggleHandler"] = value; } }                
                    
                    
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
