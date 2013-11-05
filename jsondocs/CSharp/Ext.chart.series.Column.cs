using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.series.Column : Ext.chart.series.Bar {
                    
        [JsonIgnore]
        public String axis { get { return this.attributes.GetOrDefault<String>("axis", ); } set { this.attributes["axis"] = value; } }                
                    
                    
        private _column_default = true;
                    
                    
        [JsonIgnore]
        public Boolean column { get { return this.attributes.GetOrDefault<Boolean>("column", true); } set { this.attributes["column"] = value; } }                
                    
                    
        private _type_default = 'column';
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", 'column'); } set { this.attributes["type"] = value; } }                
                    
                    
        private _xPadding_default = 10;
                    
                    
        public class MultiType_xPadding {
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
        public MultiType_xPadding xPadding { get { return this.attributes.GetOrDefault<MultiType_xPadding>("xPadding", 10); } set { this.attributes["xPadding"] = value; } }                

                    
                    
        private _yPadding_default = 0;
                    
                    
        public class MultiType_yPadding {
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
        public MultiType_yPadding yPadding { get { return this.attributes.GetOrDefault<MultiType_yPadding>("yPadding", 0); } set { this.attributes["yPadding"] = value; } }                

                    
    }
}
