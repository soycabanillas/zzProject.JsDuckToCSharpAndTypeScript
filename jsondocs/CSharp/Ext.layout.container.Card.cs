using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Card : Ext.layout.container.Fit {
                    
        private _deferredRender_default = false;
                    
                    
        [JsonIgnore]
        public Boolean deferredRender { get { return this.attributes.GetOrDefault<Boolean>("deferredRender", false); } set { this.attributes["deferredRender"] = value; } }                
                    
    }
}
