using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.axis.Numeric : Ext.chart.axis.Axis {
                    
        private _adjustMaximumByMajorUnit_default = false;
                    
                    
        [JsonIgnore]
        public Boolean adjustMaximumByMajorUnit { get { return this.attributes.GetOrDefault<Boolean>("adjustMaximumByMajorUnit", false); } set { this.attributes["adjustMaximumByMajorUnit"] = value; } }                
                    
                    
        private _adjustMinimumByMajorUnit_default = false;
                    
                    
        [JsonIgnore]
        public Boolean adjustMinimumByMajorUnit { get { return this.attributes.GetOrDefault<Boolean>("adjustMinimumByMajorUnit", false); } set { this.attributes["adjustMinimumByMajorUnit"] = value; } }                
                    
                    
        private _constrain_default = true;
                    
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", true); } set { this.attributes["constrain"] = value; } }                
                    
                    
        private _decimals_default = 2;
                    
                    
        [JsonIgnore]
        public Number decimals { get { return this.attributes.GetOrDefault<Number>("decimals", 2); } set { this.attributes["decimals"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number maximum { get { return this.attributes.GetOrDefault<Number>("maximum", ); } set { this.attributes["maximum"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minimum { get { return this.attributes.GetOrDefault<Number>("minimum", ); } set { this.attributes["minimum"] = value; } }                
                    
                    
        private _position_default = 'left';
                    
                    
        [JsonIgnore]
        public String position { get { return this.attributes.GetOrDefault<String>("position", 'left'); } set { this.attributes["position"] = value; } }                
                    
    }
}
