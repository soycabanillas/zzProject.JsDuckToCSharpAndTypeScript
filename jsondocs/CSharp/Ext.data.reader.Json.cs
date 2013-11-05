using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.reader.Json : Ext.data.reader.Reader {
                    
        private _metaProperty_default = "metaData";
                    
                    
        [JsonIgnore]
        public String metaProperty { get { return this.attributes.GetOrDefault<String>("metaProperty", "metaData"); } set { this.attributes["metaProperty"] = value; } }                
                    
                    
        [JsonIgnore]
        public String record { get { return this.attributes.GetOrDefault<String>("record", ); } set { this.attributes["record"] = value; } }                
                    
                    
        private _root_default = '';
                    
                    
        [JsonIgnore]
        public String root { get { return this.attributes.GetOrDefault<String>("root", ''); } set { this.attributes["root"] = value; } }                
                    
                    
        private _useSimpleAccessors_default = false;
                    
                    
        [JsonIgnore]
        public Boolean useSimpleAccessors { get { return this.attributes.GetOrDefault<Boolean>("useSimpleAccessors", false); } set { this.attributes["useSimpleAccessors"] = value; } }                
                    
    }
}
