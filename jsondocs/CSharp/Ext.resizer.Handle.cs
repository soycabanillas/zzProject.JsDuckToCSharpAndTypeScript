using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.resizer.Handle : Ext.Component {
                    
        private _region_default = '';
                    
                    
        public class MultiType_region {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int ("north" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "north" (int m) {
                return new "north" { _value = m };
            }
                            
                            
            public static explicit operator int ("south" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "south" (int m) {
                return new "south" { _value = m };
            }
                            
                            
            public static explicit operator int ("east" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "east" (int m) {
                return new "east" { _value = m };
            }
                            
                            
            public static explicit operator int ("west" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "west" (int m) {
                return new "west" { _value = m };
            }
                            
                            
            public static explicit operator int ("center" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "center" (int m) {
                return new "center" { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_region region { get { return this.attributes.GetOrDefault<MultiType_region>("region", ''); } set { this.attributes["region"] = value; } }                

                    
    }
}
