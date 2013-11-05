using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.column.Date : Ext.grid.column.Column {
                    
        [JsonIgnore]
        public String format { get { return this.attributes.GetOrDefault<String>("format", ); } set { this.attributes["format"] = value; } }                
                    
    }
}
