//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zzProject.ExtJSNet.ExtJS.Classes.Ext.direct
{
    using System;
    
    
    public partial class Provider : zzProject.ExtJSNet.ExtJS.Classes.Ext.Base
    {
        
        public object id
        {
            get
            {
                return this.attributes["id"];
            }
            set
            {
                this.attributes["id"] = value;
            }
        }
        
        public object relayedEvents
        {
            get
            {
                return this.attributes["relayedEvents"];
            }
            set
            {
                this.attributes["relayedEvents"] = value;
            }
        }
        
        public class MultiType_id
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
        
        public class MultiType_relayedEvents
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
    }
}
