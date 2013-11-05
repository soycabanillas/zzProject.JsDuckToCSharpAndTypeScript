using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.menu.DatePicker : Ext.menu.Menu {
                    
        private _hideOnClick_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hideOnClick { get { return this.attributes.GetOrDefault<Boolean>("hideOnClick", true); } set { this.attributes["hideOnClick"] = value; } }                
                    
                    
        [JsonIgnore]
        public String pickerId { get { return this.attributes.GetOrDefault<String>("pickerId", ); } set { this.attributes["pickerId"] = value; } }                
                    
    }
}
