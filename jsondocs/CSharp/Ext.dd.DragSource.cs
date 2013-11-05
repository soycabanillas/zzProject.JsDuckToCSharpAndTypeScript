using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.dd.DragSource : Ext.dd.DDProxy {
                    
        private _animRepair_default = true;
                    
                    
        [JsonIgnore]
        public Boolean animRepair { get { return this.attributes.GetOrDefault<Boolean>("animRepair", true); } set { this.attributes["animRepair"] = value; } }                
                    
                    
        [JsonIgnore]
        public String ddGroup { get { return this.attributes.GetOrDefault<String>("ddGroup", ); } set { this.attributes["ddGroup"] = value; } }                
                    
                    
        private _dropAllowed_default = Ext.baseCSSPrefix + 'dd-drop-ok';
                    
                    
        [JsonIgnore]
        public String dropAllowed { get { return this.attributes.GetOrDefault<String>("dropAllowed", Ext.baseCSSPrefix + 'dd-drop-ok'); } set { this.attributes["dropAllowed"] = value; } }                
                    
                    
        private _dropNotAllowed_default = Ext.baseCSSPrefix + 'dd-drop-nodrop';
                    
                    
        [JsonIgnore]
        public String dropNotAllowed { get { return this.attributes.GetOrDefault<String>("dropNotAllowed", Ext.baseCSSPrefix + 'dd-drop-nodrop'); } set { this.attributes["dropNotAllowed"] = value; } }                
                    
                    
        private _repairHighlightColor_default = 'c3daf9';
                    
                    
        [JsonIgnore]
        public String repairHighlightColor { get { return this.attributes.GetOrDefault<String>("repairHighlightColor", 'c3daf9'); } set { this.attributes["repairHighlightColor"] = value; } }                
                    
    }
}
