using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.Sortable : Ext.Base {
                    
        private _defaultSortDirection_default = "ASC";
                    
                    
        [JsonIgnore]
        public String defaultSortDirection { get { return this.attributes.GetOrDefault<String>("defaultSortDirection", "ASC"); } set { this.attributes["defaultSortDirection"] = value; } }                
                    
                    
        [JsonIgnore]
        public String sortRoot { get { return this.attributes.GetOrDefault<String>("sortRoot", ); } set { this.attributes["sortRoot"] = value; } }                
                    
                    
        public class MultiType_sorters {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.util.Sorter[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.util.Sorter[] (int m) {
                return new Ext.util.Sorter[] { _value = m };
            }
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_sorters sorters { get { return this.attributes.GetOrDefault<MultiType_sorters>("sorters", ); } set { this.attributes["sorters"] = value; } }                

                    
    }
}
