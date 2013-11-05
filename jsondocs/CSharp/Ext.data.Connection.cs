using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.Connection : Ext.Base {
                    
        private _autoAbort_default = false;
                    
                    
        [JsonIgnore]
        public Boolean autoAbort { get { return this.attributes.GetOrDefault<Boolean>("autoAbort", false); } set { this.attributes["autoAbort"] = value; } }                
                    
                    
        private _binary_default = false;
                    
                    
        [JsonIgnore]
        public Boolean binary { get { return this.attributes.GetOrDefault<Boolean>("binary", false); } set { this.attributes["binary"] = value; } }                
                    
                    
        private _cors_default = false;
                    
                    
        [JsonIgnore]
        public Boolean cors { get { return this.attributes.GetOrDefault<Boolean>("cors", false); } set { this.attributes["cors"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object defaultHeaders { get { return this.attributes.GetOrDefault<Object>("defaultHeaders", ); } set { this.attributes["defaultHeaders"] = value; } }                
                    
                    
        private _disableCaching_default = true;
                    
                    
        [JsonIgnore]
        public Boolean disableCaching { get { return this.attributes.GetOrDefault<Boolean>("disableCaching", true); } set { this.attributes["disableCaching"] = value; } }                
                    
                    
        private _disableCachingParam_default = '_dc';
                    
                    
        [JsonIgnore]
        public String disableCachingParam { get { return this.attributes.GetOrDefault<String>("disableCachingParam", '_dc'); } set { this.attributes["disableCachingParam"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object extraParams { get { return this.attributes.GetOrDefault<Object>("extraParams", ); } set { this.attributes["extraParams"] = value; } }                
                    
                    
        [JsonIgnore]
        public String method { get { return this.attributes.GetOrDefault<String>("method", ); } set { this.attributes["method"] = value; } }                
                    
                    
        private _timeout_default = 30000;
                    
                    
        [JsonIgnore]
        public Number timeout { get { return this.attributes.GetOrDefault<Number>("timeout", 30000); } set { this.attributes["timeout"] = value; } }                
                    
                    
        private _withCredentials_default = false;
                    
                    
        [JsonIgnore]
        public Boolean withCredentials { get { return this.attributes.GetOrDefault<Boolean>("withCredentials", false); } set { this.attributes["withCredentials"] = value; } }                
                    
    }
}
