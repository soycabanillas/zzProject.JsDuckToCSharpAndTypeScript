using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.reader.Xml : Ext.data.reader.Reader {
                    
        [JsonIgnore]
        public String namespace { get { return this.attributes.GetOrDefault<String>("namespace", ); } set { this.attributes["namespace"] = value; } }                
                    
                    
        [JsonIgnore]
        public String record { get { return this.attributes.GetOrDefault<String>("record", ); } set { this.attributes["record"] = value; } }                
                    
    }
}
