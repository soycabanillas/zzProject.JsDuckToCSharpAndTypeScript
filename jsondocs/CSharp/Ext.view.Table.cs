using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.view.Table : Ext.view.View {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'grid-view';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'grid-view'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _componentLayout_default = 'tableview';
                    
                    
        public class MultiType_componentLayout {
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'tableview'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean enableTextSelection { get { return this.attributes.GetOrDefault<Boolean>("enableTextSelection", ); } set { this.attributes["enableTextSelection"] = value; } }                
                    
                    
        private _firstCls_default = 'x-grid-cell-first';
                    
                    
        [JsonIgnore]
        public String firstCls { get { return this.attributes.GetOrDefault<String>("firstCls", 'x-grid-cell-first'); } set { this.attributes["firstCls"] = value; } }                
                    
                    
        private _itemSelector_default = 'tr.' + Ext.baseCSSPrefix + 'grid-row';
                    
                    
        [JsonIgnore]
        public String itemSelector { get { return this.attributes.GetOrDefault<String>("itemSelector", 'tr.' + Ext.baseCSSPrefix + 'grid-row'); } set { this.attributes["itemSelector"] = value; } }                
                    
                    
        private _lastCls_default = 'x-grid-cell-last';
                    
                    
        [JsonIgnore]
        public String lastCls { get { return this.attributes.GetOrDefault<String>("lastCls", 'x-grid-cell-last'); } set { this.attributes["lastCls"] = value; } }                
                    
                    
        private _markDirty_default = true;
                    
                    
        [JsonIgnore]
        public Boolean markDirty { get { return this.attributes.GetOrDefault<Boolean>("markDirty", true); } set { this.attributes["markDirty"] = value; } }                
                    
                    
        private _overItemCls_default = Ext.baseCSSPrefix + 'grid-row-over';
                    
                    
        [JsonIgnore]
        public String overItemCls { get { return this.attributes.GetOrDefault<String>("overItemCls", Ext.baseCSSPrefix + 'grid-row-over'); } set { this.attributes["overItemCls"] = value; } }                
                    
                    
        private _selectedItemCls_default = Ext.baseCSSPrefix + 'grid-row-selected';
                    
                    
        [JsonIgnore]
        public String selectedItemCls { get { return this.attributes.GetOrDefault<String>("selectedItemCls", Ext.baseCSSPrefix + 'grid-row-selected'); } set { this.attributes["selectedItemCls"] = value; } }                
                    
                    
        private _stripeRows_default = true;
                    
                    
        [JsonIgnore]
        public Boolean stripeRows { get { return this.attributes.GetOrDefault<Boolean>("stripeRows", true); } set { this.attributes["stripeRows"] = value; } }                
                    
                    
        private _trackOver_default = true;
                    
                    
        [JsonIgnore]
        public Boolean trackOver { get { return this.attributes.GetOrDefault<Boolean>("trackOver", true); } set { this.attributes["trackOver"] = value; } }                
                    
    }
}
