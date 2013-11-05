using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.draw.Surface : Ext.Base {
                    
        [JsonIgnore]
        public Number height { get { return this.attributes.GetOrDefault<Number>("height", ); } set { this.attributes["height"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.draw.Sprite[] items { get { return this.attributes.GetOrDefault<Ext.draw.Sprite[]>("items", ); } set { this.attributes["items"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number width { get { return this.attributes.GetOrDefault<Number>("width", ); } set { this.attributes["width"] = value; } }                
                    
    }
}
