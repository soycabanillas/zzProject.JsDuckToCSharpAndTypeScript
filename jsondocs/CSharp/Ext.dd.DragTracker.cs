using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.dd.DragTracker : Ext.Base {
                    
        private _autoStart_default = false;
                    
                    
        public class MultiType_autoStart {
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
        public MultiType_autoStart autoStart { get { return this.attributes.GetOrDefault<MultiType_autoStart>("autoStart", false); } set { this.attributes["autoStart"] = value; } }                

                    
                    
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

                    
                    
        [JsonIgnore]
        public String delegate { get { return this.attributes.GetOrDefault<String>("delegate", ); } set { this.attributes["delegate"] = value; } }                
                    
                    
        [JsonIgnore]
        public String overCls { get { return this.attributes.GetOrDefault<String>("overCls", ); } set { this.attributes["overCls"] = value; } }                
                    
                    
        private _preventDefault_default = true;
                    
                    
        [JsonIgnore]
        public Boolean preventDefault { get { return this.attributes.GetOrDefault<Boolean>("preventDefault", true); } set { this.attributes["preventDefault"] = value; } }                
                    
                    
        private _stopEvent_default = false;
                    
                    
        [JsonIgnore]
        public Boolean stopEvent { get { return this.attributes.GetOrDefault<Boolean>("stopEvent", false); } set { this.attributes["stopEvent"] = value; } }                
                    
                    
        private _tolerance_default = 5;
                    
                    
        [JsonIgnore]
        public Number tolerance { get { return this.attributes.GetOrDefault<Number>("tolerance", 5); } set { this.attributes["tolerance"] = value; } }                
                    
                    
        private _trackOver_default = false;
                    
                    
        [JsonIgnore]
        public Boolean trackOver { get { return this.attributes.GetOrDefault<Boolean>("trackOver", false); } set { this.attributes["trackOver"] = value; } }                
                    
    }
}
