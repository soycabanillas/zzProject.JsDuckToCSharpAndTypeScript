using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Anchor : Ext.layout.container.Auto {
                    
        [JsonIgnore]
        public String anchor { get { return this.attributes.GetOrDefault<String>("anchor", ); } set { this.attributes["anchor"] = value; } }                
                    
                    
        private _defaultAnchor_default = '100%';
                    
                    
        [JsonIgnore]
        public String defaultAnchor { get { return this.attributes.GetOrDefault<String>("defaultAnchor", '100%'); } set { this.attributes["defaultAnchor"] = value; } }                
                    
    }
}
