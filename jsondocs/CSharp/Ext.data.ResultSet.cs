using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.ResultSet : Ext.Base {
                    
        private _count_default = 0;
                    
                    
        [JsonIgnore]
        public Number count { get { return this.attributes.GetOrDefault<Number>("count", 0); } set { this.attributes["count"] = value; } }                
                    
                    
        private _loaded_default = true;
                    
                    
        [JsonIgnore]
        public Boolean loaded { get { return this.attributes.GetOrDefault<Boolean>("loaded", true); } set { this.attributes["loaded"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.Model[] records { get { return this.attributes.GetOrDefault<Ext.data.Model[]>("records", ); } set { this.attributes["records"] = value; } }                
                    
                    
        private _success_default = false;
                    
                    
        [JsonIgnore]
        public Boolean success { get { return this.attributes.GetOrDefault<Boolean>("success", false); } set { this.attributes["success"] = value; } }                
                    
                    
        private _total_default = 0;
                    
                    
        [JsonIgnore]
        public Number total { get { return this.attributes.GetOrDefault<Number>("total", 0); } set { this.attributes["total"] = value; } }                
                    
    }
}
