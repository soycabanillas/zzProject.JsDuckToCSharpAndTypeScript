using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tree.Panel : Ext.panel.Table {
                    
        [JsonIgnore]
        public Boolean animate { get { return this.attributes.GetOrDefault<Boolean>("animate", ); } set { this.attributes["animate"] = value; } }                
                    
                    
        private _deferRowRender_default = false;
                    
                    
        [JsonIgnore]
        public Boolean deferRowRender { get { return this.attributes.GetOrDefault<Boolean>("deferRowRender", false); } set { this.attributes["deferRowRender"] = value; } }                
                    
                    
        private _displayField_default = 'text';
                    
                    
        [JsonIgnore]
        public String displayField { get { return this.attributes.GetOrDefault<String>("displayField", 'text'); } set { this.attributes["displayField"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean folderSort { get { return this.attributes.GetOrDefault<Boolean>("folderSort", ); } set { this.attributes["folderSort"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean hideHeaders { get { return this.attributes.GetOrDefault<Boolean>("hideHeaders", ); } set { this.attributes["hideHeaders"] = value; } }                
                    
                    
        private _lines_default = true;
                    
                    
        [JsonIgnore]
        public Boolean lines { get { return this.attributes.GetOrDefault<Boolean>("lines", true); } set { this.attributes["lines"] = value; } }                
                    
                    
        public class MultiType_root {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.data.Model m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.Model (int m) {
                return new Ext.data.Model { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.data.NodeInterface m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.NodeInterface (int m) {
                return new Ext.data.NodeInterface { _value = m };
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
        public MultiType_root root { get { return this.attributes.GetOrDefault<MultiType_root>("root", ); } set { this.attributes["root"] = value; } }                

                    
                    
        private _rootVisible_default = true;
                    
                    
        [JsonIgnore]
        public Boolean rootVisible { get { return this.attributes.GetOrDefault<Boolean>("rootVisible", true); } set { this.attributes["rootVisible"] = value; } }                
                    
                    
        private _rowLines_default = false;
                    
                    
        [JsonIgnore]
        public Boolean rowLines { get { return this.attributes.GetOrDefault<Boolean>("rowLines", false); } set { this.attributes["rowLines"] = value; } }                
                    
                    
        private _selType_default = 'treemodel';
                    
                    
        [JsonIgnore]
        public String selType { get { return this.attributes.GetOrDefault<String>("selType", 'treemodel'); } set { this.attributes["selType"] = value; } }                
                    
                    
        private _singleExpand_default = false;
                    
                    
        [JsonIgnore]
        public Boolean singleExpand { get { return this.attributes.GetOrDefault<Boolean>("singleExpand", false); } set { this.attributes["singleExpand"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.TreeStore store { get { return this.attributes.GetOrDefault<Ext.data.TreeStore>("store", ); } set { this.attributes["store"] = value; } }                
                    
                    
        private _useArrows_default = false;
                    
                    
        [JsonIgnore]
        public Boolean useArrows { get { return this.attributes.GetOrDefault<Boolean>("useArrows", false); } set { this.attributes["useArrows"] = value; } }                
                    
                    
        private _viewType_default = 'treeview';
                    
                    
        [JsonIgnore]
        public String viewType { get { return this.attributes.GetOrDefault<String>("viewType", 'treeview'); } set { this.attributes["viewType"] = value; } }                
                    
    }
}
