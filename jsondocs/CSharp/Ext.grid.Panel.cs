using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.Panel : Ext.panel.Table {
                    
        public class MultiType_columns {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.grid.column.Column[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.grid.column.Column[] (int m) {
                return new Ext.grid.column.Column[] { _value = m };
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
        public MultiType_columns columns { get { return this.attributes.GetOrDefault<MultiType_columns>("columns", ); } set { this.attributes["columns"] = value; } }                

                    
                    
        private _rowLines_default = true;
                    
                    
        [JsonIgnore]
        public Boolean rowLines { get { return this.attributes.GetOrDefault<Boolean>("rowLines", true); } set { this.attributes["rowLines"] = value; } }                
                    
                    
        private _viewType_default = 'gridview';
                    
                    
        [JsonIgnore]
        public String viewType { get { return this.attributes.GetOrDefault<String>("viewType", 'gridview'); } set { this.attributes["viewType"] = value; } }                
                    
    }
}
