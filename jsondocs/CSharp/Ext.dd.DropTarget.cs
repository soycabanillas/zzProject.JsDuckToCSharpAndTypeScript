using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.dd.DropTarget : Ext.dd.DDTarget {
                    
        [JsonIgnore]
        public String ddGroup { get { return this.attributes.GetOrDefault<String>("ddGroup", ); } set { this.attributes["ddGroup"] = value; } }                
                    
                    
        private _dropAllowed_default = Ext.baseCSSPrefix + 'dd-drop-ok';
                    
                    
        [JsonIgnore]
        public String dropAllowed { get { return this.attributes.GetOrDefault<String>("dropAllowed", Ext.baseCSSPrefix + 'dd-drop-ok'); } set { this.attributes["dropAllowed"] = value; } }                
                    
                    
        private _dropNotAllowed_default = Ext.baseCSSPrefix + 'dd-drop-nodrop';
                    
                    
        [JsonIgnore]
        public String dropNotAllowed { get { return this.attributes.GetOrDefault<String>("dropNotAllowed", Ext.baseCSSPrefix + 'dd-drop-nodrop'); } set { this.attributes["dropNotAllowed"] = value; } }                
                    
                    
        private _overClass_default = "";
                    
                    
        [JsonIgnore]
        public String overClass { get { return this.attributes.GetOrDefault<String>("overClass", ""); } set { this.attributes["overClass"] = value; } }                
                    
    }
}
