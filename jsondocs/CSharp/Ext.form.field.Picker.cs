using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Picker : Ext.form.field.Trigger {
                    
        private _editable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean editable { get { return this.attributes.GetOrDefault<Boolean>("editable", true); } set { this.attributes["editable"] = value; } }                
                    
                    
        private _matchFieldWidth_default = true;
                    
                    
        [JsonIgnore]
        public Boolean matchFieldWidth { get { return this.attributes.GetOrDefault<Boolean>("matchFieldWidth", true); } set { this.attributes["matchFieldWidth"] = value; } }                
                    
                    
        private _openCls_default = 'x-pickerfield-open';
                    
                    
        [JsonIgnore]
        public String openCls { get { return this.attributes.GetOrDefault<String>("openCls", 'x-pickerfield-open'); } set { this.attributes["openCls"] = value; } }                
                    
                    
        private _pickerAlign_default = 'tl-bl?';
                    
                    
        [JsonIgnore]
        public String pickerAlign { get { return this.attributes.GetOrDefault<String>("pickerAlign", 'tl-bl?'); } set { this.attributes["pickerAlign"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number[] pickerOffset { get { return this.attributes.GetOrDefault<Number[]>("pickerOffset", ); } set { this.attributes["pickerOffset"] = value; } }                
                    
    }
}
