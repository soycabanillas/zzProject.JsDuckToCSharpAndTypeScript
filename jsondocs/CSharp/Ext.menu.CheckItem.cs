using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.menu.CheckItem : Ext.menu.Item {
                    
        private _checkChangeDisabled_default = false;
                    
                    
        [JsonIgnore]
        public Boolean checkChangeDisabled { get { return this.attributes.GetOrDefault<Boolean>("checkChangeDisabled", false); } set { this.attributes["checkChangeDisabled"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function checkHandler { get { return this.attributes.GetOrDefault<Function>("checkHandler", ); } set { this.attributes["checkHandler"] = value; } }                
                    
                    
        private _checked_default = false;
                    
                    
        [JsonIgnore]
        public Boolean checked { get { return this.attributes.GetOrDefault<Boolean>("checked", false); } set { this.attributes["checked"] = value; } }                
                    
                    
        private _checkedCls_default = Ext.baseCSSPrefix + 'menu-item-checked';
                    
                    
        [JsonIgnore]
        public String checkedCls { get { return this.attributes.GetOrDefault<String>("checkedCls", Ext.baseCSSPrefix + 'menu-item-checked'); } set { this.attributes["checkedCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String group { get { return this.attributes.GetOrDefault<String>("group", ); } set { this.attributes["group"] = value; } }                
                    
                    
        private _groupCls_default = Ext.baseCSSPrefix + 'menu-group-icon';
                    
                    
        [JsonIgnore]
        public String groupCls { get { return this.attributes.GetOrDefault<String>("groupCls", Ext.baseCSSPrefix + 'menu-group-icon'); } set { this.attributes["groupCls"] = value; } }                
                    
                    
        private _hideOnClick_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideOnClick { get { return this.attributes.GetOrDefault<Boolean>("hideOnClick", false); } set { this.attributes["hideOnClick"] = value; } }                
                    
                    
        private _renderTpl_default = ['<tpl if="plain">', '{text}', '<tpl else>', '{%var showCheckbox = values.showCheckbox,', '      rightCheckbox = showCheckbox && values.hasIcon && (values.iconAlign !== "left"), textCls = rightCheckbox ? "' + Ext.baseCSSPrefix + 'right-check-item-text" : "";%}', '<a id="{id}-itemEl" class="' + Ext.baseCSSPrefix + 'menu-item-link{childElCls}" href="{href}" <tpl if="hrefTarget">target="{hrefTarget}"</tpl> hidefocus="true" unselectable="on"', '<tpl if="tabIndex">', ' tabIndex="{tabIndex}"', '</tpl>', '>', '{%if (values.hasIcon && (values.iconAlign !== "left")) {%}', '<div role="img" id="{id}-iconEl" class="' + Ext.baseCSSPrefix + 'menu-item-icon {iconCls}', '{childElCls} {glyphCls}" style="<tpl if="icon">background-image:url({icon});</tpl>', '<tpl if="glyph && glyphFontFamily">font-family:{glyphFontFamily};</tpl>">', '<tpl if="glyph">&#{glyph};</tpl>', '</div>', '{%} else if (showCheckbox){%}', '<img id="{id}-checkEl" src="{blank}" class="' + Ext.baseCSSPrefix + 'menu-item-icon{childElCls}" />', '{%}%}', '<span id="{id}-textEl" class="' + Ext.baseCSSPrefix + 'menu-item-text {[textCls]}{childElCls}" <tpl if="arrowCls">style="margin-right: 17px;"</tpl> >{text}</span>', '{%if (rightCheckbox) {%}', '<img id="{id}-checkEl" src="{blank}" class="' + Ext.baseCSSPrefix + 'menu-item-icon-right{childElCls}" />', '{%} else if (values.arrowCls) {%}', '<img id="{id}-arrowEl" src="{blank}" class="{arrowCls}{childElCls}"/>', '{%}%}', '</a>', '</tpl>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<tpl if="plain">', '{text}', '<tpl else>', '{%var showCheckbox = values.showCheckbox,', '      rightCheckbox = showCheckbox && values.hasIcon && (values.iconAlign !== "left"), textCls = rightCheckbox ? "' + Ext.baseCSSPrefix + 'right-check-item-text" : "";%}', '<a id="{id}-itemEl" class="' + Ext.baseCSSPrefix + 'menu-item-link{childElCls}" href="{href}" <tpl if="hrefTarget">target="{hrefTarget}"</tpl> hidefocus="true" unselectable="on"', '<tpl if="tabIndex">', ' tabIndex="{tabIndex}"', '</tpl>', '>', '{%if (values.hasIcon && (values.iconAlign !== "left")) {%}', '<div role="img" id="{id}-iconEl" class="' + Ext.baseCSSPrefix + 'menu-item-icon {iconCls}', '{childElCls} {glyphCls}" style="<tpl if="icon">background-image:url({icon});</tpl>', '<tpl if="glyph && glyphFontFamily">font-family:{glyphFontFamily};</tpl>">', '<tpl if="glyph">&#{glyph};</tpl>', '</div>', '{%} else if (showCheckbox){%}', '<img id="{id}-checkEl" src="{blank}" class="' + Ext.baseCSSPrefix + 'menu-item-icon{childElCls}" />', '{%}%}', '<span id="{id}-textEl" class="' + Ext.baseCSSPrefix + 'menu-item-text {[textCls]}{childElCls}" <tpl if="arrowCls">style="margin-right: 17px;"</tpl> >{text}</span>', '{%if (rightCheckbox) {%}', '<img id="{id}-checkEl" src="{blank}" class="' + Ext.baseCSSPrefix + 'menu-item-icon-right{childElCls}" />', '{%} else if (values.arrowCls) {%}', '<img id="{id}-arrowEl" src="{blank}" class="{arrowCls}{childElCls}"/>', '{%}%}', '</a>', '</tpl>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _uncheckedCls_default = Ext.baseCSSPrefix + 'menu-item-unchecked';
                    
                    
        [JsonIgnore]
        public String uncheckedCls { get { return this.attributes.GetOrDefault<String>("uncheckedCls", Ext.baseCSSPrefix + 'menu-item-unchecked'); } set { this.attributes["uncheckedCls"] = value; } }                
                    
    }
}
