using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.Sorter : Ext.Base {
                    
        private _direction_default = "ASC";
                    
                    
        [JsonIgnore]
        public String direction { get { return this.attributes.GetOrDefault<String>("direction", "ASC"); } set { this.attributes["direction"] = value; } }                
                    
                    
        [JsonIgnore]
        public String property { get { return this.attributes.GetOrDefault<String>("property", ); } set { this.attributes["property"] = value; } }                
                    
                    
        [JsonIgnore]
        public String root { get { return this.attributes.GetOrDefault<String>("root", ); } set { this.attributes["root"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function sorterFn { get { return this.attributes.GetOrDefault<Function>("sorterFn", ); } set { this.attributes["sorterFn"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function transform { get { return this.attributes.GetOrDefault<Function>("transform", ); } set { this.attributes["transform"] = value; } }                
                    
    }
}
