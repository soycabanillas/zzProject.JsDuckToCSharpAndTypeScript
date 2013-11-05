using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.selection.Model : Ext.util.Observable {
                    
        [JsonIgnore]
        public Boolean allowDeselect { get { return this.attributes.GetOrDefault<Boolean>("allowDeselect", ); } set { this.attributes["allowDeselect"] = value; } }                
                    
                    
        public class MultiType_mode {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int ("SINGLE" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "SINGLE" (int m) {
                return new "SINGLE" { _value = m };
            }
                            
                            
            public static explicit operator int ("SIMPLE" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "SIMPLE" (int m) {
                return new "SIMPLE" { _value = m };
            }
                            
                            
            public static explicit operator int ("MULTI" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "MULTI" (int m) {
                return new "MULTI" { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_mode mode { get { return this.attributes.GetOrDefault<MultiType_mode>("mode", ); } set { this.attributes["mode"] = value; } }                

                    
                    
        private _pruneRemoved_default = true;
                    
                    
        [JsonIgnore]
        public Boolean pruneRemoved { get { return this.attributes.GetOrDefault<Boolean>("pruneRemoved", true); } set { this.attributes["pruneRemoved"] = value; } }                
                    
                    
        private _toggleOnClick_default = true;
                    
                    
        [JsonIgnore]
        public Boolean toggleOnClick { get { return this.attributes.GetOrDefault<Boolean>("toggleOnClick", true); } set { this.attributes["toggleOnClick"] = value; } }                
                    
    }
}
