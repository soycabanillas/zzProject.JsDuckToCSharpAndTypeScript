using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.column.Boolean : Ext.grid.column.Column {
                    
        private _falseText_default = 'false';
                    
                    
        [JsonIgnore]
        public String falseText { get { return this.attributes.GetOrDefault<String>("falseText", 'false'); } set { this.attributes["falseText"] = value; } }                
                    
                    
        private _trueText_default = 'true';
                    
                    
        [JsonIgnore]
        public String trueText { get { return this.attributes.GetOrDefault<String>("trueText", 'true'); } set { this.attributes["trueText"] = value; } }                
                    
                    
        private _undefinedText_default = '&#160;';
                    
                    
        [JsonIgnore]
        public String undefinedText { get { return this.attributes.GetOrDefault<String>("undefinedText", '&#160;'); } set { this.attributes["undefinedText"] = value; } }                
                    
    }
}
