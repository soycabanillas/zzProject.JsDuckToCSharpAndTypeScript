//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.grid.column
{
    using System;
    
    
    public partial class Number : zzProject.ExtJSNet.ExtJS.Classes.Ext.grid.column.Column
    {
        
        public string _format_default = "\'0,000.00\'";
        
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
