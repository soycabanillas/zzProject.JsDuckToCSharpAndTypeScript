using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tree.plugin.TreeViewDragDrop : Ext.AbstractPlugin {
                    
        private _allowContainerDrops_default = false;
                    
                    
        [JsonIgnore]
        public Boolean allowContainerDrops { get { return this.attributes.GetOrDefault<Boolean>("allowContainerDrops", false); } set { this.attributes["allowContainerDrops"] = value; } }                
                    
                    
        private _allowParentInserts_default = false;
                    
                    
        [JsonIgnore]
        public Boolean allowParentInserts { get { return this.attributes.GetOrDefault<Boolean>("allowParentInserts", false); } set { this.attributes["allowParentInserts"] = value; } }                
                    
                    
        private _appendOnly_default = false;
                    
                    
        [JsonIgnore]
        public Boolean appendOnly { get { return this.attributes.GetOrDefault<Boolean>("appendOnly", false); } set { this.attributes["appendOnly"] = value; } }                
                    
                    
        private _containerScroll_default = false;
                    
                    
        public class MultiType_containerScroll {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
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
        public MultiType_containerScroll containerScroll { get { return this.attributes.GetOrDefault<MultiType_containerScroll>("containerScroll", false); } set { this.attributes["containerScroll"] = value; } }                

                    
                    
        private _ddGroup_default = "TreeDD";
                    
                    
        [JsonIgnore]
        public String ddGroup { get { return this.attributes.GetOrDefault<String>("ddGroup", "TreeDD"); } set { this.attributes["ddGroup"] = value; } }                
                    
                    
        private _displayField_default = 'text';
                    
                    
        [JsonIgnore]
        public String displayField { get { return this.attributes.GetOrDefault<String>("displayField", 'text'); } set { this.attributes["displayField"] = value; } }                
                    
                    
        [JsonIgnore]
        public String dragGroup { get { return this.attributes.GetOrDefault<String>("dragGroup", ); } set { this.attributes["dragGroup"] = value; } }                
                    
                    
        private _dragText_default = '{0} selected node{1}';
                    
                    
        [JsonIgnore]
        public String dragText { get { return this.attributes.GetOrDefault<String>("dragText", '{0} selected node{1}'); } set { this.attributes["dragText"] = value; } }                
                    
                    
        [JsonIgnore]
        public String dropGroup { get { return this.attributes.GetOrDefault<String>("dropGroup", ); } set { this.attributes["dropGroup"] = value; } }                
                    
                    
        private _enableDrag_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableDrag { get { return this.attributes.GetOrDefault<Boolean>("enableDrag", true); } set { this.attributes["enableDrag"] = value; } }                
                    
                    
        private _enableDrop_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableDrop { get { return this.attributes.GetOrDefault<Boolean>("enableDrop", true); } set { this.attributes["enableDrop"] = value; } }                
                    
                    
        private _expandDelay_default = 1000;
                    
                    
        [JsonIgnore]
        public Number expandDelay { get { return this.attributes.GetOrDefault<Number>("expandDelay", 1000); } set { this.attributes["expandDelay"] = value; } }                
                    
                    
        private _nodeHighlightColor_default = 'c3daf9';
                    
                    
        [JsonIgnore]
        public String nodeHighlightColor { get { return this.attributes.GetOrDefault<String>("nodeHighlightColor", 'c3daf9'); } set { this.attributes["nodeHighlightColor"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean nodeHighlightOnDrop { get { return this.attributes.GetOrDefault<Boolean>("nodeHighlightOnDrop", ); } set { this.attributes["nodeHighlightOnDrop"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean nodeHighlightOnRepair { get { return this.attributes.GetOrDefault<Boolean>("nodeHighlightOnRepair", ); } set { this.attributes["nodeHighlightOnRepair"] = value; } }                
                    
                    
        private _sortOnDrop_default = false;
                    
                    
        [JsonIgnore]
        public Boolean sortOnDrop { get { return this.attributes.GetOrDefault<Boolean>("sortOnDrop", false); } set { this.attributes["sortOnDrop"] = value; } }                
                    
    }
}
