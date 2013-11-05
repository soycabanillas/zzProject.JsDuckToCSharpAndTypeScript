using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.view.View : Ext.view.AbstractView {
                    
        private _mouseOverOutBuffer_default = 20;
                    
                    
        [JsonIgnore]
        public Number mouseOverOutBuffer { get { return this.attributes.GetOrDefault<Number>("mouseOverOutBuffer", 20); } set { this.attributes["mouseOverOutBuffer"] = value; } }                
                    
    }
}
