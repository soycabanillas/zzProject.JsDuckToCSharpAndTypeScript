using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.picker.Color : Ext.Component {
                    
        private _allowReselect_default = false;
                    
                    
        [JsonIgnore]
        public Boolean allowReselect { get { return this.attributes.GetOrDefault<Boolean>("allowReselect", false); } set { this.attributes["allowReselect"] = value; } }                
                    
                    
        private _clickEvent_default = 'click';
                    
                    
        [JsonIgnore]
        public String clickEvent { get { return this.attributes.GetOrDefault<String>("clickEvent", 'click'); } set { this.attributes["clickEvent"] = value; } }                
                    
                    
        private _componentCls_default = 'x-color-picker';
                    
                    
        [JsonIgnore]
        public String componentCls { get { return this.attributes.GetOrDefault<String>("componentCls", 'x-color-picker'); } set { this.attributes["componentCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function handler { get { return this.attributes.GetOrDefault<Function>("handler", ); } set { this.attributes["handler"] = value; } }                
                    
                    
        private _itemCls_default = Ext.baseCSSPrefix + 'color-picker-item';
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", Ext.baseCSSPrefix + 'color-picker-item'); } set { this.attributes["itemCls"] = value; } }                
                    
                    
        private _renderTpl_default = ['<tpl for="colors">', '<a href="#" class="color-{.} {parent.itemCls}" hidefocus="on">', '<span class="{parent.itemCls}-inner" style="background:#{.}">&#160;</span>', '</a>', '</tpl>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<tpl for="colors">', '<a href="#" class="color-{.} {parent.itemCls}" hidefocus="on">', '<span class="{parent.itemCls}-inner" style="background:#{.}">&#160;</span>', '</a>', '</tpl>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _selectedCls_default = 'x-color-picker-selected';
                    
                    
        [JsonIgnore]
        public String selectedCls { get { return this.attributes.GetOrDefault<String>("selectedCls", 'x-color-picker-selected'); } set { this.attributes["selectedCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String value { get { return this.attributes.GetOrDefault<String>("value", ); } set { this.attributes["value"] = value; } }                
                    
    }
}
