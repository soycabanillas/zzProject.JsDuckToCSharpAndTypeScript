//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.data
{
    using System;
    
    
    public partial class UuidGenerator : zzProject.ExtJSNet.ExtJS.Classes.Ext.data.IdGenerator
    {
        
        public string _version_default = "4";
        
        public object version
        {
            get
            {
                return this.attributes["version"];
            }
            set
            {
                this.attributes["version"] = value;
            }
        }
        
        public class MultiType_version
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
    }
}
