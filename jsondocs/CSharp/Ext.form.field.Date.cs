using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Date : Ext.form.field.Picker {
                    
        private _altFormats_default = "m/d/Y|n/j/Y|n/j/y|m/j/y|n/d/y|m/j/Y|n/d/Y|m-d-y|m-d-Y|m/d|m-d|md|mdy|mdY|d|Y-m-d|n-j|n/j";
                    
                    
        [JsonIgnore]
        public String altFormats { get { return this.attributes.GetOrDefault<String>("altFormats", "m/d/Y|n/j/Y|n/j/y|m/j/y|n/d/y|m/j/Y|n/d/Y|m-d-y|m-d-Y|m/d|m-d|md|mdy|mdY|d|Y-m-d|n-j|n/j"); } set { this.attributes["altFormats"] = value; } }                
                    
                    
        [JsonIgnore]
        public String[] disabledDates { get { return this.attributes.GetOrDefault<String[]>("disabledDates", ); } set { this.attributes["disabledDates"] = value; } }                
                    
                    
        private _disabledDatesText_default = "Disabled";
                    
                    
        [JsonIgnore]
        public String disabledDatesText { get { return this.attributes.GetOrDefault<String>("disabledDatesText", "Disabled"); } set { this.attributes["disabledDatesText"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number[] disabledDays { get { return this.attributes.GetOrDefault<Number[]>("disabledDays", ); } set { this.attributes["disabledDays"] = value; } }                
                    
                    
        private _disabledDaysText_default = "Disabled";
                    
                    
        [JsonIgnore]
        public String disabledDaysText { get { return this.attributes.GetOrDefault<String>("disabledDaysText", "Disabled"); } set { this.attributes["disabledDaysText"] = value; } }                
                    
                    
        private _format_default = "m/d/Y";
                    
                    
        [JsonIgnore]
        public String format { get { return this.attributes.GetOrDefault<String>("format", "m/d/Y"); } set { this.attributes["format"] = value; } }                
                    
                    
        private _invalidText_default = "{0} is not a valid date - it must be in the format {1}";
                    
                    
        [JsonIgnore]
        public String invalidText { get { return this.attributes.GetOrDefault<String>("invalidText", "{0} is not a valid date - it must be in the format {1}"); } set { this.attributes["invalidText"] = value; } }                
                    
                    
        private _matchFieldWidth_default = false;
                    
                    
        [JsonIgnore]
        public Boolean matchFieldWidth { get { return this.attributes.GetOrDefault<Boolean>("matchFieldWidth", false); } set { this.attributes["matchFieldWidth"] = value; } }                
                    
                    
        private _maxText_default = "The date in this field must be equal to or before {0}";
                    
                    
        [JsonIgnore]
        public String maxText { get { return this.attributes.GetOrDefault<String>("maxText", "The date in this field must be equal to or before {0}"); } set { this.attributes["maxText"] = value; } }                
                    
                    
        public class MultiType_maxValue {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (DateTime m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator DateTime (int m) {
                return new DateTime { _value = m };
            }
                            
                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_maxValue maxValue { get { return this.attributes.GetOrDefault<MultiType_maxValue>("maxValue", ); } set { this.attributes["maxValue"] = value; } }                

                    
                    
        private _minText_default = "The date in this field must be equal to or after {0}";
                    
                    
        [JsonIgnore]
        public String minText { get { return this.attributes.GetOrDefault<String>("minText", "The date in this field must be equal to or after {0}"); } set { this.attributes["minText"] = value; } }                
                    
                    
        public class MultiType_minValue {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (DateTime m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator DateTime (int m) {
                return new DateTime { _value = m };
            }
                            
                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_minValue minValue { get { return this.attributes.GetOrDefault<MultiType_minValue>("minValue", ); } set { this.attributes["minValue"] = value; } }                

                    
                    
        private _showToday_default = true;
                    
                    
        [JsonIgnore]
        public Boolean showToday { get { return this.attributes.GetOrDefault<Boolean>("showToday", true); } set { this.attributes["showToday"] = value; } }                
                    
                    
        private _startDay_default = undefined;
                    
                    
        [JsonIgnore]
        public Number startDay { get { return this.attributes.GetOrDefault<Number>("startDay", undefined); } set { this.attributes["startDay"] = value; } }                
                    
                    
        [JsonIgnore]
        public String submitFormat { get { return this.attributes.GetOrDefault<String>("submitFormat", ); } set { this.attributes["submitFormat"] = value; } }                
                    
                    
        private _triggerCls_default = 'x-form-date-trigger';
                    
                    
        [JsonIgnore]
        public String triggerCls { get { return this.attributes.GetOrDefault<String>("triggerCls", 'x-form-date-trigger'); } set { this.attributes["triggerCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean useStrict { get { return this.attributes.GetOrDefault<Boolean>("useStrict", ); } set { this.attributes["useStrict"] = value; } }                
                    
    }
}
