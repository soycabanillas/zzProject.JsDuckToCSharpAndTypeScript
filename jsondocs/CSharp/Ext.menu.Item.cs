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
    
    
    public partial class Item : zzProject.ExtJSNet.ExtJS.Classes.Ext.Component
    {
        
        public string _activeCls_default = "Ext.baseCSSPrefix + \'menu-item-active\'";
        
        public string _canActivate_default = "true";
        
        public string _clickHideDelay_default = "0";
        
        public string _destroyMenu_default = "true";
        
        public string _disabledCls_default = "Ext.baseCSSPrefix + \'menu-item-disabled\'";
        
        public string _hideOnClick_default = "true";
        
        public string _href_default = "\'#\'";
        
        public string _menuAlign_default = "\'tl-tr?\'";
        
        public string _menuExpandDelay_default = "200";
        
        public string _menuHideDelay_default = "200";
        
        public string _renderTpl_default = @"['<tpl if=""plain"">', '{text}', '<tpl else>', '<a id=""{id}-itemEl""', ' class=""' + Ext.baseCSSPrefix + 'menu-item-link{childElCls}""', ' href=""{href}""', '<tpl if=""hrefTarget""> target=""{hrefTarget}""</tpl>', ' hidefocus=""true""', ' unselectable=""on""', '<tpl if=""tabIndex"">', ' tabIndex=""{tabIndex}""', '</tpl>', '>', '<div role=""img"" id=""{id}-iconEl"" class=""' + Ext.baseCSSPrefix + 'menu-item-icon {iconCls}', '{childElCls} {glyphCls}"" style=""<tpl if=""icon"">background-image:url({icon});</tpl>', '<tpl if=""glyph && glyphFontFamily"">font-family:{glyphFontFamily};</tpl>"">', '<tpl if=""glyph"">&#{glyph};</tpl>', '</div>', '<span id=""{id}-textEl"" class=""' + Ext.baseCSSPrefix + 'menu-item-text"" unselectable=""on"">{text}</span>', '<img id=""{id}-arrowEl"" src=""{blank}"" class=""{arrowCls}', '{childElCls}""/>', '</a>', '</tpl>']";
        
        public string _tooltipType_default = "\'qtip\'";
        
        public object activeCls
        {
            get
            {
                return this.attributes["activeCls"];
            }
            set
            {
                this.attributes["activeCls"] = value;
            }
        }
        
        public object canActivate
        {
            get
            {
                return this.attributes["canActivate"];
            }
            set
            {
                this.attributes["canActivate"] = value;
            }
        }
        
        public object clickHideDelay
        {
            get
            {
                return this.attributes["clickHideDelay"];
            }
            set
            {
                this.attributes["clickHideDelay"] = value;
            }
        }
        
        public object destroyMenu
        {
            get
            {
                return this.attributes["destroyMenu"];
            }
            set
            {
                this.attributes["destroyMenu"] = value;
            }
        }
        
        public object disabledCls
        {
            get
            {
                return this.attributes["disabledCls"];
            }
            set
            {
                this.attributes["disabledCls"] = value;
            }
        }
        
        public object glyph
        {
            get
            {
                return this.attributes["glyph"];
            }
            set
            {
                this.attributes["glyph"] = value;
            }
        }
        
        public object handler
        {
            get
            {
                return this.attributes["handler"];
            }
            set
            {
                this.attributes["handler"] = value;
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
        
        public object href
        {
            get
            {
                return this.attributes["href"];
            }
            set
            {
                this.attributes["href"] = value;
            }
        }
        
        public object hrefTarget
        {
            get
            {
                return this.attributes["hrefTarget"];
            }
            set
            {
                this.attributes["hrefTarget"] = value;
            }
        }
        
        public object icon
        {
            get
            {
                return this.attributes["icon"];
            }
            set
            {
                this.attributes["icon"] = value;
            }
        }
        
        public object iconCls
        {
            get
            {
                return this.attributes["iconCls"];
            }
            set
            {
                this.attributes["iconCls"] = value;
            }
        }
        
        public object menu
        {
            get
            {
                return this.attributes["menu"];
            }
            set
            {
                this.attributes["menu"] = value;
            }
        }
        
        public object menuAlign
        {
            get
            {
                return this.attributes["menuAlign"];
            }
            set
            {
                this.attributes["menuAlign"] = value;
            }
        }
        
        public object menuExpandDelay
        {
            get
            {
                return this.attributes["menuExpandDelay"];
            }
            set
            {
                this.attributes["menuExpandDelay"] = value;
            }
        }
        
        public object menuHideDelay
        {
            get
            {
                return this.attributes["menuHideDelay"];
            }
            set
            {
                this.attributes["menuHideDelay"] = value;
            }
        }
        
        public object plain
        {
            get
            {
                return this.attributes["plain"];
            }
            set
            {
                this.attributes["plain"] = value;
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
        
        public object text
        {
            get
            {
                return this.attributes["text"];
            }
            set
            {
                this.attributes["text"] = value;
            }
        }
        
        public object tooltip
        {
            get
            {
                return this.attributes["tooltip"];
            }
            set
            {
                this.attributes["tooltip"] = value;
            }
        }
        
        public object tooltipType
        {
            get
            {
                return this.attributes["tooltipType"];
            }
            set
            {
                this.attributes["tooltipType"] = value;
            }
        }
        
        public class MultiType_activeCls
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
        
        public class MultiType_canActivate
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
        
        public class MultiType_clickHideDelay
        {
            
            public @double _double_type;
            
            public @double AsNumber
            {
                get
                {
                    return this._double_type;
                }
                set
                {
                    this._double_type = value;
                }
            }
        }
        
        public class MultiType_destroyMenu
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
        
        public class MultiType_disabledCls
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
        
        public class MultiType_glyph
        {
            
            public @double _double_type;
            
            public @string _string_type;
            
            public @double AsNumber
            {
                get
                {
                    return this._double_type;
                }
                set
                {
                    this._double_type = value;
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
        }
        
        public class MultiType_handler
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
        
        public class MultiType_href
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
        
        public class MultiType_hrefTarget
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
        
        public class MultiType_icon
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
        
        public class MultiType_iconCls
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
        
        public class MultiType_menu
        {
            
            public object _System.Object_type;
            
            public object _System.Object_type;
            
            public object AsExt.menu.Menu
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
        
        public class MultiType_menuAlign
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
        
        public class MultiType_menuExpandDelay
        {
            
            public @double _double_type;
            
            public @double AsNumber
            {
                get
                {
                    return this._double_type;
                }
                set
                {
                    this._double_type = value;
                }
            }
        }
        
        public class MultiType_menuHideDelay
        {
            
            public @double _double_type;
            
            public @double AsNumber
            {
                get
                {
                    return this._double_type;
                }
                set
                {
                    this._double_type = value;
                }
            }
        }
        
        public class MultiType_plain
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
        
        public class MultiType_text
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
        
        public class MultiType_tooltip
        {
            
            public @string _string_type;
            
            public object _System.Object_type;
            
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
        
        public class MultiType_tooltipType
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
