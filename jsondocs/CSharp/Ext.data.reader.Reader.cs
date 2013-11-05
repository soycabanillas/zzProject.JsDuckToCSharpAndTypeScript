using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.reader.Reader : Ext.Base {
                    
        [JsonIgnore]
        public String idProperty { get { return this.attributes.GetOrDefault<String>("idProperty", ); } set { this.attributes["idProperty"] = value; } }                
                    
                    
        private _implicitIncludes_default = true;
                    
                    
        [JsonIgnore]
        public Boolean implicitIncludes { get { return this.attributes.GetOrDefault<Boolean>("implicitIncludes", true); } set { this.attributes["implicitIncludes"] = value; } }                
                    
                    
        [JsonIgnore]
        public String messageProperty { get { return this.attributes.GetOrDefault<String>("messageProperty", ); } set { this.attributes["messageProperty"] = value; } }                
                    
                    
        private _readRecordsOnFailure_default = true;
                    
                    
        [JsonIgnore]
        public Boolean readRecordsOnFailure { get { return this.attributes.GetOrDefault<Boolean>("readRecordsOnFailure", true); } set { this.attributes["readRecordsOnFailure"] = value; } }                
                    
                    
        private _root_default = '';
                    
                    
        [JsonIgnore]
        public String root { get { return this.attributes.GetOrDefault<String>("root", ''); } set { this.attributes["root"] = value; } }                
                    
                    
        private _successProperty_default = "success";
                    
                    
        [JsonIgnore]
        public String successProperty { get { return this.attributes.GetOrDefault<String>("successProperty", "success"); } set { this.attributes["successProperty"] = value; } }                
                    
                    
        private _totalProperty_default = "total";
                    
                    
        [JsonIgnore]
        public String totalProperty { get { return this.attributes.GetOrDefault<String>("totalProperty", "total"); } set { this.attributes["totalProperty"] = value; } }                
                    
    }
}
