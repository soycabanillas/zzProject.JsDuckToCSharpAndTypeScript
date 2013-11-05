using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.association.HasMany : Ext.data.association.Association {
                    
        [JsonIgnore]
        public Boolean autoLoad { get { return this.attributes.GetOrDefault<Boolean>("autoLoad", ); } set { this.attributes["autoLoad"] = value; } }                
                    
                    
        [JsonIgnore]
        public String filterProperty { get { return this.attributes.GetOrDefault<String>("filterProperty", ); } set { this.attributes["filterProperty"] = value; } }                
                    
                    
        [JsonIgnore]
        public String foreignKey { get { return this.attributes.GetOrDefault<String>("foreignKey", ); } set { this.attributes["foreignKey"] = value; } }                
                    
                    
        [JsonIgnore]
        public String name { get { return this.attributes.GetOrDefault<String>("name", ); } set { this.attributes["name"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object storeConfig { get { return this.attributes.GetOrDefault<Object>("storeConfig", ); } set { this.attributes["storeConfig"] = value; } }                
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", ); } set { this.attributes["type"] = value; } }                
                    
    }
}
