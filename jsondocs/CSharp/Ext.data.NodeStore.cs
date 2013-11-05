using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.NodeStore : Ext.data.Store {
                    
        [JsonIgnore]
        public Ext.data.Model node { get { return this.attributes.GetOrDefault<Ext.data.Model>("node", ); } set { this.attributes["node"] = value; } }                
                    
                    
        private _recursive_default = false;
                    
                    
        [JsonIgnore]
        public Boolean recursive { get { return this.attributes.GetOrDefault<Boolean>("recursive", false); } set { this.attributes["recursive"] = value; } }                
                    
                    
        private _rootVisible_default = false;
                    
                    
        [JsonIgnore]
        public Boolean rootVisible { get { return this.attributes.GetOrDefault<Boolean>("rootVisible", false); } set { this.attributes["rootVisible"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.TreeStore treeStore { get { return this.attributes.GetOrDefault<Ext.data.TreeStore>("treeStore", ); } set { this.attributes["treeStore"] = value; } }                
                    
    }
}
