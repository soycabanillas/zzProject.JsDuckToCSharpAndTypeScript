using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tree.ViewDropZone : Ext.view.DropZone {
                    
        [JsonIgnore]
        public Boolean allowContainerDrop { get { return this.attributes.GetOrDefault<Boolean>("allowContainerDrop", ); } set { this.attributes["allowContainerDrop"] = value; } }                
                    
                    
        private _allowParentInserts_default = false;
                    
                    
        [JsonIgnore]
        public Boolean allowParentInserts { get { return this.attributes.GetOrDefault<Boolean>("allowParentInserts", false); } set { this.attributes["allowParentInserts"] = value; } }                
                    
                    
        private _appendOnly_default = false;
                    
                    
        [JsonIgnore]
        public Boolean appendOnly { get { return this.attributes.GetOrDefault<Boolean>("appendOnly", false); } set { this.attributes["appendOnly"] = value; } }                
                    
                    
        private _expandDelay_default = 500;
                    
                    
        [JsonIgnore]
        public Number expandDelay { get { return this.attributes.GetOrDefault<Number>("expandDelay", 500); } set { this.attributes["expandDelay"] = value; } }                
                    
    }
}
