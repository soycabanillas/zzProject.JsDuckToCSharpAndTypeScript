using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.layout.container.HBox : Ext.layout.container.Box {
                    
        private _align_default = 'top';
                    
                    
        [JsonIgnore]
        public String align { get { return this.attributes.GetOrDefault<String>("align", 'top'); } set { this.attributes["align"] = value; } }                
                    
                    
        private _alignRoundingMethod_default = 'round';
                    
                    
        public class MultiType_alignRoundingMethod {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int ("round" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "round" (int m) {
                return new "round" { _value = m };
            }
                            
                            
            public static explicit operator int ("floor" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "floor" (int m) {
                return new "floor" { _value = m };
            }
                            
                            
            public static explicit operator int ("ceil" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "ceil" (int m) {
                return new "ceil" { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_alignRoundingMethod alignRoundingMethod { get { return this.attributes.GetOrDefault<MultiType_alignRoundingMethod>("alignRoundingMethod", 'round'); } set { this.attributes["alignRoundingMethod"] = value; } }                

                    
                    
        private _constrainAlign_default = false;
                    
                    
        [JsonIgnore]
        public Boolean constrainAlign { get { return this.attributes.GetOrDefault<Boolean>("constrainAlign", false); } set { this.attributes["constrainAlign"] = value; } }                
                    
    }
}
