using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.picker.Month : Ext.Component {
                    
        private _baseCls_default = 'x-monthpicker';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", 'x-monthpicker'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _cancelText_default = 'Cancel';
                    
                    
        [JsonIgnore]
        public String cancelText { get { return this.attributes.GetOrDefault<String>("cancelText", 'Cancel'); } set { this.attributes["cancelText"] = value; } }                
                    
                    
        private _okText_default = 'OK';
                    
                    
        [JsonIgnore]
        public String okText { get { return this.attributes.GetOrDefault<String>("okText", 'OK'); } set { this.attributes["okText"] = value; } }                
                    
                    
        private _renderTpl_default = ['<div id="{id}-bodyEl" class="{baseCls}-body">', '<div id="{id}-monthEl" class="{baseCls}-months">', '<tpl for="months">', '<div class="{parent.baseCls}-item {parent.baseCls}-month">', '<a style="{parent.monthStyle}" hidefocus="on" class="{parent.baseCls}-item-inner" href="#">{.}</a>', '</div>', '</tpl>', '</div>', '<div id="{id}-yearEl" class="{baseCls}-years">', '<div class="{baseCls}-yearnav">', '<div class="{baseCls}-yearnav-button-ct">', '<a id="{id}-prevEl" class="{baseCls}-yearnav-button {baseCls}-yearnav-prev" href="#" hidefocus="on" ></a>', '</div>', '<div class="{baseCls}-yearnav-button-ct">', '<a id="{id}-nextEl" class="{baseCls}-yearnav-button {baseCls}-yearnav-next" href="#" hidefocus="on" ></a>', '</div>', '</div>', '<tpl for="years">', '<div class="{parent.baseCls}-item {parent.baseCls}-year">', '<a hidefocus="on" class="{parent.baseCls}-item-inner" href="#">{.}</a>', '</div>', '</tpl>', '</div>', '<div class="' + Ext.baseCSSPrefix + 'clear"></div>', '</div>', '<tpl if="showButtons">', '<div id="{id}-buttonsEl" class="{baseCls}-buttons">{%', 'var me=values.$comp, okBtn=me.okBtn, cancelBtn=me.cancelBtn;', 'okBtn.ownerLayout = cancelBtn.ownerLayout = me.componentLayout;', 'okBtn.ownerCt = cancelBtn.ownerCt = me;', 'Ext.DomHelper.generateMarkup(okBtn.getRenderTree(), out);', 'Ext.DomHelper.generateMarkup(cancelBtn.getRenderTree(), out);', '%}</div>', '</tpl>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<div id="{id}-bodyEl" class="{baseCls}-body">', '<div id="{id}-monthEl" class="{baseCls}-months">', '<tpl for="months">', '<div class="{parent.baseCls}-item {parent.baseCls}-month">', '<a style="{parent.monthStyle}" hidefocus="on" class="{parent.baseCls}-item-inner" href="#">{.}</a>', '</div>', '</tpl>', '</div>', '<div id="{id}-yearEl" class="{baseCls}-years">', '<div class="{baseCls}-yearnav">', '<div class="{baseCls}-yearnav-button-ct">', '<a id="{id}-prevEl" class="{baseCls}-yearnav-button {baseCls}-yearnav-prev" href="#" hidefocus="on" ></a>', '</div>', '<div class="{baseCls}-yearnav-button-ct">', '<a id="{id}-nextEl" class="{baseCls}-yearnav-button {baseCls}-yearnav-next" href="#" hidefocus="on" ></a>', '</div>', '</div>', '<tpl for="years">', '<div class="{parent.baseCls}-item {parent.baseCls}-year">', '<a hidefocus="on" class="{parent.baseCls}-item-inner" href="#">{.}</a>', '</div>', '</tpl>', '</div>', '<div class="' + Ext.baseCSSPrefix + 'clear"></div>', '</div>', '<tpl if="showButtons">', '<div id="{id}-buttonsEl" class="{baseCls}-buttons">{%', 'var me=values.$comp, okBtn=me.okBtn, cancelBtn=me.cancelBtn;', 'okBtn.ownerLayout = cancelBtn.ownerLayout = me.componentLayout;', 'okBtn.ownerCt = cancelBtn.ownerCt = me;', 'Ext.DomHelper.generateMarkup(okBtn.getRenderTree(), out);', 'Ext.DomHelper.generateMarkup(cancelBtn.getRenderTree(), out);', '%}</div>', '</tpl>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        private _selectedCls_default = 'x-monthpicker-selected';
                    
                    
        [JsonIgnore]
        public String selectedCls { get { return this.attributes.GetOrDefault<String>("selectedCls", 'x-monthpicker-selected'); } set { this.attributes["selectedCls"] = value; } }                
                    
                    
        private _showButtons_default = true;
                    
                    
        [JsonIgnore]
        public Boolean showButtons { get { return this.attributes.GetOrDefault<Boolean>("showButtons", true); } set { this.attributes["showButtons"] = value; } }                
                    
                    
        public class MultiType_value {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (DateTime m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator DateTime (int m) {
                return new DateTime { _value = m };
            }
                            
                            
            public static explicit operator int (Number[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Number[] (int m) {
                return new Number[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_value value { get { return this.attributes.GetOrDefault<MultiType_value>("value", ); } set { this.attributes["value"] = value; } }                

                    
    }
}
