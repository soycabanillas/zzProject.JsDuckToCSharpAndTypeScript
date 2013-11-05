using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tree.View : Ext.view.Table {
                    
        [JsonIgnore]
        public Boolean animate { get { return this.attributes.GetOrDefault<Boolean>("animate", ); } set { this.attributes["animate"] = value; } }                
                    
                    
        private _blockRefresh_default = true;
                    
                    
        [JsonIgnore]
        public Boolean blockRefresh { get { return this.attributes.GetOrDefault<Boolean>("blockRefresh", true); } set { this.attributes["blockRefresh"] = value; } }                
                    
                    
        private _deferInitialRefresh_default = false;
                    
                    
        [JsonIgnore]
        public Boolean deferInitialRefresh { get { return this.attributes.GetOrDefault<Boolean>("deferInitialRefresh", false); } set { this.attributes["deferInitialRefresh"] = value; } }                
                    
                    
        private _loadMask_default = false;
                    
                    
        [JsonIgnore]
        public Boolean loadMask { get { return this.attributes.GetOrDefault<Boolean>("loadMask", false); } set { this.attributes["loadMask"] = value; } }                
                    
                    
        private _loadingCls_default = Ext.baseCSSPrefix + 'grid-tree-loading';
                    
                    
        [JsonIgnore]
        public String loadingCls { get { return this.attributes.GetOrDefault<String>("loadingCls", Ext.baseCSSPrefix + 'grid-tree-loading'); } set { this.attributes["loadingCls"] = value; } }                
                    
                    
        private _rootVisible_default = true;
                    
                    
        [JsonIgnore]
        public Boolean rootVisible { get { return this.attributes.GetOrDefault<Boolean>("rootVisible", true); } set { this.attributes["rootVisible"] = value; } }                
                    
                    
        private _stripeRows_default = false;
                    
                    
        [JsonIgnore]
        public Boolean stripeRows { get { return this.attributes.GetOrDefault<Boolean>("stripeRows", false); } set { this.attributes["stripeRows"] = value; } }                
                    
    }
}
