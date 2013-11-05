using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.container.ButtonGroup : Ext.panel.Panel {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'btn-group';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'btn-group'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number columns { get { return this.attributes.GetOrDefault<Number>("columns", ); } set { this.attributes["columns"] = value; } }                
                    
                    
        [JsonIgnore]
        public String defaultButtonUI { get { return this.attributes.GetOrDefault<String>("defaultButtonUI", ); } set { this.attributes["defaultButtonUI"] = value; } }                
                    
                    
        private _defaultType_default = 'button';
                    
                    
        [JsonIgnore]
        public String defaultType { get { return this.attributes.GetOrDefault<String>("defaultType", 'button'); } set { this.attributes["defaultType"] = value; } }                
                    
                    
        private _frame_default = true;
                    
                    
        [JsonIgnore]
        public Boolean frame { get { return this.attributes.GetOrDefault<Boolean>("frame", true); } set { this.attributes["frame"] = value; } }                
                    
                    
        private _layout_default = {type: 'table'};
                    
                    
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", {type: 'table'}); } set { this.attributes["layout"] = value; } }                

                    
                    
        private _titleAlign_default = 'center';
                    
                    
        [JsonIgnore]
        public String titleAlign { get { return this.attributes.GetOrDefault<String>("titleAlign", 'center'); } set { this.attributes["titleAlign"] = value; } }                
                    
    }
}
