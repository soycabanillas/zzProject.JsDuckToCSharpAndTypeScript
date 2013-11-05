using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.fx.Anim : Ext.Base {
                    
        private _alternate_default = false;
                    
                    
        [JsonIgnore]
        public Boolean alternate { get { return this.attributes.GetOrDefault<Boolean>("alternate", false); } set { this.attributes["alternate"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function callback { get { return this.attributes.GetOrDefault<Function>("callback", ); } set { this.attributes["callback"] = value; } }                
                    
                    
        private _delay_default = 0;
                    
                    
        [JsonIgnore]
        public Number delay { get { return this.attributes.GetOrDefault<Number>("delay", 0); } set { this.attributes["delay"] = value; } }                
                    
                    
        private _duration_default = 250;
                    
                    
        [JsonIgnore]
        public Number duration { get { return this.attributes.GetOrDefault<Number>("duration", 250); } set { this.attributes["duration"] = value; } }                
                    
                    
        private _dynamic_default = false;
                    
                    
        [JsonIgnore]
        public Boolean dynamic { get { return this.attributes.GetOrDefault<Boolean>("dynamic", false); } set { this.attributes["dynamic"] = value; } }                
                    
                    
        private _easing_default = 'ease';
                    
                    
        [JsonIgnore]
        public String easing { get { return this.attributes.GetOrDefault<String>("easing", 'ease'); } set { this.attributes["easing"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object from { get { return this.attributes.GetOrDefault<Object>("from", ); } set { this.attributes["from"] = value; } }                
                    
                    
        private _iterations_default = 1;
                    
                    
        [JsonIgnore]
        public Number iterations { get { return this.attributes.GetOrDefault<Number>("iterations", 1); } set { this.attributes["iterations"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object keyframes { get { return this.attributes.GetOrDefault<Object>("keyframes", ); } set { this.attributes["keyframes"] = value; } }                
                    
                    
        private _reverse_default = false;
                    
                    
        [JsonIgnore]
        public Boolean reverse { get { return this.attributes.GetOrDefault<Boolean>("reverse", false); } set { this.attributes["reverse"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function scope { get { return this.attributes.GetOrDefault<Function>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        public class MultiType_target {
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
        public MultiType_target target { get { return this.attributes.GetOrDefault<MultiType_target>("target", ); } set { this.attributes["target"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object to { get { return this.attributes.GetOrDefault<Object>("to", ); } set { this.attributes["to"] = value; } }                
                    
    }
}
