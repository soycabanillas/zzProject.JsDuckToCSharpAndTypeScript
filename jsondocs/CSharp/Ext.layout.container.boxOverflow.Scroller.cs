using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.boxOverflow.Scroller : Ext.layout.container.boxOverflow.None {
                    
        [JsonIgnore]
        public String afterCtCls { get { return this.attributes.GetOrDefault<String>("afterCtCls", ); } set { this.attributes["afterCtCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String afterScrollerCls { get { return this.attributes.GetOrDefault<String>("afterScrollerCls", ); } set { this.attributes["afterScrollerCls"] = value; } }                
                    
                    
        private _animateScroll_default = false;
                    
                    
        [JsonIgnore]
        public Boolean animateScroll { get { return this.attributes.GetOrDefault<Boolean>("animateScroll", false); } set { this.attributes["animateScroll"] = value; } }                
                    
                    
        [JsonIgnore]
        public String beforeCtCls { get { return this.attributes.GetOrDefault<String>("beforeCtCls", ); } set { this.attributes["beforeCtCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String beforeScrollerCls { get { return this.attributes.GetOrDefault<String>("beforeScrollerCls", ); } set { this.attributes["beforeScrollerCls"] = value; } }                
                    
                    
        private _scrollDuration_default = 400;
                    
                    
        [JsonIgnore]
        public Number scrollDuration { get { return this.attributes.GetOrDefault<Number>("scrollDuration", 400); } set { this.attributes["scrollDuration"] = value; } }                
                    
                    
        private _scrollIncrement_default = 20;
                    
                    
        [JsonIgnore]
        public Number scrollIncrement { get { return this.attributes.GetOrDefault<Number>("scrollIncrement", 20); } set { this.attributes["scrollIncrement"] = value; } }                
                    
                    
        private _scrollRepeatInterval_default = 60;
                    
                    
        [JsonIgnore]
        public Number scrollRepeatInterval { get { return this.attributes.GetOrDefault<Number>("scrollRepeatInterval", 60); } set { this.attributes["scrollRepeatInterval"] = value; } }                
                    
                    
        private _scrollerCls_default = 'x-box-scroller';
                    
                    
        [JsonIgnore]
        public String scrollerCls { get { return this.attributes.GetOrDefault<String>("scrollerCls", 'x-box-scroller'); } set { this.attributes["scrollerCls"] = value; } }                
                    
                    
        private _wheelIncrement_default = 10;
                    
                    
        [JsonIgnore]
        public Number wheelIncrement { get { return this.attributes.GetOrDefault<Number>("wheelIncrement", 10); } set { this.attributes["wheelIncrement"] = value; } }                
                    
    }
}
