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
    
    
    public partial class Store : zzProject.ExtJSNet.ExtJS.Classes.Ext.data.AbstractStore
    {
        
        public string _autoDestroy_default = "false";
        
        public string _buffered_default = "false";
        
        public string _clearOnPageLoad_default = "true";
        
        public string _clearRemovedOnLoad_default = "true";
        
        public string _groupDir_default = "\"ASC\"";
        
        public string _leadingBufferZone_default = "200";
        
        public string _purgePageCount_default = "5";
        
        public string _remoteFilter_default = "false";
        
        public string _remoteGroup_default = "false";
        
        public string _remoteSort_default = "false";
        
        public string _sortOnFilter_default = "true";
        
        public string _trailingBufferZone_default = "25";
        
        public object autoDestroy
        {
            get
            {
                return this.attributes["autoDestroy"];
            }
            set
            {
                this.attributes["autoDestroy"] = value;
            }
        }
        
        public object buffered
        {
            get
            {
                return this.attributes["buffered"];
            }
            set
            {
                this.attributes["buffered"] = value;
            }
        }
        
        public object clearOnPageLoad
        {
            get
            {
                return this.attributes["clearOnPageLoad"];
            }
            set
            {
                this.attributes["clearOnPageLoad"] = value;
            }
        }
        
        public object clearRemovedOnLoad
        {
            get
            {
                return this.attributes["clearRemovedOnLoad"];
            }
            set
            {
                this.attributes["clearRemovedOnLoad"] = value;
            }
        }
        
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
        
        public object groupDir
        {
            get
            {
                return this.attributes["groupDir"];
            }
            set
            {
                this.attributes["groupDir"] = value;
            }
        }
        
        public object groupField
        {
            get
            {
                return this.attributes["groupField"];
            }
            set
            {
                this.attributes["groupField"] = value;
            }
        }
        
        public object groupers
        {
            get
            {
                return this.attributes["groupers"];
            }
            set
            {
                this.attributes["groupers"] = value;
            }
        }
        
        public object leadingBufferZone
        {
            get
            {
                return this.attributes["leadingBufferZone"];
            }
            set
            {
                this.attributes["leadingBufferZone"] = value;
            }
        }
        
        public object pageSize
        {
            get
            {
                return this.attributes["pageSize"];
            }
            set
            {
                this.attributes["pageSize"] = value;
            }
        }
        
        public object proxy
        {
            get
            {
                return this.attributes["proxy"];
            }
            set
            {
                this.attributes["proxy"] = value;
            }
        }
        
        public object purgePageCount
        {
            get
            {
                return this.attributes["purgePageCount"];
            }
            set
            {
                this.attributes["purgePageCount"] = value;
            }
        }
        
        public object remoteFilter
        {
            get
            {
                return this.attributes["remoteFilter"];
            }
            set
            {
                this.attributes["remoteFilter"] = value;
            }
        }
        
        public object remoteGroup
        {
            get
            {
                return this.attributes["remoteGroup"];
            }
            set
            {
                this.attributes["remoteGroup"] = value;
            }
        }
        
        public object remoteSort
        {
            get
            {
                return this.attributes["remoteSort"];
            }
            set
            {
                this.attributes["remoteSort"] = value;
            }
        }
        
        public object sortOnFilter
        {
            get
            {
                return this.attributes["sortOnFilter"];
            }
            set
            {
                this.attributes["sortOnFilter"] = value;
            }
        }
        
        public object trailingBufferZone
        {
            get
            {
                return this.attributes["trailingBufferZone"];
            }
            set
            {
                this.attributes["trailingBufferZone"] = value;
            }
        }
        
        public class MultiType_autoDestroy
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
        
        public class MultiType_buffered
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
        
        public class MultiType_clearOnPageLoad
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
        
        public class MultiType_clearRemovedOnLoad
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
        
        public class MultiType_data
        {
            
            public List<System.Object> _List<System.Object>_type;
            
            public System.Collections.Generic.List<object> _System.Collections.Generic.List`1[[System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]_type;
            
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
            
            public System.Collections.Generic.List<object> AsExt.data.Model[]
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
        
        public class MultiType_groupDir
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
        
        public class MultiType_groupField
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
        
        public class MultiType_groupers
        {
            
            public object _System.Object_type;
            
            public object AsExt.util.MixedCollection
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
        
        public class MultiType_leadingBufferZone
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
        
        public class MultiType_pageSize
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
        
        public class MultiType_proxy
        {
            
            public @string _string_type;
            
            public object _System.Object_type;
            
            public object _System.Object_type;
            
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
            
            public object AsExt.data.proxy.Proxy
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
        
        public class MultiType_purgePageCount
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
        
        public class MultiType_remoteFilter
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
        
        public class MultiType_remoteGroup
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
        
        public class MultiType_remoteSort
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
        
        public class MultiType_sortOnFilter
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
        
        public class MultiType_trailingBufferZone
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
