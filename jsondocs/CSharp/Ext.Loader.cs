using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.Loader :  {
                    
        private _disableCaching_default = true;
                    
                    
        [JsonIgnore]
        public Boolean disableCaching { get { return this.attributes.GetOrDefault<Boolean>("disableCaching", true); } set { this.attributes["disableCaching"] = value; } }                
                    
                    
        private _disableCachingParam_default = '_dc';
                    
                    
        [JsonIgnore]
        public String disableCachingParam { get { return this.attributes.GetOrDefault<String>("disableCachingParam", '_dc'); } set { this.attributes["disableCachingParam"] = value; } }                
                    
                    
        private _enabled_default = false;
                    
                    
        [JsonIgnore]
        public Boolean enabled { get { return this.attributes.GetOrDefault<Boolean>("enabled", false); } set { this.attributes["enabled"] = value; } }                
                    
                    
        private _garbageCollect_default = false;
                    
                    
        [JsonIgnore]
        public Boolean garbageCollect { get { return this.attributes.GetOrDefault<Boolean>("garbageCollect", false); } set { this.attributes["garbageCollect"] = value; } }                
                    
                    
        private _paths_default = {'Ext': '.'};
                    
                    
        [JsonIgnore]
        public Object paths { get { return this.attributes.GetOrDefault<Object>("paths", {'Ext': '.'}); } set { this.attributes["paths"] = value; } }                
                    
                    
        private _preserveScripts_default = true;
                    
                    
        [JsonIgnore]
        public Boolean preserveScripts { get { return this.attributes.GetOrDefault<Boolean>("preserveScripts", true); } set { this.attributes["preserveScripts"] = value; } }                
                    
                    
        private _scriptChainDelay_default = false;
                    
                    
        [JsonIgnore]
        public Boolean scriptChainDelay { get { return this.attributes.GetOrDefault<Boolean>("scriptChainDelay", false); } set { this.attributes["scriptChainDelay"] = value; } }                
                    
                    
        [JsonIgnore]
        public String scriptCharset { get { return this.attributes.GetOrDefault<String>("scriptCharset", ); } set { this.attributes["scriptCharset"] = value; } }                
                    
    }
}
