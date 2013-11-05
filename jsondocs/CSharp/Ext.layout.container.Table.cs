using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.Table : Ext.layout.container.Container {
                    
        [JsonIgnore]
        public Number columns { get { return this.attributes.GetOrDefault<Number>("columns", ); } set { this.attributes["columns"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object tableAttrs { get { return this.attributes.GetOrDefault<Object>("tableAttrs", ); } set { this.attributes["tableAttrs"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object tdAttrs { get { return this.attributes.GetOrDefault<Object>("tdAttrs", ); } set { this.attributes["tdAttrs"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object trAttrs { get { return this.attributes.GetOrDefault<Object>("trAttrs", ); } set { this.attributes["trAttrs"] = value; } }                
                    
    }
}
