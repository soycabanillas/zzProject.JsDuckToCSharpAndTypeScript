using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.picker.Time : Ext.view.BoundList {
                    
        private _componentCls_default = Ext.baseCSSPrefix + 'timepicker';
                    
                    
        [JsonIgnore]
        public String componentCls { get { return this.attributes.GetOrDefault<String>("componentCls", Ext.baseCSSPrefix + 'timepicker'); } set { this.attributes["componentCls"] = value; } }                
                    
                    
        private _format_default = undefined;
                    
                    
        [JsonIgnore]
        public String format { get { return this.attributes.GetOrDefault<String>("format", undefined); } set { this.attributes["format"] = value; } }                
                    
                    
        private _increment_default = 15;
                    
                    
        [JsonIgnore]
        public Number increment { get { return this.attributes.GetOrDefault<Number>("increment", 15); } set { this.attributes["increment"] = value; } }                
                    
                    
        [JsonIgnore]
        public Date maxValue { get { return this.attributes.GetOrDefault<Date>("maxValue", ); } set { this.attributes["maxValue"] = value; } }                
                    
                    
        [JsonIgnore]
        public Date minValue { get { return this.attributes.GetOrDefault<Date>("minValue", ); } set { this.attributes["minValue"] = value; } }                
                    
    }
}
