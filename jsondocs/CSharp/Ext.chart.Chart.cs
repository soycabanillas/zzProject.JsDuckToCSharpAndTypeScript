//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.chart
{
    using System;
    
    
    public partial class Chart : zzProject.ExtJSNet.ExtJS.Classes.Ext.draw.Component
    {
        
        public string _animate_default = "false";
        
        public string _background_default = "false";
        
        public string _insetPadding_default = "10";
        
        public string _legend_default = "false";
        
        public object animate
        {
            get
            {
                return this.attributes["animate"];
            }
            set
            {
                this.attributes["animate"] = value;
            }
        }
        
        public object axes
        {
            get
            {
                return this.attributes["axes"];
            }
            set
            {
                this.attributes["axes"] = value;
            }
        }
        
        public object background
        {
            get
            {
                return this.attributes["background"];
            }
            set
            {
                this.attributes["background"] = value;
            }
        }
        
        public object gradients
        {
            get
            {
                return this.attributes["gradients"];
            }
            set
            {
                this.attributes["gradients"] = value;
            }
        }
        
        public object insetPadding
        {
            get
            {
                return this.attributes["insetPadding"];
            }
            set
            {
                this.attributes["insetPadding"] = value;
            }
        }
        
        public object legend
        {
            get
            {
                return this.attributes["legend"];
            }
            set
            {
                this.attributes["legend"] = value;
            }
        }
        
        public object series
        {
            get
            {
                return this.attributes["series"];
            }
            set
            {
                this.attributes["series"] = value;
            }
        }
        
        public object store
        {
            get
            {
                return this.attributes["store"];
            }
            set
            {
                this.attributes["store"] = value;
            }
        }
        
        public object theme
        {
            get
            {
                return this.attributes["theme"];
            }
            set
            {
                this.attributes["theme"] = value;
            }
        }
        
        public class MultiType_animate
        {
            
            public @bool _bool_type;
            
            public object _System.Object_type;
            
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
        
        public class MultiType_axes
        {
            
            public System.Collections.Generic.List<object> _System.Collections.Generic.List`1[[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]_type;
            
            public System.Collections.Generic.List<object> AsExt.chart.axis.Axis[]
            {
                get
                {
                    return this._System.Collections.Generic.List`1[[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]_type;
                }
                set
                {
                    this._System.Collections.Generic.List`1[[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]_type = value;
                }
            }
        }
        
        public class MultiType_background
        {
            
            public object _System.Object_type;
            
            public @bool _bool_type;
            
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
        
        public class MultiType_gradients
        {
            
            public List<System.Object> _List<System.Object>_type;
            
            public List<System.Object> AsObject[]
            {
                get
                {
                    return this._List<System.Object>_type;
                }
                set
                {
                    this._List<System.Object>_type = value;
                }
            }
        }
        
        public class MultiType_insetPadding
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
        
        public class MultiType_legend
        {
            
            public @bool _bool_type;
            
            public object _System.Object_type;
            
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
        
        public class MultiType_series
        {
            
            public System.Collections.Generic.List<object> _System.Collections.Generic.List`1[[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]_type;
            
            public System.Collections.Generic.List<object> AsExt.chart.series.Series[]
            {
                get
                {
                    return this._System.Collections.Generic.List`1[[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]_type;
                }
                set
                {
                    this._System.Collections.Generic.List`1[[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]_type = value;
                }
            }
        }
        
        public class MultiType_store
        {
            
            public object _System.Object_type;
            
            public object AsExt.data.Store
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
        
        public class MultiType_theme
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
