using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.Store : Ext.data.AbstractStore {
                    
        private _autoDestroy_default = false;
                    
                    
        [JsonIgnore]
        public Boolean autoDestroy { get { return this.attributes.GetOrDefault<Boolean>("autoDestroy", false); } set { this.attributes["autoDestroy"] = value; } }                
                    
                    
        private _buffered_default = false;
                    
                    
        [JsonIgnore]
        public Boolean buffered { get { return this.attributes.GetOrDefault<Boolean>("buffered", false); } set { this.attributes["buffered"] = value; } }                
                    
                    
        private _clearOnPageLoad_default = true;
                    
                    
        [JsonIgnore]
        public Boolean clearOnPageLoad { get { return this.attributes.GetOrDefault<Boolean>("clearOnPageLoad", true); } set { this.attributes["clearOnPageLoad"] = value; } }                
                    
                    
        private _clearRemovedOnLoad_default = true;
                    
                    
        [JsonIgnore]
        public Boolean clearRemovedOnLoad { get { return this.attributes.GetOrDefault<Boolean>("clearRemovedOnLoad", true); } set { this.attributes["clearRemovedOnLoad"] = value; } }                
                    
                    
        public class MultiType_data {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.data.Model[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.Model[] (int m) {
                return new Ext.data.Model[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_data data { get { return this.attributes.GetOrDefault<MultiType_data>("data", ); } set { this.attributes["data"] = value; } }                

                    
                    
        private _groupDir_default = "ASC";
                    
                    
        [JsonIgnore]
        public String groupDir { get { return this.attributes.GetOrDefault<String>("groupDir", "ASC"); } set { this.attributes["groupDir"] = value; } }                
                    
                    
        [JsonIgnore]
        public String groupField { get { return this.attributes.GetOrDefault<String>("groupField", ); } set { this.attributes["groupField"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.util.MixedCollection groupers { get { return this.attributes.GetOrDefault<Ext.util.MixedCollection>("groupers", ); } set { this.attributes["groupers"] = value; } }                
                    
                    
        private _leadingBufferZone_default = 200;
                    
                    
        [JsonIgnore]
        public Number leadingBufferZone { get { return this.attributes.GetOrDefault<Number>("leadingBufferZone", 200); } set { this.attributes["leadingBufferZone"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number pageSize { get { return this.attributes.GetOrDefault<Number>("pageSize", ); } set { this.attributes["pageSize"] = value; } }                
                    
                    
        public class MultiType_proxy {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.data.proxy.Proxy m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.proxy.Proxy (int m) {
                return new Ext.data.proxy.Proxy { _value = m };
            }
                            
                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_proxy proxy { get { return this.attributes.GetOrDefault<MultiType_proxy>("proxy", ); } set { this.attributes["proxy"] = value; } }                

                    
                    
        private _purgePageCount_default = 5;
                    
                    
        [JsonIgnore]
        public Number purgePageCount { get { return this.attributes.GetOrDefault<Number>("purgePageCount", 5); } set { this.attributes["purgePageCount"] = value; } }                
                    
                    
        private _remoteFilter_default = false;
                    
                    
        [JsonIgnore]
        public Boolean remoteFilter { get { return this.attributes.GetOrDefault<Boolean>("remoteFilter", false); } set { this.attributes["remoteFilter"] = value; } }                
                    
                    
        private _remoteGroup_default = false;
                    
                    
        [JsonIgnore]
        public Boolean remoteGroup { get { return this.attributes.GetOrDefault<Boolean>("remoteGroup", false); } set { this.attributes["remoteGroup"] = value; } }                
                    
                    
        private _remoteSort_default = false;
                    
                    
        [JsonIgnore]
        public Boolean remoteSort { get { return this.attributes.GetOrDefault<Boolean>("remoteSort", false); } set { this.attributes["remoteSort"] = value; } }                
                    
                    
        private _sortOnFilter_default = true;
                    
                    
        [JsonIgnore]
        public Boolean sortOnFilter { get { return this.attributes.GetOrDefault<Boolean>("sortOnFilter", true); } set { this.attributes["sortOnFilter"] = value; } }                
                    
                    
        private _trailingBufferZone_default = 25;
                    
                    
        [JsonIgnore]
        public Number trailingBufferZone { get { return this.attributes.GetOrDefault<Number>("trailingBufferZone", 25); } set { this.attributes["trailingBufferZone"] = value; } }                
                    
    }
}
