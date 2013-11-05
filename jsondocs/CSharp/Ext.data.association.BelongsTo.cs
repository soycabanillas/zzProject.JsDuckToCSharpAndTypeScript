using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.association.BelongsTo : Ext.data.association.Association {
                    
        [JsonIgnore]
        public String foreignKey { get { return this.attributes.GetOrDefault<String>("foreignKey", ); } set { this.attributes["foreignKey"] = value; } }                
                    
                    
        [JsonIgnore]
        public String getterName { get { return this.attributes.GetOrDefault<String>("getterName", ); } set { this.attributes["getterName"] = value; } }                
                    
                    
        [JsonIgnore]
        public String setterName { get { return this.attributes.GetOrDefault<String>("setterName", ); } set { this.attributes["setterName"] = value; } }                
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", ); } set { this.attributes["type"] = value; } }                
                    
    }
}
