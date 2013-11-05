using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.dd.StatusProxy : Ext.Component {
                    
        private _dropAllowed_default = Ext.baseCSSPrefix + 'dd-drop-ok';
                    
                    
        [JsonIgnore]
        public String dropAllowed { get { return this.attributes.GetOrDefault<String>("dropAllowed", Ext.baseCSSPrefix + 'dd-drop-ok'); } set { this.attributes["dropAllowed"] = value; } }                
                    
                    
        private _dropNotAllowed_default = Ext.baseCSSPrefix + 'dd-drop-nodrop';
                    
                    
        [JsonIgnore]
        public String dropNotAllowed { get { return this.attributes.GetOrDefault<String>("dropNotAllowed", Ext.baseCSSPrefix + 'dd-drop-nodrop'); } set { this.attributes["dropNotAllowed"] = value; } }                
                    
                    
        private _renderTpl_default = ['<div class="' + Ext.baseCSSPrefix + 'dd-drop-icon"></div>' + '<div id="{id}-ghost" class="' + Ext.baseCSSPrefix + 'dd-drag-ghost"></div>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<div class="' + Ext.baseCSSPrefix + 'dd-drop-icon"></div>' + '<div id="{id}-ghost" class="' + Ext.baseCSSPrefix + 'dd-drag-ghost"></div>']); } set { this.attributes["renderTpl"] = value; } }                

                    
    }
}
