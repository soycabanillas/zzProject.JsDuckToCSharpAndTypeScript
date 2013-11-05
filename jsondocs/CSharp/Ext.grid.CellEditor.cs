using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.CellEditor : Ext.Editor {
                    
        private _alignment_default = "l-l";
                    
                    
        [JsonIgnore]
        public String alignment { get { return this.attributes.GetOrDefault<String>("alignment", "l-l"); } set { this.attributes["alignment"] = value; } }                
                    
                    
        private _cls_default = Ext.baseCSSPrefix + 'small-editor ' + Ext.baseCSSPrefix + 'grid-editor ' + Ext.baseCSSPrefix + 'grid-cell-editor';
                    
                    
        [JsonIgnore]
        public String cls { get { return this.attributes.GetOrDefault<String>("cls", Ext.baseCSSPrefix + 'small-editor ' + Ext.baseCSSPrefix + 'grid-editor ' + Ext.baseCSSPrefix + 'grid-cell-editor'); } set { this.attributes["cls"] = value; } }                
                    
                    
        private _hideEl_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideEl { get { return this.attributes.GetOrDefault<Boolean>("hideEl", false); } set { this.attributes["hideEl"] = value; } }                
                    
                    
        private _shadow_default = false;
                    
                    
        public class MultiType_shadow {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
            }
                            
                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_shadow shadow { get { return this.attributes.GetOrDefault<MultiType_shadow>("shadow", false); } set { this.attributes["shadow"] = value; } }                

                    
    }
}
