//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.chart.axis
{
    using System;
    
    
    public partial class Category : zzProject.ExtJSNet.ExtJS.Classes.Ext.chart.axis.Axis
    {
        
        public string _calculateCategoryCount_default = "false";
        
        public object calculateCategoryCount
        {
            get
            {
                return this.attributes["calculateCategoryCount"];
            }
            set
            {
                this.attributes["calculateCategoryCount"] = value;
            }
        }
        
        public object categoryNames
        {
            get
            {
                return this.attributes["categoryNames"];
            }
            set
            {
                this.attributes["categoryNames"] = value;
            }
        }
        
        public class MultiType_calculateCategoryCount
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
        
        public class MultiType_categoryNames
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
