//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.selection
{
    using System;
    
    
    public partial class RowModel : zzProject.ExtJSNet.ExtJS.Classes.Ext.selection.Model
    {
        
        public string _enableKeyNav_default = "true";
        
        public string _ignoreRightMouseSelection_default = "false";
        
        public object enableKeyNav
        {
            get
            {
                return this.attributes["enableKeyNav"];
            }
            set
            {
                this.attributes["enableKeyNav"] = value;
            }
        }
        
        public object ignoreRightMouseSelection
        {
            get
            {
                return this.attributes["ignoreRightMouseSelection"];
            }
            set
            {
                this.attributes["ignoreRightMouseSelection"] = value;
            }
        }
        
        public class MultiType_enableKeyNav
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
        
        public class MultiType_ignoreRightMouseSelection
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
