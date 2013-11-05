using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.slider.Multi : Ext.form.field.Base {
                    
        private _animate_default = true;
                    
                    
        [JsonIgnore]
        public Boolean animate { get { return this.attributes.GetOrDefault<Boolean>("animate", true); } set { this.attributes["animate"] = value; } }                
                    
                    
        private _clickToChange_default = true;
                    
                    
        [JsonIgnore]
        public Boolean clickToChange { get { return this.attributes.GetOrDefault<Boolean>("clickToChange", true); } set { this.attributes["clickToChange"] = value; } }                
                    
                    
        private _componentLayout_default = 'sliderfield';
                    
                    
        public class MultiType_componentLayout {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'sliderfield'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _constrainThumbs_default = true;
                    
                    
        [JsonIgnore]
        public Boolean constrainThumbs { get { return this.attributes.GetOrDefault<Boolean>("constrainThumbs", true); } set { this.attributes["constrainThumbs"] = value; } }                
                    
                    
        private _decimalPrecision_default = 0;
                    
                    
        public class MultiType_decimalPrecision {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            
                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_decimalPrecision decimalPrecision { get { return this.attributes.GetOrDefault<MultiType_decimalPrecision>("decimalPrecision", 0); } set { this.attributes["decimalPrecision"] = value; } }                

                    
                    
        private _increment_default = 0;
                    
                    
        [JsonIgnore]
        public Number increment { get { return this.attributes.GetOrDefault<Number>("increment", 0); } set { this.attributes["increment"] = value; } }                
                    
                    
        private _keyIncrement_default = 1;
                    
                    
        [JsonIgnore]
        public Number keyIncrement { get { return this.attributes.GetOrDefault<Number>("keyIncrement", 1); } set { this.attributes["keyIncrement"] = value; } }                
                    
                    
        private _maxValue_default = 100;
                    
                    
        [JsonIgnore]
        public Number maxValue { get { return this.attributes.GetOrDefault<Number>("maxValue", 100); } set { this.attributes["maxValue"] = value; } }                
                    
                    
        private _minValue_default = 0;
                    
                    
        [JsonIgnore]
        public Number minValue { get { return this.attributes.GetOrDefault<Number>("minValue", 0); } set { this.attributes["minValue"] = value; } }                
                    
                    
        private _tipText_default = undefined;
                    
                    
        [JsonIgnore]
        public Function tipText { get { return this.attributes.GetOrDefault<Function>("tipText", undefined); } set { this.attributes["tipText"] = value; } }                
                    
                    
        private _useTips_default = true;
                    
                    
        public class MultiType_useTips {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
            }
                            
                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_useTips useTips { get { return this.attributes.GetOrDefault<MultiType_useTips>("useTips", true); } set { this.attributes["useTips"] = value; } }                

                    
                    
        [JsonIgnore]
        public Number value { get { return this.attributes.GetOrDefault<Number>("value", ); } set { this.attributes["value"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number[] values { get { return this.attributes.GetOrDefault<Number[]>("values", ); } set { this.attributes["values"] = value; } }                
                    
                    
        private _vertical_default = false;
                    
                    
        [JsonIgnore]
        public Boolean vertical { get { return this.attributes.GetOrDefault<Boolean>("vertical", false); } set { this.attributes["vertical"] = value; } }                
                    
                    
        private _zeroBasedSnapping_default = false;
                    
                    
        [JsonIgnore]
        public Boolean zeroBasedSnapping { get { return this.attributes.GetOrDefault<Boolean>("zeroBasedSnapping", false); } set { this.attributes["zeroBasedSnapping"] = value; } }                
                    
    }
}
