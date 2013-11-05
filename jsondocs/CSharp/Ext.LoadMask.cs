using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.LoadMask : Ext.Component {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'mask-msg';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'mask-msg'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _maskCls_default = "x-mask";
                    
                    
        [JsonIgnore]
        public String maskCls { get { return this.attributes.GetOrDefault<String>("maskCls", "x-mask"); } set { this.attributes["maskCls"] = value; } }                
                    
                    
        private _msg_default = "Loading...";
                    
                    
        [JsonIgnore]
        public String msg { get { return this.attributes.GetOrDefault<String>("msg", "Loading..."); } set { this.attributes["msg"] = value; } }                
                    
                    
        private _msgCls_default = "x-mask-loading";
                    
                    
        [JsonIgnore]
        public String msgCls { get { return this.attributes.GetOrDefault<String>("msgCls", "x-mask-loading"); } set { this.attributes["msgCls"] = value; } }                
                    
                    
        private _renderTpl_default = ['<div id="{id}-msgEl" class="{[values.$comp.msgCls]} ', Ext.baseCSSPrefix, 'mask-msg-inner{childElCls}">', '<div id="{id}-msgTextEl" class="', Ext.baseCSSPrefix, 'mask-msg-text', '{childElCls}"></div>', '</div>'];
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<div id="{id}-msgEl" class="{[values.$comp.msgCls]} ', Ext.baseCSSPrefix, 'mask-msg-inner{childElCls}">', '<div id="{id}-msgTextEl" class="', Ext.baseCSSPrefix, 'mask-msg-text', '{childElCls}"></div>', '</div>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        [JsonIgnore]
        public Ext.data.Store store { get { return this.attributes.GetOrDefault<Ext.data.Store>("store", ); } set { this.attributes["store"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.Component target { get { return this.attributes.GetOrDefault<Ext.Component>("target", ); } set { this.attributes["target"] = value; } }                
                    
                    
        private _useMsg_default = true;
                    
                    
        [JsonIgnore]
        public Boolean useMsg { get { return this.attributes.GetOrDefault<Boolean>("useMsg", true); } set { this.attributes["useMsg"] = value; } }                
                    
                    
        private _useTargetEl_default = false;
                    
                    
        [JsonIgnore]
        public Boolean useTargetEl { get { return this.attributes.GetOrDefault<Boolean>("useTargetEl", false); } set { this.attributes["useTargetEl"] = value; } }                
                    
    }
}
