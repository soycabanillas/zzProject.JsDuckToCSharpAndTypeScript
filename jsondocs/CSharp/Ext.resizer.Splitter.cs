using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.resizer.Splitter : Ext.Component {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'splitter';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'splitter'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _collapseOnDblClick_default = true;
                    
                    
        [JsonIgnore]
        public Boolean collapseOnDblClick { get { return this.attributes.GetOrDefault<Boolean>("collapseOnDblClick", true); } set { this.attributes["collapseOnDblClick"] = value; } }                
                    
                    
        private _collapseTarget_default = 'next';
                    
                    
        public class MultiType_collapseTarget {
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
                            
                            
            public static explicit operator int (Ext.panel.Panel m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.panel.Panel (int m) {
                return new Ext.panel.Panel { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_collapseTarget collapseTarget { get { return this.attributes.GetOrDefault<MultiType_collapseTarget>("collapseTarget", 'next'); } set { this.attributes["collapseTarget"] = value; } }                

                    
                    
        [JsonIgnore]
        public String collapsedCls { get { return this.attributes.GetOrDefault<String>("collapsedCls", ); } set { this.attributes["collapsedCls"] = value; } }                
                    
                    
        private _collapsible_default = false;
                    
                    
        [JsonIgnore]
        public Boolean collapsible { get { return this.attributes.GetOrDefault<Boolean>("collapsible", false); } set { this.attributes["collapsible"] = value; } }                
                    
                    
        private _defaultSplitMax_default = 1000;
                    
                    
        [JsonIgnore]
        public Number defaultSplitMax { get { return this.attributes.GetOrDefault<Number>("defaultSplitMax", 1000); } set { this.attributes["defaultSplitMax"] = value; } }                
                    
                    
        private _defaultSplitMin_default = 40;
                    
                    
        [JsonIgnore]
        public Number defaultSplitMin { get { return this.attributes.GetOrDefault<Number>("defaultSplitMin", 40); } set { this.attributes["defaultSplitMin"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean performCollapse { get { return this.attributes.GetOrDefault<Boolean>("performCollapse", ); } set { this.attributes["performCollapse"] = value; } }                
                    
                    
        private _renderTpl_default = ['<tpl if="collapsible===true">', '<div id="{id}-collapseEl" class="', Ext.baseCSSPrefix, 'collapse-el ', Ext.baseCSSPrefix, 'layout-split-{collapseDir}{childElCls}">&#160;', '</div>', '</tpl>'];
                    
                    
        public class MultiType_renderTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            
                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (String[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String[] (int m) {
                return new String[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<tpl if="collapsible===true">', '<div id="{id}-collapseEl" class="', Ext.baseCSSPrefix, 'collapse-el ', Ext.baseCSSPrefix, 'layout-split-{collapseDir}{childElCls}">&#160;', '</div>', '</tpl>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        private _size_default = 5;
                    
                    
        [JsonIgnore]
        public Number size { get { return this.attributes.GetOrDefault<Number>("size", 5); } set { this.attributes["size"] = value; } }                
                    
    }
}
