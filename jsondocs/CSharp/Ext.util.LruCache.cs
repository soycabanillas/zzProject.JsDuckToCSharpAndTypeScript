using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.LruCache : Ext.util.HashMap {
                    
        [JsonIgnore]
        public Number maxSize { get { return this.attributes.GetOrDefault<Number>("maxSize", ); } set { this.attributes["maxSize"] = value; } }                
                    
    }
}
