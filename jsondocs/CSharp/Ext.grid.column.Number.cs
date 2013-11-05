using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.column.Number : Ext.grid.column.Column {
                    
        private _format_default = '0,000.00';
                    
                    
        [JsonIgnore]
        public String format { get { return this.attributes.GetOrDefault<String>("format", '0,000.00'); } set { this.attributes["format"] = value; } }                
                    
    }
}
