using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.panel.Proxy : Ext.Base {
                    
        private _insertProxy_default = true;
                    
                    
        [JsonIgnore]
        public Boolean insertProxy { get { return this.attributes.GetOrDefault<Boolean>("insertProxy", true); } set { this.attributes["insertProxy"] = value; } }                
                    
                    
        private _moveOnDrag_default = true;
                    
                    
        [JsonIgnore]
        public Boolean moveOnDrag { get { return this.attributes.GetOrDefault<Boolean>("moveOnDrag", true); } set { this.attributes["moveOnDrag"] = value; } }                
                    
    }
}
