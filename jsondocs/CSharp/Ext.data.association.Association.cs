using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.association.Association : Ext.Base {
                    
        [JsonIgnore]
        public String associatedModel { get { return this.attributes.GetOrDefault<String>("associatedModel", ); } set { this.attributes["associatedModel"] = value; } }                
                    
                    
        [JsonIgnore]
        public String associationKey { get { return this.attributes.GetOrDefault<String>("associationKey", ); } set { this.attributes["associationKey"] = value; } }                
                    
                    
        [JsonIgnore]
        public String model { get { return this.attributes.GetOrDefault<String>("model", ); } set { this.attributes["model"] = value; } }                
                    
                    
        [JsonIgnore]
        public String ownerModel { get { return this.attributes.GetOrDefault<String>("ownerModel", ); } set { this.attributes["ownerModel"] = value; } }                
                    
                    
        private _primaryKey_default = 'id';
                    
                    
        [JsonIgnore]
        public String primaryKey { get { return this.attributes.GetOrDefault<String>("primaryKey", 'id'); } set { this.attributes["primaryKey"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.reader.Reader reader { get { return this.attributes.GetOrDefault<Ext.data.reader.Reader>("reader", ); } set { this.attributes["reader"] = value; } }                
                    
    }
}
