//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.state
{
    using System;
    
    
    public partial class Stateful : zzProject.ExtJSNet.ExtJS.Classes.Ext.Base
    {
        
        public string _saveDelay_default = "100";
        
        public string _stateful_default = "false";
        
        public object saveDelay
        {
            get
            {
                return this.attributes["saveDelay"];
            }
            set
            {
                this.attributes["saveDelay"] = value;
            }
        }
        
        public object stateEvents
        {
            get
            {
                return this.attributes["stateEvents"];
            }
            set
            {
                this.attributes["stateEvents"] = value;
            }
        }
        
        public object stateId
        {
            get
            {
                return this.attributes["stateId"];
            }
            set
            {
                this.attributes["stateId"] = value;
            }
        }
        
        public object stateful
        {
            get
            {
                return this.attributes["stateful"];
            }
            set
            {
                this.attributes["stateful"] = value;
            }
        }
        
        public class MultiType_saveDelay
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
        
        public class MultiType_stateEvents
        {
            
            public List<string> _List<string>_type;
            
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
        
        public class MultiType_stateId
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
        
        public class MultiType_stateful
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
