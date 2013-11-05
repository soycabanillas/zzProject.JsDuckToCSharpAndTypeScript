using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tab.Tab : Ext.button.Button {
                    
        private _activeCls_default = 'active';
                    
                    
        [JsonIgnore]
        public String activeCls { get { return this.attributes.GetOrDefault<String>("activeCls", 'active'); } set { this.attributes["activeCls"] = value; } }                
                    
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'tab';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'tab'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _closable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean closable { get { return this.attributes.GetOrDefault<Boolean>("closable", true); } set { this.attributes["closable"] = value; } }                
                    
                    
        private _closableCls_default = 'closable';
                    
                    
        [JsonIgnore]
        public String closableCls { get { return this.attributes.GetOrDefault<String>("closableCls", 'closable'); } set { this.attributes["closableCls"] = value; } }                
                    
                    
        private _closeText_default = 'Close Tab';
                    
                    
        [JsonIgnore]
        public String closeText { get { return this.attributes.GetOrDefault<String>("closeText", 'Close Tab'); } set { this.attributes["closeText"] = value; } }                
                    
                    
        private _disabledCls_default = 'x-tab-disabled';
                    
                    
        [JsonIgnore]
        public String disabledCls { get { return this.attributes.GetOrDefault<String>("disabledCls", 'x-tab-disabled'); } set { this.attributes["disabledCls"] = value; } }                
                    
                    
        private _scale_default = false;
                    
                    
        public class MultiType_scale {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int ("small" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "small" (int m) {
                return new "small" { _value = m };
            }
                            
                            
            public static explicit operator int ("medium" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "medium" (int m) {
                return new "medium" { _value = m };
            }
                            
                            
            public static explicit operator int ("large" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "large" (int m) {
                return new "large" { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_scale scale { get { return this.attributes.GetOrDefault<MultiType_scale>("scale", false); } set { this.attributes["scale"] = value; } }                

                    
    }
}
