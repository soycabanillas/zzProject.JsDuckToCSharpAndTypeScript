using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.plugin.BufferedRenderer : Ext.AbstractPlugin {
                    
        private _leadingBufferZone_default = 20;
                    
                    
        [JsonIgnore]
        public Number leadingBufferZone { get { return this.attributes.GetOrDefault<Number>("leadingBufferZone", 20); } set { this.attributes["leadingBufferZone"] = value; } }                
                    
                    
        private _numFromEdge_default = 8;
                    
                    
        [JsonIgnore]
        public Number numFromEdge { get { return this.attributes.GetOrDefault<Number>("numFromEdge", 8); } set { this.attributes["numFromEdge"] = value; } }                
                    
                    
        private _percentageFromEdge_default = 0.35;
                    
                    
        [JsonIgnore]
        public Number percentageFromEdge { get { return this.attributes.GetOrDefault<Number>("percentageFromEdge", 0.35); } set { this.attributes["percentageFromEdge"] = value; } }                
                    
                    
        private _scrollToLoadBuffer_default = 200;
                    
                    
        [JsonIgnore]
        public Number scrollToLoadBuffer { get { return this.attributes.GetOrDefault<Number>("scrollToLoadBuffer", 200); } set { this.attributes["scrollToLoadBuffer"] = value; } }                
                    
                    
        private _synchronousRender_default = true;
                    
                    
        [JsonIgnore]
        public Boolean synchronousRender { get { return this.attributes.GetOrDefault<Boolean>("synchronousRender", true); } set { this.attributes["synchronousRender"] = value; } }                
                    
                    
        private _trailingBufferZone_default = 10;
                    
                    
        [JsonIgnore]
        public Number trailingBufferZone { get { return this.attributes.GetOrDefault<Number>("trailingBufferZone", 10); } set { this.attributes["trailingBufferZone"] = value; } }                
                    
                    
        private _variableRowHeight_default = false;
                    
                    
        [JsonIgnore]
        public Boolean variableRowHeight { get { return this.attributes.GetOrDefault<Boolean>("variableRowHeight", false); } set { this.attributes["variableRowHeight"] = value; } }                
                    
    }
}
