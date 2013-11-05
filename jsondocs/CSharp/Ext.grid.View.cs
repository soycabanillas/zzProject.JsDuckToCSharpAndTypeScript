using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.View : Ext.view.Table {
                    
        private _autoScroll_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoScroll { get { return this.attributes.GetOrDefault<Boolean>("autoScroll", true); } set { this.attributes["autoScroll"] = value; } }                
                    
                    
        private _stripeRows_default = true;
                    
                    
        [JsonIgnore]
        public Boolean stripeRows { get { return this.attributes.GetOrDefault<Boolean>("stripeRows", true); } set { this.attributes["stripeRows"] = value; } }                
                    
    }
}
