//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.toolbar
{
    using System;
    
    
    public partial class TextItem : zzProject.ExtJSNet.ExtJS.Classes.Ext.toolbar.Item
    {
        
        public string _baseCls_default = "Ext.baseCSSPrefix + \'toolbar-text\'";
        
        public string _renderTpl_default = "\'{text}\'";
        
        public string _text_default = "\'\'";
        
        public object baseCls
        {
            get
            {
                return this.attributes["baseCls"];
            }
            set
            {
                this.attributes["baseCls"] = value;
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
        
        public class MultiType_baseCls
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
    }
}
