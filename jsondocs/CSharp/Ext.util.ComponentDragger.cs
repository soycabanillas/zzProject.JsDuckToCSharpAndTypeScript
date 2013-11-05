using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.ComponentDragger : Ext.dd.DragTracker {
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", ); } set { this.attributes["constrain"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean constrainDelegate { get { return this.attributes.GetOrDefault<Boolean>("constrainDelegate", ); } set { this.attributes["constrainDelegate"] = value; } }                
                    
                    
        public class MultiType_delegate {
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
        public MultiType_delegate delegate { get { return this.attributes.GetOrDefault<MultiType_delegate>("delegate", ); } set { this.attributes["delegate"] = value; } }                

                    
    }
}
