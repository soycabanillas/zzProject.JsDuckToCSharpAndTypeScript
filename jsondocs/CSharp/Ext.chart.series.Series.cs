using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.series.Series : Ext.Base {
                    
        public class MultiType_highlight {
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
        public MultiType_highlight highlight { get { return this.attributes.GetOrDefault<MultiType_highlight>("highlight", ); } set { this.attributes["highlight"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object listeners { get { return this.attributes.GetOrDefault<Object>("listeners", ); } set { this.attributes["listeners"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function renderer { get { return this.attributes.GetOrDefault<Function>("renderer", ); } set { this.attributes["renderer"] = value; } }                
                    
                    
        [JsonIgnore]
        public Array shadowAttributes { get { return this.attributes.GetOrDefault<Array>("shadowAttributes", ); } set { this.attributes["shadowAttributes"] = value; } }                
                    
                    
        private _showInLegend_default = true;
                    
                    
        [JsonIgnore]
        public Boolean showInLegend { get { return this.attributes.GetOrDefault<Boolean>("showInLegend", true); } set { this.attributes["showInLegend"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object tips { get { return this.attributes.GetOrDefault<Object>("tips", ); } set { this.attributes["tips"] = value; } }                
                    
                    
        [JsonIgnore]
        public String title { get { return this.attributes.GetOrDefault<String>("title", ); } set { this.attributes["title"] = value; } }                
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", ); } set { this.attributes["type"] = value; } }                
                    
    }
}
