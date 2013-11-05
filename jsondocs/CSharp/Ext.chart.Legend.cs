using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.Legend : Ext.Base {
                    
        private _boxFill_default = '#FFF';
                    
                    
        [JsonIgnore]
        public String boxFill { get { return this.attributes.GetOrDefault<String>("boxFill", '#FFF'); } set { this.attributes["boxFill"] = value; } }                
                    
                    
        private _boxStroke_default = '#000';
                    
                    
        [JsonIgnore]
        public String boxStroke { get { return this.attributes.GetOrDefault<String>("boxStroke", '#000'); } set { this.attributes["boxStroke"] = value; } }                
                    
                    
        private _boxStrokeWidth_default = 1;
                    
                    
        [JsonIgnore]
        public String boxStrokeWidth { get { return this.attributes.GetOrDefault<String>("boxStrokeWidth", 1); } set { this.attributes["boxStrokeWidth"] = value; } }                
                    
                    
        private _boxZIndex_default = 100;
                    
                    
        [JsonIgnore]
        public Number boxZIndex { get { return this.attributes.GetOrDefault<Number>("boxZIndex", 100); } set { this.attributes["boxZIndex"] = value; } }                
                    
                    
        private _itemSpacing_default = 10;
                    
                    
        [JsonIgnore]
        public Number itemSpacing { get { return this.attributes.GetOrDefault<Number>("itemSpacing", 10); } set { this.attributes["itemSpacing"] = value; } }                
                    
                    
        private _labelColor_default = '#000';
                    
                    
        [JsonIgnore]
        public String labelColor { get { return this.attributes.GetOrDefault<String>("labelColor", '#000'); } set { this.attributes["labelColor"] = value; } }                
                    
                    
        private _labelFont_default = '12px Helvetica, sans-serif';
                    
                    
        [JsonIgnore]
        public String labelFont { get { return this.attributes.GetOrDefault<String>("labelFont", '12px Helvetica, sans-serif'); } set { this.attributes["labelFont"] = value; } }                
                    
                    
        private _padding_default = 5;
                    
                    
        [JsonIgnore]
        public Number padding { get { return this.attributes.GetOrDefault<Number>("padding", 5); } set { this.attributes["padding"] = value; } }                
                    
                    
        private _position_default = 'bottom';
                    
                    
        [JsonIgnore]
        public String position { get { return this.attributes.GetOrDefault<String>("position", 'bottom'); } set { this.attributes["position"] = value; } }                
                    
                    
        private _update_default = true;
                    
                    
        [JsonIgnore]
        public Boolean update { get { return this.attributes.GetOrDefault<Boolean>("update", true); } set { this.attributes["update"] = value; } }                
                    
                    
        private _visible_default = true;
                    
                    
        [JsonIgnore]
        public Boolean visible { get { return this.attributes.GetOrDefault<Boolean>("visible", true); } set { this.attributes["visible"] = value; } }                
                    
                    
        private _x_default = 0;
                    
                    
        [JsonIgnore]
        public Number x { get { return this.attributes.GetOrDefault<Number>("x", 0); } set { this.attributes["x"] = value; } }                
                    
                    
        private _y_default = 0;
                    
                    
        [JsonIgnore]
        public Number y { get { return this.attributes.GetOrDefault<Number>("y", 0); } set { this.attributes["y"] = value; } }                
                    
    }
}
