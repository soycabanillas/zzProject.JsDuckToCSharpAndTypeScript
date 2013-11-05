using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Number : Ext.form.field.Spinner {
                    
        private _allowDecimals_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowDecimals { get { return this.attributes.GetOrDefault<Boolean>("allowDecimals", true); } set { this.attributes["allowDecimals"] = value; } }                
                    
                    
        private _allowExponential_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowExponential { get { return this.attributes.GetOrDefault<Boolean>("allowExponential", true); } set { this.attributes["allowExponential"] = value; } }                
                    
                    
        private _autoStripChars_default = false;
                    
                    
        [JsonIgnore]
        public Boolean autoStripChars { get { return this.attributes.GetOrDefault<Boolean>("autoStripChars", false); } set { this.attributes["autoStripChars"] = value; } }                
                    
                    
        private _baseChars_default = '0123456789';
                    
                    
        [JsonIgnore]
        public String baseChars { get { return this.attributes.GetOrDefault<String>("baseChars", '0123456789'); } set { this.attributes["baseChars"] = value; } }                
                    
                    
        private _decimalPrecision_default = 2;
                    
                    
        [JsonIgnore]
        public Number decimalPrecision { get { return this.attributes.GetOrDefault<Number>("decimalPrecision", 2); } set { this.attributes["decimalPrecision"] = value; } }                
                    
                    
        private _decimalSeparator_default = '.';
                    
                    
        [JsonIgnore]
        public String decimalSeparator { get { return this.attributes.GetOrDefault<String>("decimalSeparator", '.'); } set { this.attributes["decimalSeparator"] = value; } }                
                    
                    
        private _maxText_default = 'The maximum value for this field is {0}';
                    
                    
        [JsonIgnore]
        public String maxText { get { return this.attributes.GetOrDefault<String>("maxText", 'The maximum value for this field is {0}'); } set { this.attributes["maxText"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number maxValue { get { return this.attributes.GetOrDefault<Number>("maxValue", ); } set { this.attributes["maxValue"] = value; } }                
                    
                    
        private _minText_default = 'The minimum value for this field is {0}';
                    
                    
        [JsonIgnore]
        public String minText { get { return this.attributes.GetOrDefault<String>("minText", 'The minimum value for this field is {0}'); } set { this.attributes["minText"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minValue { get { return this.attributes.GetOrDefault<Number>("minValue", ); } set { this.attributes["minValue"] = value; } }                
                    
                    
        private _nanText_default = '{0} is not a valid number';
                    
                    
        [JsonIgnore]
        public String nanText { get { return this.attributes.GetOrDefault<String>("nanText", '{0} is not a valid number'); } set { this.attributes["nanText"] = value; } }                
                    
                    
        private _negativeText_default = 'The value cannot be negative';
                    
                    
        [JsonIgnore]
        public String negativeText { get { return this.attributes.GetOrDefault<String>("negativeText", 'The value cannot be negative'); } set { this.attributes["negativeText"] = value; } }                
                    
                    
        private _step_default = 1;
                    
                    
        [JsonIgnore]
        public Number step { get { return this.attributes.GetOrDefault<Number>("step", 1); } set { this.attributes["step"] = value; } }                
                    
                    
        private _submitLocaleSeparator_default = true;
                    
                    
        [JsonIgnore]
        public Boolean submitLocaleSeparator { get { return this.attributes.GetOrDefault<Boolean>("submitLocaleSeparator", true); } set { this.attributes["submitLocaleSeparator"] = value; } }                
                    
    }
}
