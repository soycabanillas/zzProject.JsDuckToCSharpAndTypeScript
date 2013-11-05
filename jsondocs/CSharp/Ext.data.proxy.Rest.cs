using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.proxy.Rest : Ext.data.proxy.Ajax {
                    
        private _appendId_default = true;
                    
                    
        [JsonIgnore]
        public Boolean appendId { get { return this.attributes.GetOrDefault<Boolean>("appendId", true); } set { this.attributes["appendId"] = value; } }                
                    
                    
        private _batchActions_default = false;
                    
                    
        [JsonIgnore]
        public Boolean batchActions { get { return this.attributes.GetOrDefault<Boolean>("batchActions", false); } set { this.attributes["batchActions"] = value; } }                
                    
                    
        [JsonIgnore]
        public String format { get { return this.attributes.GetOrDefault<String>("format", ); } set { this.attributes["format"] = value; } }                
                    
    }
}
