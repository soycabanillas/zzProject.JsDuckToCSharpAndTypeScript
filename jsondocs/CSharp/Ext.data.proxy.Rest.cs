//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.data.proxy
{
    using System;
    
    
    public partial class Rest : zzProject.ExtJSNet.ExtJS.Classes.Ext.data.proxy.Ajax
    {
        
        public string _appendId_default = "true";
        
        public string _batchActions_default = "false";
        
        public object appendId
        {
            get
            {
                return this.attributes["appendId"];
            }
            set
            {
                this.attributes["appendId"] = value;
            }
        }
        
        public object batchActions
        {
            get
            {
                return this.attributes["batchActions"];
            }
            set
            {
                this.attributes["batchActions"] = value;
            }
        }
        
        public object format
        {
            get
            {
                return this.attributes["format"];
            }
            set
            {
                this.attributes["format"] = value;
            }
        }
        
        public class MultiType_appendId
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
        
        public class MultiType_batchActions
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
        
        public class MultiType_format
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
