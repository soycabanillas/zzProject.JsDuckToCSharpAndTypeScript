using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.Template : Ext.Base {
                    
        [JsonIgnore]
        public Boolean compiled { get { return this.attributes.GetOrDefault<Boolean>("compiled", ); } set { this.attributes["compiled"] = value; } }                
                    
                    
        private _disableFormats_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disableFormats { get { return this.attributes.GetOrDefault<Boolean>("disableFormats", false); } set { this.attributes["disableFormats"] = value; } }                
                    
    }
}
