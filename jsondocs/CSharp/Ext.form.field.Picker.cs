//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.form.field
{
    using System;
    
    
    public partial class Picker : zzProject.ExtJSNet.ExtJS.Classes.Ext.form.field.Trigger
    {
        
        public string _editable_default = "true";
        
        public string _matchFieldWidth_default = "true";
        
        public string _openCls_default = "\'x-pickerfield-open\'";
        
        public string _pickerAlign_default = "\'tl-bl?\'";
        
        public object editable
        {
            get
            {
                return this.attributes["editable"];
            }
            set
            {
                this.attributes["editable"] = value;
            }
        }
        
        public object matchFieldWidth
        {
            get
            {
                return this.attributes["matchFieldWidth"];
            }
            set
            {
                this.attributes["matchFieldWidth"] = value;
            }
        }
        
        public object openCls
        {
            get
            {
                return this.attributes["openCls"];
            }
            set
            {
                this.attributes["openCls"] = value;
            }
        }
        
        public object pickerAlign
        {
            get
            {
                return this.attributes["pickerAlign"];
            }
            set
            {
                this.attributes["pickerAlign"] = value;
            }
        }
        
        public object pickerOffset
        {
            get
            {
                return this.attributes["pickerOffset"];
            }
            set
            {
                this.attributes["pickerOffset"] = value;
            }
        }
        
        public class MultiType_editable
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
        
        public class MultiType_matchFieldWidth
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
        
        public class MultiType_openCls
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
        
        public class MultiType_pickerAlign
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
        
        public class MultiType_pickerOffset
        {
            
            public List<double> _List<double>_type;
            
            public List<double> AsNumber[]
            {
                get
                {
                    return this._List<double>_type;
                }
                set
                {
                    this._List<double>_type = value;
                }
            }
        }
    }
}
