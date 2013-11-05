using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.axis.Axis : Ext.chart.axis.Abstract {
                    
        private _adjustEnd_default = true;
                    
                    
        [JsonIgnore]
        public Boolean adjustEnd { get { return this.attributes.GetOrDefault<Boolean>("adjustEnd", true); } set { this.attributes["adjustEnd"] = value; } }                
                    
                    
        private _dashSize_default = 3;
                    
                    
        [JsonIgnore]
        public Number dashSize { get { return this.attributes.GetOrDefault<Number>("dashSize", 3); } set { this.attributes["dashSize"] = value; } }                
                    
                    
        public class MultiType_grid {
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
        public MultiType_grid grid { get { return this.attributes.GetOrDefault<MultiType_grid>("grid", ); } set { this.attributes["grid"] = value; } }                

                    
                    
        private _hidden_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hidden { get { return this.attributes.GetOrDefault<Boolean>("hidden", false); } set { this.attributes["hidden"] = value; } }                
                    
                    
        private _length_default = 0;
                    
                    
        [JsonIgnore]
        public Number length { get { return this.attributes.GetOrDefault<Number>("length", 0); } set { this.attributes["length"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number majorTickSteps { get { return this.attributes.GetOrDefault<Number>("majorTickSteps", ); } set { this.attributes["majorTickSteps"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minorTickSteps { get { return this.attributes.GetOrDefault<Number>("minorTickSteps", ); } set { this.attributes["minorTickSteps"] = value; } }                
                    
                    
        private _position_default = 'bottom';
                    
                    
        [JsonIgnore]
        public String position { get { return this.attributes.GetOrDefault<String>("position", 'bottom'); } set { this.attributes["position"] = value; } }                
                    
                    
        [JsonIgnore]
        public String title { get { return this.attributes.GetOrDefault<String>("title", ); } set { this.attributes["title"] = value; } }                
                    
                    
        private _width_default = 0;
                    
                    
        [JsonIgnore]
        public Number width { get { return this.attributes.GetOrDefault<Number>("width", 0); } set { this.attributes["width"] = value; } }                
                    
    }
}
