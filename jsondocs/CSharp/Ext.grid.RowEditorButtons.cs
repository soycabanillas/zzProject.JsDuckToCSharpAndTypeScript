using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.RowEditorButtons : Ext.container.Container {
                    
        private _frame_default = true;
                    
                    
        [JsonIgnore]
        public Boolean frame { get { return this.attributes.GetOrDefault<Boolean>("frame", true); } set { this.attributes["frame"] = value; } }                
                    
                    
        private _shrinkWrap_default = true;
                    
                    
        public class MultiType_shrinkWrap {
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
        public MultiType_shrinkWrap shrinkWrap { get { return this.attributes.GetOrDefault<MultiType_shrinkWrap>("shrinkWrap", true); } set { this.attributes["shrinkWrap"] = value; } }                

                    
    }
}
