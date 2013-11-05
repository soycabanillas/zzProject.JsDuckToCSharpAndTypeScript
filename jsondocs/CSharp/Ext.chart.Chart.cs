using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.Chart : Ext.draw.Component {
                    
        private _animate_default = false;
                    
                    
        public class MultiType_animate {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
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
        public MultiType_animate animate { get { return this.attributes.GetOrDefault<MultiType_animate>("animate", false); } set { this.attributes["animate"] = value; } }                

                    
                    
        [JsonIgnore]
        public Ext.chart.axis.Axis[] axes { get { return this.attributes.GetOrDefault<Ext.chart.axis.Axis[]>("axes", ); } set { this.attributes["axes"] = value; } }                
                    
                    
        private _background_default = false;
                    
                    
        public class MultiType_background {
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
        public MultiType_background background { get { return this.attributes.GetOrDefault<MultiType_background>("background", false); } set { this.attributes["background"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object[] gradients { get { return this.attributes.GetOrDefault<Object[]>("gradients", ); } set { this.attributes["gradients"] = value; } }                
                    
                    
        private _insetPadding_default = 10;
                    
                    
        [JsonIgnore]
        public Number insetPadding { get { return this.attributes.GetOrDefault<Number>("insetPadding", 10); } set { this.attributes["insetPadding"] = value; } }                
                    
                    
        private _legend_default = false;
                    
                    
        public class MultiType_legend {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
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
        public MultiType_legend legend { get { return this.attributes.GetOrDefault<MultiType_legend>("legend", false); } set { this.attributes["legend"] = value; } }                

                    
                    
        [JsonIgnore]
        public Ext.chart.series.Series[] series { get { return this.attributes.GetOrDefault<Ext.chart.series.Series[]>("series", ); } set { this.attributes["series"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.Store store { get { return this.attributes.GetOrDefault<Ext.data.Store>("store", ); } set { this.attributes["store"] = value; } }                
                    
                    
        [JsonIgnore]
        public String theme { get { return this.attributes.GetOrDefault<String>("theme", ); } set { this.attributes["theme"] = value; } }                
                    
    }
}
