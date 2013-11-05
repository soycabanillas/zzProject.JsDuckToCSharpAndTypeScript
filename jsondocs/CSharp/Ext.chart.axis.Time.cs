using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.chart.axis.Time : Ext.chart.axis.Numeric {
                    
        private _constrain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", false); } set { this.attributes["constrain"] = value; } }                
                    
                    
        private _dateFormat_default = false;
                    
                    
        public class MultiType_dateFormat {
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
        public MultiType_dateFormat dateFormat { get { return this.attributes.GetOrDefault<MultiType_dateFormat>("dateFormat", false); } set { this.attributes["dateFormat"] = value; } }                

                    
                    
        private _fromDate_default = false;
                    
                    
        [JsonIgnore]
        public Date fromDate { get { return this.attributes.GetOrDefault<Date>("fromDate", false); } set { this.attributes["fromDate"] = value; } }                
                    
                    
        [JsonIgnore]
        public Array step { get { return this.attributes.GetOrDefault<Array>("step", ); } set { this.attributes["step"] = value; } }                
                    
                    
        private _toDate_default = false;
                    
                    
        [JsonIgnore]
        public Date toDate { get { return this.attributes.GetOrDefault<Date>("toDate", false); } set { this.attributes["toDate"] = value; } }                
                    
    }
}
