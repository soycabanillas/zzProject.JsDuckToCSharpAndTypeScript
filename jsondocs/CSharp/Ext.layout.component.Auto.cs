using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.component.Auto : Ext.layout.component.Component {
                    
        private _setHeightInDom_default = false;
                    
                    
        [JsonIgnore]
        public Boolean setHeightInDom { get { return this.attributes.GetOrDefault<Boolean>("setHeightInDom", false); } set { this.attributes["setHeightInDom"] = value; } }                
                    
                    
        private _setWidthInDom_default = false;
                    
                    
        [JsonIgnore]
        public Boolean setWidthInDom { get { return this.attributes.GetOrDefault<Boolean>("setWidthInDom", false); } set { this.attributes["setWidthInDom"] = value; } }                
                    
    }
}
