using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.proxy.JsonP : Ext.data.proxy.Server {
                    
        private _autoAppendParams_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoAppendParams { get { return this.attributes.GetOrDefault<Boolean>("autoAppendParams", true); } set { this.attributes["autoAppendParams"] = value; } }                
                    
                    
        private _callbackKey_default = 'callback';
                    
                    
        [JsonIgnore]
        public String callbackKey { get { return this.attributes.GetOrDefault<String>("callbackKey", 'callback'); } set { this.attributes["callbackKey"] = value; } }                
                    
                    
        private _recordParam_default = records;
                    
                    
        [JsonIgnore]
        public String recordParam { get { return this.attributes.GetOrDefault<String>("recordParam", records); } set { this.attributes["recordParam"] = value; } }                
                    
    }
}
