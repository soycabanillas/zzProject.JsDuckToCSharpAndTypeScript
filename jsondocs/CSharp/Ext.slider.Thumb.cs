using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.slider.Thumb : Ext.Base {
                    
        private _constrain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", false); } set { this.attributes["constrain"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.slider.MultiSlider slider { get { return this.attributes.GetOrDefault<Ext.slider.MultiSlider>("slider", ); } set { this.attributes["slider"] = value; } }                
                    
    }
}
