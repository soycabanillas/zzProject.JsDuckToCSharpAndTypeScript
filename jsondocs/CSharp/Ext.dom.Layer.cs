using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.dom.Layer : Ext.Element {
                    
        [JsonIgnore]
        public String cls { get { return this.attributes.GetOrDefault<String>("cls", ); } set { this.attributes["cls"] = value; } }                
                    
                    
        private _constrain_default = true;
                    
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", true); } set { this.attributes["constrain"] = value; } }                
                    
                    
        private _dh_default = {tag: 'div', cls: 'x-layer'};
                    
                    
        [JsonIgnore]
        public Object dh { get { return this.attributes.GetOrDefault<Object>("dh", {tag: 'div', cls: 'x-layer'}); } set { this.attributes["dh"] = value; } }                
                    
                    
        [JsonIgnore]
        public String hideMode { get { return this.attributes.GetOrDefault<String>("hideMode", ); } set { this.attributes["hideMode"] = value; } }                
                    
                    
        private _shadow_default = false;
                    
                    
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
        public MultiType_shadow shadow { get { return this.attributes.GetOrDefault<MultiType_shadow>("shadow", false); } set { this.attributes["shadow"] = value; } }                

                    
                    
        private _shadowOffset_default = 4;
                    
                    
        [JsonIgnore]
        public Number shadowOffset { get { return this.attributes.GetOrDefault<Number>("shadowOffset", 4); } set { this.attributes["shadowOffset"] = value; } }                
                    
                    
        private _shim_default = true;
                    
                    
        [JsonIgnore]
        public Boolean shim { get { return this.attributes.GetOrDefault<Boolean>("shim", true); } set { this.attributes["shim"] = value; } }                
                    
                    
        private _useDisplay_default = false;
                    
                    
        [JsonIgnore]
        public Boolean useDisplay { get { return this.attributes.GetOrDefault<Boolean>("useDisplay", false); } set { this.attributes["useDisplay"] = value; } }                
                    
                    
        [JsonIgnore]
        public String visibilityCls { get { return this.attributes.GetOrDefault<String>("visibilityCls", ); } set { this.attributes["visibilityCls"] = value; } }                
                    
                    
        private _zindex_default = 11000;
                    
                    
        [JsonIgnore]
        public Number zindex { get { return this.attributes.GetOrDefault<Number>("zindex", 11000); } set { this.attributes["zindex"] = value; } }                
                    
    }
}
