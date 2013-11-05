using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.toolbar.Toolbar : Ext.container.Container {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'toolbar';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'toolbar'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String defaultButtonUI { get { return this.attributes.GetOrDefault<String>("defaultButtonUI", ); } set { this.attributes["defaultButtonUI"] = value; } }                
                    
                    
        private _defaultType_default = 'button';
                    
                    
        [JsonIgnore]
        public String defaultType { get { return this.attributes.GetOrDefault<String>("defaultType", 'button'); } set { this.attributes["defaultType"] = value; } }                
                    
                    
        private _enableOverflow_default = false;
                    
                    
        [JsonIgnore]
        public Boolean enableOverflow { get { return this.attributes.GetOrDefault<Boolean>("enableOverflow", false); } set { this.attributes["enableOverflow"] = value; } }                
                    
                    
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", ); } set { this.attributes["layout"] = value; } }                

                    
                    
        private _menuTriggerCls_default = Ext.baseCSSPrefix + 'toolbar-more-icon';
                    
                    
        [JsonIgnore]
        public String menuTriggerCls { get { return this.attributes.GetOrDefault<String>("menuTriggerCls", Ext.baseCSSPrefix + 'toolbar-more-icon'); } set { this.attributes["menuTriggerCls"] = value; } }                
                    
                    
        private _vertical_default = false;
                    
                    
        [JsonIgnore]
        public Boolean vertical { get { return this.attributes.GetOrDefault<Boolean>("vertical", false); } set { this.attributes["vertical"] = value; } }                
                    
    }
}
