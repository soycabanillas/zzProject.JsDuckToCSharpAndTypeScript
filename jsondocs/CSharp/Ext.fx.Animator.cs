using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.fx.Animator : Ext.Base {
                    
        private _delay_default = 0;
                    
                    
        [JsonIgnore]
        public Number delay { get { return this.attributes.GetOrDefault<Number>("delay", 0); } set { this.attributes["delay"] = value; } }                
                    
                    
        private _duration_default = 250;
                    
                    
        [JsonIgnore]
        public Number duration { get { return this.attributes.GetOrDefault<Number>("duration", 250); } set { this.attributes["duration"] = value; } }                
                    
                    
        private _dynamic_default = false;
                    
                    
        [JsonIgnore]
        public Boolean dynamic { get { return this.attributes.GetOrDefault<Boolean>("dynamic", false); } set { this.attributes["dynamic"] = value; } }                
                    
                    
        private _easing_default = 'ease';
                    
                    
        [JsonIgnore]
        public String easing { get { return this.attributes.GetOrDefault<String>("easing", 'ease'); } set { this.attributes["easing"] = value; } }                
                    
                    
        private _iterations_default = 1;
                    
                    
        [JsonIgnore]
        public Number iterations { get { return this.attributes.GetOrDefault<Number>("iterations", 1); } set { this.attributes["iterations"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object keyframes { get { return this.attributes.GetOrDefault<Object>("keyframes", ); } set { this.attributes["keyframes"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.fx.target.Target target { get { return this.attributes.GetOrDefault<Ext.fx.target.Target>("target", ); } set { this.attributes["target"] = value; } }                
                    
    }
}
