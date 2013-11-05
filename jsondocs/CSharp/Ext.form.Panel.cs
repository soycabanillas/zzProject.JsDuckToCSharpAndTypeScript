using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.Panel : Ext.panel.Panel {
                    
        private _layout_default = 'anchor';
                    
                    
        public class MultiType_layout {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.enums.Layout m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.enums.Layout (int m) {
                return new Ext.enums.Layout { _value = m };
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", 'anchor'); } set { this.attributes["layout"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean pollForChanges { get { return this.attributes.GetOrDefault<Boolean>("pollForChanges", ); } set { this.attributes["pollForChanges"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number pollInterval { get { return this.attributes.GetOrDefault<Number>("pollInterval", ); } set { this.attributes["pollInterval"] = value; } }                
                    
    }
}
