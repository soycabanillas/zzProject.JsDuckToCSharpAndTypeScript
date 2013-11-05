using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.slider.Tip : Ext.tip.Tip {
                    
        private _align_default = null;
                    
                    
        [JsonIgnore]
        public String align { get { return this.attributes.GetOrDefault<String>("align", null); } set { this.attributes["align"] = value; } }                
                    
                    
        private _minWidth_default = 10;
                    
                    
        [JsonIgnore]
        public Number minWidth { get { return this.attributes.GetOrDefault<Number>("minWidth", 10); } set { this.attributes["minWidth"] = value; } }                
                    
                    
        private _offsets_default = null;
                    
                    
        [JsonIgnore]
        public Array offsets { get { return this.attributes.GetOrDefault<Array>("offsets", null); } set { this.attributes["offsets"] = value; } }                
                    
                    
        private _position_default = For horizontal sliders, "top", for vertical sliders, "left";
                    
                    
        [JsonIgnore]
        public String position { get { return this.attributes.GetOrDefault<String>("position", For horizontal sliders, "top", for vertical sliders, "left"); } set { this.attributes["position"] = value; } }                
                    
    }
}
