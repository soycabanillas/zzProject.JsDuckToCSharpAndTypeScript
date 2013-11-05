using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.proxy.Server : Ext.data.proxy.Proxy {
                    
        [JsonIgnore]
        public Object api { get { return this.attributes.GetOrDefault<Object>("api", ); } set { this.attributes["api"] = value; } }                
                    
                    
        private _cacheString_default = "_dc";
                    
                    
        [JsonIgnore]
        public String cacheString { get { return this.attributes.GetOrDefault<String>("cacheString", "_dc"); } set { this.attributes["cacheString"] = value; } }                
                    
                    
        private _directionParam_default = "dir";
                    
                    
        [JsonIgnore]
        public String directionParam { get { return this.attributes.GetOrDefault<String>("directionParam", "dir"); } set { this.attributes["directionParam"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object extraParams { get { return this.attributes.GetOrDefault<Object>("extraParams", ); } set { this.attributes["extraParams"] = value; } }                
                    
                    
        private _filterParam_default = "filter";
                    
                    
        [JsonIgnore]
        public String filterParam { get { return this.attributes.GetOrDefault<String>("filterParam", "filter"); } set { this.attributes["filterParam"] = value; } }                
                    
                    
        private _groupDirectionParam_default = "groupDir";
                    
                    
        [JsonIgnore]
        public String groupDirectionParam { get { return this.attributes.GetOrDefault<String>("groupDirectionParam", "groupDir"); } set { this.attributes["groupDirectionParam"] = value; } }                
                    
                    
        private _groupParam_default = "group";
                    
                    
        [JsonIgnore]
        public String groupParam { get { return this.attributes.GetOrDefault<String>("groupParam", "group"); } set { this.attributes["groupParam"] = value; } }                
                    
                    
        private _idParam_default = "id";
                    
                    
        [JsonIgnore]
        public String idParam { get { return this.attributes.GetOrDefault<String>("idParam", "id"); } set { this.attributes["idParam"] = value; } }                
                    
                    
        private _limitParam_default = "limit";
                    
                    
        [JsonIgnore]
        public String limitParam { get { return this.attributes.GetOrDefault<String>("limitParam", "limit"); } set { this.attributes["limitParam"] = value; } }                
                    
                    
        private _noCache_default = true;
                    
                    
        [JsonIgnore]
        public Boolean noCache { get { return this.attributes.GetOrDefault<Boolean>("noCache", true); } set { this.attributes["noCache"] = value; } }                
                    
                    
        private _pageParam_default = "page";
                    
                    
        [JsonIgnore]
        public String pageParam { get { return this.attributes.GetOrDefault<String>("pageParam", "page"); } set { this.attributes["pageParam"] = value; } }                
                    
                    
        private _simpleGroupMode_default = false;
                    
                    
        [JsonIgnore]
        public Boolean simpleGroupMode { get { return this.attributes.GetOrDefault<Boolean>("simpleGroupMode", false); } set { this.attributes["simpleGroupMode"] = value; } }                
                    
                    
        private _simpleSortMode_default = false;
                    
                    
        [JsonIgnore]
        public Boolean simpleSortMode { get { return this.attributes.GetOrDefault<Boolean>("simpleSortMode", false); } set { this.attributes["simpleSortMode"] = value; } }                
                    
                    
        private _sortParam_default = "sort";
                    
                    
        [JsonIgnore]
        public String sortParam { get { return this.attributes.GetOrDefault<String>("sortParam", "sort"); } set { this.attributes["sortParam"] = value; } }                
                    
                    
        private _startParam_default = "start";
                    
                    
        [JsonIgnore]
        public String startParam { get { return this.attributes.GetOrDefault<String>("startParam", "start"); } set { this.attributes["startParam"] = value; } }                
                    
                    
        private _timeout_default = 30000;
                    
                    
        [JsonIgnore]
        public Number timeout { get { return this.attributes.GetOrDefault<Number>("timeout", 30000); } set { this.attributes["timeout"] = value; } }                
                    
                    
        [JsonIgnore]
        public String url { get { return this.attributes.GetOrDefault<String>("url", ); } set { this.attributes["url"] = value; } }                
                    
    }
}
