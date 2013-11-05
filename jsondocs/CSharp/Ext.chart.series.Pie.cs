using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.series.Pie : Ext.chart.series.Series {
                    
        private _angleField_default = false;
                    
                    
        [JsonIgnore]
        public String angleField { get { return this.attributes.GetOrDefault<String>("angleField", false); } set { this.attributes["angleField"] = value; } }                
                    
                    
        [JsonIgnore]
        public Array colorSet { get { return this.attributes.GetOrDefault<Array>("colorSet", ); } set { this.attributes["colorSet"] = value; } }                
                    
                    
        private _donut_default = false;
                    
                    
        public class MultiType_donut {
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
                            
                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_donut donut { get { return this.attributes.GetOrDefault<MultiType_donut>("donut", false); } set { this.attributes["donut"] = value; } }                

                    
                    
        [JsonIgnore]
        public String field { get { return this.attributes.GetOrDefault<String>("field", ); } set { this.attributes["field"] = value; } }                
                    
                    
        private _highlightDuration_default = 150;
                    
                    
        [JsonIgnore]
        public Number highlightDuration { get { return this.attributes.GetOrDefault<Number>("highlightDuration", 150); } set { this.attributes["highlightDuration"] = value; } }                
                    
                    
        private _lengthField_default = false;
                    
                    
        [JsonIgnore]
        public String lengthField { get { return this.attributes.GetOrDefault<String>("lengthField", false); } set { this.attributes["lengthField"] = value; } }                
                    
                    
        private _showInLegend_default = false;
                    
                    
        [JsonIgnore]
        public Boolean showInLegend { get { return this.attributes.GetOrDefault<Boolean>("showInLegend", false); } set { this.attributes["showInLegend"] = value; } }                
                    
                    
        private _style_default = {};
                    
                    
        [JsonIgnore]
        public Object style { get { return this.attributes.GetOrDefault<Object>("style", {}); } set { this.attributes["style"] = value; } }                
                    
                    
        private _type_default = "pie";
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", "pie"); } set { this.attributes["type"] = value; } }                
                    
                    
        [JsonIgnore]
        public String xField { get { return this.attributes.GetOrDefault<String>("xField", ); } set { this.attributes["xField"] = value; } }                
                    
    }
}
