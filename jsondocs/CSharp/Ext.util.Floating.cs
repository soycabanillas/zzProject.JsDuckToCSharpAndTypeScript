using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.util.Floating : Ext.Base {
                    
        private _constrain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", false); } set { this.attributes["constrain"] = value; } }                
                    
                    
        private _fixed_default = false;
                    
                    
        [JsonIgnore]
        public Boolean fixed { get { return this.attributes.GetOrDefault<Boolean>("fixed", false); } set { this.attributes["fixed"] = value; } }                
                    
                    
        private _focusOnToFront_default = true;
                    
                    
        [JsonIgnore]
        public Boolean focusOnToFront { get { return this.attributes.GetOrDefault<Boolean>("focusOnToFront", true); } set { this.attributes["focusOnToFront"] = value; } }                
                    
                    
        private _shadow_default = 'sides';
                    
                    
        public class MultiType_shadow {
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
        public MultiType_shadow shadow { get { return this.attributes.GetOrDefault<MultiType_shadow>("shadow", 'sides'); } set { this.attributes["shadow"] = value; } }                

                    
                    
        [JsonIgnore]
        public Number shadowOffset { get { return this.attributes.GetOrDefault<Number>("shadowOffset", ); } set { this.attributes["shadowOffset"] = value; } }                
                    
    }
}
