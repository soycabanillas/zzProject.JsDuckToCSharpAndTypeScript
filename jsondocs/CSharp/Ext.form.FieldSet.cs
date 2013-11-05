using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.FieldSet : Ext.container.Container {
                    
        private _autoEl_default = 'fieldset';
                    
                    
        public class MultiType_autoEl {
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
        public MultiType_autoEl autoEl { get { return this.attributes.GetOrDefault<MultiType_autoEl>("autoEl", 'fieldset'); } set { this.attributes["autoEl"] = value; } }                

                    
                    
        private _baseCls_default = 'x-fieldset';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", 'x-fieldset'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String checkboxName { get { return this.attributes.GetOrDefault<String>("checkboxName", ); } set { this.attributes["checkboxName"] = value; } }                
                    
                    
        private _checkboxToggle_default = false;
                    
                    
        [JsonIgnore]
        public Boolean checkboxToggle { get { return this.attributes.GetOrDefault<Boolean>("checkboxToggle", false); } set { this.attributes["checkboxToggle"] = value; } }                
                    
                    
        private _collapsed_default = false;
                    
                    
        [JsonIgnore]
        public Boolean collapsed { get { return this.attributes.GetOrDefault<Boolean>("collapsed", false); } set { this.attributes["collapsed"] = value; } }                
                    
                    
        private _collapsible_default = false;
                    
                    
        [JsonIgnore]
        public Boolean collapsible { get { return this.attributes.GetOrDefault<Boolean>("collapsible", false); } set { this.attributes["collapsible"] = value; } }                
                    
                    
        private _componentLayout_default = 'fieldset';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'fieldset'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _layout_default = 'anchor';
                    
                    
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", 'anchor'); } set { this.attributes["layout"] = value; } }                

                    
                    
        private _renderTpl_default = ['{%this.renderLegend(out,values);%}', '<div id="{id}-body" class="{baseCls}-body {bodyTargetCls}"<tpl if="bodyStyle"> style="{bodyStyle}"</tpl>>', '{%this.renderContainer(out,values);%}', '</div>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['{%this.renderLegend(out,values);%}', '<div id="{id}-body" class="{baseCls}-body {bodyTargetCls}"<tpl if="bodyStyle"> style="{bodyStyle}"</tpl>>', '{%this.renderContainer(out,values);%}', '</div>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        private _stateEvents_default = ['collapse', 'expand'];
                    
                    
        [JsonIgnore]
        public String[] stateEvents { get { return this.attributes.GetOrDefault<String[]>("stateEvents", ['collapse', 'expand']); } set { this.attributes["stateEvents"] = value; } }                
                    
                    
        [JsonIgnore]
        public String title { get { return this.attributes.GetOrDefault<String>("title", ); } set { this.attributes["title"] = value; } }                
                    
                    
        private _toggleOnTitleClick_default = true;
                    
                    
        [JsonIgnore]
        public Boolean toggleOnTitleClick { get { return this.attributes.GetOrDefault<Boolean>("toggleOnTitleClick", true); } set { this.attributes["toggleOnTitleClick"] = value; } }                
                    
    }
}
