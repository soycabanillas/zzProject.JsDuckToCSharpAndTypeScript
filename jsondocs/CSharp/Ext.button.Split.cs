using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.button.Split : Ext.button.Button {
                    
        [JsonIgnore]
        public Function arrowHandler { get { return this.attributes.GetOrDefault<Function>("arrowHandler", ); } set { this.attributes["arrowHandler"] = value; } }                
                    
                    
        [JsonIgnore]
        public String arrowTooltip { get { return this.attributes.GetOrDefault<String>("arrowTooltip", ); } set { this.attributes["arrowTooltip"] = value; } }                
                    
    }
}
