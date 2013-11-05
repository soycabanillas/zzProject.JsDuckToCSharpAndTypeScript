using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.resizer.BorderSplitter : Ext.resizer.Splitter {
                    
        private _collapseTarget_default = 'next';
                    
                    
        public class MultiType_collapseTarget {
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
                            
                            
            public static explicit operator int (Ext.panel.Panel m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.panel.Panel (int m) {
                return new Ext.panel.Panel { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_collapseTarget collapseTarget { get { return this.attributes.GetOrDefault<MultiType_collapseTarget>("collapseTarget", 'next'); } set { this.attributes["collapseTarget"] = value; } }                

                    
    }
}
