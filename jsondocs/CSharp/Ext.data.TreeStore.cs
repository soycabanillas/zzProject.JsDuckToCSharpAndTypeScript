using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.TreeStore : Ext.data.AbstractStore {
                    
        private _clearOnLoad_default = true;
                    
                    
        [JsonIgnore]
        public Boolean clearOnLoad { get { return this.attributes.GetOrDefault<Boolean>("clearOnLoad", true); } set { this.attributes["clearOnLoad"] = value; } }                
                    
                    
        private _clearRemovedOnLoad_default = true;
                    
                    
        [JsonIgnore]
        public Boolean clearRemovedOnLoad { get { return this.attributes.GetOrDefault<Boolean>("clearRemovedOnLoad", true); } set { this.attributes["clearRemovedOnLoad"] = value; } }                
                    
                    
        private _defaultRootId_default = "root";
                    
                    
        [JsonIgnore]
        public String defaultRootId { get { return this.attributes.GetOrDefault<String>("defaultRootId", "root"); } set { this.attributes["defaultRootId"] = value; } }                
                    
                    
        private _defaultRootProperty_default = "children";
                    
                    
        [JsonIgnore]
        public String defaultRootProperty { get { return this.attributes.GetOrDefault<String>("defaultRootProperty", "children"); } set { this.attributes["defaultRootProperty"] = value; } }                
                    
                    
        private _defaultRootText_default = "Root";
                    
                    
        [JsonIgnore]
        public String defaultRootText { get { return this.attributes.GetOrDefault<String>("defaultRootText", "Root"); } set { this.attributes["defaultRootText"] = value; } }                
                    
                    
        private _folderSort_default = false;
                    
                    
        [JsonIgnore]
        public Boolean folderSort { get { return this.attributes.GetOrDefault<Boolean>("folderSort", false); } set { this.attributes["folderSort"] = value; } }                
                    
                    
        private _nodeParam_default = "node";
                    
                    
        [JsonIgnore]
        public String nodeParam { get { return this.attributes.GetOrDefault<String>("nodeParam", "node"); } set { this.attributes["nodeParam"] = value; } }                
                    
                    
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

                    
    }
}
