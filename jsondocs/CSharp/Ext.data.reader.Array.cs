using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.reader.Array : Ext.data.reader.Json {
                    
        private _successProperty_default = "success";
                    
                    
        [JsonIgnore]
        public String successProperty { get { return this.attributes.GetOrDefault<String>("successProperty", "success"); } set { this.attributes["successProperty"] = value; } }                
                    
                    
        private _totalProperty_default = "total";
                    
                    
        [JsonIgnore]
        public String totalProperty { get { return this.attributes.GetOrDefault<String>("totalProperty", "total"); } set { this.attributes["totalProperty"] = value; } }                
                    
    }
}
