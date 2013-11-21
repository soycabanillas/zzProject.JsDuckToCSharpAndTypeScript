//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.menu
{
    using System;
    
    
    public partial class CheckItem : zzProject.ExtJSNet.ExtJS.Classes.Ext.menu.Item
    {
        
        public string _checkChangeDisabled_default = "false";
        
        public string _checked_default = "false";
        
        public string _checkedCls_default = "Ext.baseCSSPrefix + \'menu-item-checked\'";
        
        public string _groupCls_default = "Ext.baseCSSPrefix + \'menu-group-icon\'";
        
        public string _hideOnClick_default = "false";
        
        public string _renderTpl_default = @"['<tpl if=""plain"">', '{text}', '<tpl else>', '{%var showCheckbox = values.showCheckbox,', '      rightCheckbox = showCheckbox && values.hasIcon && (values.iconAlign !== ""left""), textCls = rightCheckbox ? ""' + Ext.baseCSSPrefix + 'right-check-item-text"" : """";%}', '<a id=""{id}-itemEl"" class=""' + Ext.baseCSSPrefix + 'menu-item-link{childElCls}"" href=""{href}"" <tpl if=""hrefTarget"">target=""{hrefTarget}""</tpl> hidefocus=""true"" unselectable=""on""', '<tpl if=""tabIndex"">', ' tabIndex=""{tabIndex}""', '</tpl>', '>', '{%if (values.hasIcon && (values.iconAlign !== ""left"")) {%}', '<div role=""img"" id=""{id}-iconEl"" class=""' + Ext.baseCSSPrefix + 'menu-item-icon {iconCls}', '{childElCls} {glyphCls}"" style=""<tpl if=""icon"">background-image:url({icon});</tpl>', '<tpl if=""glyph && glyphFontFamily"">font-family:{glyphFontFamily};</tpl>"">', '<tpl if=""glyph"">&#{glyph};</tpl>', '</div>', '{%} else if (showCheckbox){%}', '<img id=""{id}-checkEl"" src=""{blank}"" class=""' + Ext.baseCSSPrefix + 'menu-item-icon{childElCls}"" />', '{%}%}', '<span id=""{id}-textEl"" class=""' + Ext.baseCSSPrefix + 'menu-item-text {[textCls]}{childElCls}"" <tpl if=""arrowCls"">style=""margin-right: 17px;""</tpl> >{text}</span>', '{%if (rightCheckbox) {%}', '<img id=""{id}-checkEl"" src=""{blank}"" class=""' + Ext.baseCSSPrefix + 'menu-item-icon-right{childElCls}"" />', '{%} else if (values.arrowCls) {%}', '<img id=""{id}-arrowEl"" src=""{blank}"" class=""{arrowCls}{childElCls}""/>', '{%}%}', '</a>', '</tpl>']";
        
        public string _uncheckedCls_default = "Ext.baseCSSPrefix + \'menu-item-unchecked\'";
        
        public object checkChangeDisabled
        {
            get
            {
                return this.attributes["checkChangeDisabled"];
            }
            set
            {
                this.attributes["checkChangeDisabled"] = value;
            }
        }
        
        public object checkHandler
        {
            get
            {
                return this.attributes["checkHandler"];
            }
            set
            {
                this.attributes["checkHandler"] = value;
            }
        }
        
        public object _checked
        {
            get
            {
                return this.attributes["checked"];
            }
            set
            {
                this.attributes["checked"] = value;
            }
        }
        
        public object checkedCls
        {
            get
            {
                return this.attributes["checkedCls"];
            }
            set
            {
                this.attributes["checkedCls"] = value;
            }
        }
        
        public object group
        {
            get
            {
                return this.attributes["group"];
            }
            set
            {
                this.attributes["group"] = value;
            }
        }
        
        public object groupCls
        {
            get
            {
                return this.attributes["groupCls"];
            }
            set
            {
                this.attributes["groupCls"] = value;
            }
        }
        
        public object hideOnClick
        {
            get
            {
                return this.attributes["hideOnClick"];
            }
            set
            {
                this.attributes["hideOnClick"] = value;
            }
        }
        
        public object renderTpl
        {
            get
            {
                return this.attributes["renderTpl"];
            }
            set
            {
                this.attributes["renderTpl"] = value;
            }
        }
        
        public object scope
        {
            get
            {
                return this.attributes["scope"];
            }
            set
            {
                this.attributes["scope"] = value;
            }
        }
        
        public object uncheckedCls
        {
            get
            {
                return this.attributes["uncheckedCls"];
            }
            set
            {
                this.attributes["uncheckedCls"] = value;
            }
        }
        
        public class MultiType_checkChangeDisabled
        {
            
            public @bool _bool_type;
            
            public @bool AsBoolean
            {
                get
                {
                    return this._bool_type;
                }
                set
                {
                    this._bool_type = value;
                }
            }
        }
        
        public class MultiType_checkHandler
        {
            
            public @string _string_type;
            
            public @string AsFunction
            {
                get
                {
                    return this._string_type;
                }
                set
                {
                    this._string_type = value;
                }
            }
        }
        
        public class MultiType_checked
        {
            
            public @bool _bool_type;
            
            public @bool AsBoolean
            {
                get
                {
                    return this._bool_type;
                }
                set
                {
                    this._bool_type = value;
                }
            }
        }
        
        public class MultiType_checkedCls
        {
            
            public @string _string_type;
            
            public @string AsString
            {
                get
                {
                    return this._string_type;
                }
                set
                {
                    this._string_type = value;
                }
            }
        }
        
        public class MultiType_group
        {
            
            public @string _string_type;
            
            public @string AsString
            {
                get
                {
                    return this._string_type;
                }
                set
                {
                    this._string_type = value;
                }
            }
        }
        
        public class MultiType_groupCls
        {
            
            public @string _string_type;
            
            public @string AsString
            {
                get
                {
                    return this._string_type;
                }
                set
                {
                    this._string_type = value;
                }
            }
        }
        
        public class MultiType_hideOnClick
        {
            
            public @bool _bool_type;
            
            public @bool AsBoolean
            {
                get
                {
                    return this._bool_type;
                }
                set
                {
                    this._bool_type = value;
                }
            }
        }
        
        public class MultiType_renderTpl
        {
            
            public object _System.Object_type;
            
            public @string _string_type;
            
            public List<string> _List<string>_type;
            
            public object AsExt.XTemplate
            {
                get
                {
                    return this._System.Object_type;
                }
                set
                {
                    this._System.Object_type = value;
                }
            }
            
            public @string AsString
            {
                get
                {
                    return this._string_type;
                }
                set
                {
                    this._string_type = value;
                }
            }
            
            public List<string> AsString[]
            {
                get
                {
                    return this._List<string>_type;
                }
                set
                {
                    this._List<string>_type = value;
                }
            }
        }
        
        public class MultiType_scope
        {
            
            public object _System.Object_type;
            
            public object AsObject
            {
                get
                {
                    return this._System.Object_type;
                }
                set
                {
                    this._System.Object_type = value;
                }
            }
        }
        
        public class MultiType_uncheckedCls
        {
            
            public @string _string_type;
            
            public @string AsString
            {
                get
                {
                    return this._string_type;
                }
                set
                {
                    this._string_type = value;
                }
            }
        }
    }
}
