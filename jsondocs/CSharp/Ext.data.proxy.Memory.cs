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
    
    
    public partial class Memory : zzProject.ExtJSNet.ExtJS.Classes.Ext.data.proxy.Client
    {
        
        public string _enablePaging_default = "false";
        
        public object data
        {
            get
            {
                return this.attributes["data"];
            }
            set
            {
                this.attributes["data"] = value;
            }
        }
        
        public object enablePaging
        {
            get
            {
                return this.attributes["enablePaging"];
            }
            set
            {
                this.attributes["enablePaging"] = value;
            }
        }
        
        public class MultiType_data
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
        
        public class MultiType_enablePaging
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
    }
}
