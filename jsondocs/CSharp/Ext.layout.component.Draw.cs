using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.component.Draw : Ext.layout.component.Auto {
                    
        private _setHeightInDom_default = true;
                    
                    
        [JsonIgnore]
        public Boolean setHeightInDom { get { return this.attributes.GetOrDefault<Boolean>("setHeightInDom", true); } set { this.attributes["setHeightInDom"] = value; } }                
                    
                    
        private _setWidthInDom_default = true;
                    
                    
        [JsonIgnore]
        public Boolean setWidthInDom { get { return this.attributes.GetOrDefault<Boolean>("setWidthInDom", true); } set { this.attributes["setWidthInDom"] = value; } }                
                    
    }
}
