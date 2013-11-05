using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Time : Ext.form.field.ComboBox {
                    
        private _altFormats_default = "g:ia|g:iA|g:i a|g:i A|h:i|g:i|H:i|ga|ha|gA|h a|g a|g A|gi|hi|gia|hia|g|H|gi a|hi a|giA|hiA|gi A|hi A";
                    
                    
        [JsonIgnore]
        public String altFormats { get { return this.attributes.GetOrDefault<String>("altFormats", "g:ia|g:iA|g:i a|g:i A|h:i|g:i|H:i|ga|ha|gA|h a|g a|g A|gi|hi|gia|hia|g|H|gi a|hi a|giA|hiA|gi A|hi A"); } set { this.attributes["altFormats"] = value; } }                
                    
                    
        private _displayField_default = 'disp';
                    
                    
        [JsonIgnore]
        public String displayField { get { return this.attributes.GetOrDefault<String>("displayField", 'disp'); } set { this.attributes["displayField"] = value; } }                
                    
                    
        private _format_default = undefined;
                    
                    
        [JsonIgnore]
        public String format { get { return this.attributes.GetOrDefault<String>("format", undefined); } set { this.attributes["format"] = value; } }                
                    
                    
        private _increment_default = 15;
                    
                    
        [JsonIgnore]
        public Number increment { get { return this.attributes.GetOrDefault<Number>("increment", 15); } set { this.attributes["increment"] = value; } }                
                    
                    
        private _invalidText_default = "{0} is not a valid time";
                    
                    
        [JsonIgnore]
        public String invalidText { get { return this.attributes.GetOrDefault<String>("invalidText", "{0} is not a valid time"); } set { this.attributes["invalidText"] = value; } }                
                    
                    
        private _maxText_default = "The time in this field must be equal to or before {0}";
                    
                    
        [JsonIgnore]
        public String maxText { get { return this.attributes.GetOrDefault<String>("maxText", "The time in this field must be equal to or before {0}"); } set { this.attributes["maxText"] = value; } }                
                    
                    
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

                    
                    
        private _minText_default = "The time in this field must be equal to or after {0}";
                    
                    
        [JsonIgnore]
        public String minText { get { return this.attributes.GetOrDefault<String>("minText", "The time in this field must be equal to or after {0}"); } set { this.attributes["minText"] = value; } }                
                    
                    
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

                    
                    
        private _pickerMaxHeight_default = 300;
                    
                    
        [JsonIgnore]
        public Number pickerMaxHeight { get { return this.attributes.GetOrDefault<Number>("pickerMaxHeight", 300); } set { this.attributes["pickerMaxHeight"] = value; } }                
                    
                    
        private _queryMode_default = 'local';
                    
                    
        [JsonIgnore]
        public String queryMode { get { return this.attributes.GetOrDefault<String>("queryMode", 'local'); } set { this.attributes["queryMode"] = value; } }                
                    
                    
        private _selectOnTab_default = true;
                    
                    
        [JsonIgnore]
        public Boolean selectOnTab { get { return this.attributes.GetOrDefault<Boolean>("selectOnTab", true); } set { this.attributes["selectOnTab"] = value; } }                
                    
                    
        private _snapToIncrement_default = false;
                    
                    
        [JsonIgnore]
        public Boolean snapToIncrement { get { return this.attributes.GetOrDefault<Boolean>("snapToIncrement", false); } set { this.attributes["snapToIncrement"] = value; } }                
                    
                    
        private _submitFormat_default = undefined;
                    
                    
        [JsonIgnore]
        public String submitFormat { get { return this.attributes.GetOrDefault<String>("submitFormat", undefined); } set { this.attributes["submitFormat"] = value; } }                
                    
                    
        private _triggerCls_default = 'x-form-time-trigger';
                    
                    
        [JsonIgnore]
        public String triggerCls { get { return this.attributes.GetOrDefault<String>("triggerCls", 'x-form-time-trigger'); } set { this.attributes["triggerCls"] = value; } }                
                    
                    
        private _valueField_default = 'date';
                    
                    
        [JsonIgnore]
        public String valueField { get { return this.attributes.GetOrDefault<String>("valueField", 'date'); } set { this.attributes["valueField"] = value; } }                
                    
    }
}
