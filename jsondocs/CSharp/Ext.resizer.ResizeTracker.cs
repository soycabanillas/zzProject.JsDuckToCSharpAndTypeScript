using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.resizer.ResizeTracker : Ext.dd.DragTracker {
                    
        public class MultiType_constrainTo {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.util.Region m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.util.Region (int m) {
                return new Ext.util.Region { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.Element m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Element (int m) {
                return new Ext.Element { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_constrainTo constrainTo { get { return this.attributes.GetOrDefault<MultiType_constrainTo>("constrainTo", ); } set { this.attributes["constrainTo"] = value; } }                

                    
    }
}
