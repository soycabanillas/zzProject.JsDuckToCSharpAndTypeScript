using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.Operation : Ext.Base {
                    
        [JsonIgnore]
        public String action { get { return this.attributes.GetOrDefault<String>("action", ); } set { this.attributes["action"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.Batch batch { get { return this.attributes.GetOrDefault<Ext.data.Batch>("batch", ); } set { this.attributes["batch"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function callback { get { return this.attributes.GetOrDefault<Function>("callback", ); } set { this.attributes["callback"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.util.Filter[] filters { get { return this.attributes.GetOrDefault<Ext.util.Filter[]>("filters", ); } set { this.attributes["filters"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.util.Grouper[] groupers { get { return this.attributes.GetOrDefault<Ext.util.Grouper[]>("groupers", ); } set { this.attributes["groupers"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number limit { get { return this.attributes.GetOrDefault<Number>("limit", ); } set { this.attributes["limit"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object params { get { return this.attributes.GetOrDefault<Object>("params", ); } set { this.attributes["params"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.util.Sorter[] sorters { get { return this.attributes.GetOrDefault<Ext.util.Sorter[]>("sorters", ); } set { this.attributes["sorters"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number start { get { return this.attributes.GetOrDefault<Number>("start", ); } set { this.attributes["start"] = value; } }                
                    
                    
        private _synchronous_default = true;
                    
                    
        [JsonIgnore]
        public Boolean synchronous { get { return this.attributes.GetOrDefault<Boolean>("synchronous", true); } set { this.attributes["synchronous"] = value; } }                
                    
    }
}
