//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.util
{
    using System;
    
    
    public partial class Floating : zzProject.ExtJSNet.ExtJS.Classes.Ext.Base
    {
        
        public string _constrain_default = "false";
        
        public string _fixed_default = "false";
        
        public string _focusOnToFront_default = "true";
        
        public string _shadow_default = "\'sides\'";
        
        public object constrain
        {
            get
            {
                return this.attributes["constrain"];
            }
            set
            {
                this.attributes["constrain"] = value;
            }
        }
        
        public object _fixed
        {
            get
            {
                return this.attributes["fixed"];
            }
            set
            {
                this.attributes["fixed"] = value;
            }
        }
        
        public object focusOnToFront
        {
            get
            {
                return this.attributes["focusOnToFront"];
            }
            set
            {
                this.attributes["focusOnToFront"] = value;
            }
        }
        
        public object shadow
        {
            get
            {
                return this.attributes["shadow"];
            }
            set
            {
                this.attributes["shadow"] = value;
            }
        }
        
        public object shadowOffset
        {
            get
            {
                return this.attributes["shadowOffset"];
            }
            set
            {
                this.attributes["shadowOffset"] = value;
            }
        }
        
        public class MultiType_constrain
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
        
        public class MultiType_fixed
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
        
        public class MultiType_focusOnToFront
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
        
        public class MultiType_shadow
        {
            
            public @string _string_type;
            
            public @bool _bool_type;
            
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
        
        public class MultiType_shadowOffset
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
