using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.series.Line : Ext.chart.series.Cartesian {
                    
        private _fill_default = false;
                    
                    
        [JsonIgnore]
        public Boolean fill { get { return this.attributes.GetOrDefault<Boolean>("fill", false); } set { this.attributes["fill"] = value; } }                
                    
                    
        private _markerConfig_default = {};
                    
                    
        [JsonIgnore]
        public Object markerConfig { get { return this.attributes.GetOrDefault<Object>("markerConfig", {}); } set { this.attributes["markerConfig"] = value; } }                
                    
                    
        private _selectionTolerance_default = 20;
                    
                    
        [JsonIgnore]
        public Number selectionTolerance { get { return this.attributes.GetOrDefault<Number>("selectionTolerance", 20); } set { this.attributes["selectionTolerance"] = value; } }                
                    
                    
        private _showMarkers_default = true;
                    
                    
        [JsonIgnore]
        public Boolean showMarkers { get { return this.attributes.GetOrDefault<Boolean>("showMarkers", true); } set { this.attributes["showMarkers"] = value; } }                
                    
                    
        private _smooth_default = false;
                    
                    
        public class MultiType_smooth {
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
        public MultiType_smooth smooth { get { return this.attributes.GetOrDefault<MultiType_smooth>("smooth", false); } set { this.attributes["smooth"] = value; } }                

                    
                    
        private _style_default = {};
                    
                    
        [JsonIgnore]
        public Object style { get { return this.attributes.GetOrDefault<Object>("style", {}); } set { this.attributes["style"] = value; } }                
                    
                    
        private _type_default = 'line';
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", 'line'); } set { this.attributes["type"] = value; } }                
                    
    }
}
