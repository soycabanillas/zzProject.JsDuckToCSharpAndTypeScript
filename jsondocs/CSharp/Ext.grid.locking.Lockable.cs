using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.locking.Lockable : Ext.Base {
                    
        [JsonIgnore]
        public Object lockedGridConfig { get { return this.attributes.GetOrDefault<Object>("lockedGridConfig", ); } set { this.attributes["lockedGridConfig"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object lockedViewConfig { get { return this.attributes.GetOrDefault<Object>("lockedViewConfig", ); } set { this.attributes["lockedViewConfig"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object normalGridConfig { get { return this.attributes.GetOrDefault<Object>("normalGridConfig", ); } set { this.attributes["normalGridConfig"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object normalViewConfig { get { return this.attributes.GetOrDefault<Object>("normalViewConfig", ); } set { this.attributes["normalViewConfig"] = value; } }                
                    
                    
        private _scrollDelta_default = 40;
                    
                    
        [JsonIgnore]
        public Number scrollDelta { get { return this.attributes.GetOrDefault<Number>("scrollDelta", 40); } set { this.attributes["scrollDelta"] = value; } }                
                    
                    
        [JsonIgnore]
        public String subGridXType { get { return this.attributes.GetOrDefault<String>("subGridXType", ); } set { this.attributes["subGridXType"] = value; } }                
                    
                    
        private _syncRowHeight_default = true;
                    
                    
        [JsonIgnore]
        public Boolean syncRowHeight { get { return this.attributes.GetOrDefault<Boolean>("syncRowHeight", true); } set { this.attributes["syncRowHeight"] = value; } }                
                    
    }
}
