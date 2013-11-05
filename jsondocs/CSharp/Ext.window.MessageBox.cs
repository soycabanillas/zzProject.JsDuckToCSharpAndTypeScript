using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.window.MessageBox : Ext.window.Window {
                    
        private _closeAction_default = 'hide';
                    
                    
        [JsonIgnore]
        public String closeAction { get { return this.attributes.GetOrDefault<String>("closeAction", 'hide'); } set { this.attributes["closeAction"] = value; } }                
                    
                    
        private _cls_default = [Ext.baseCSSPrefix + 'message-box', Ext.baseCSSPrefix + 'hide-offsets'];
                    
                    
        [JsonIgnore]
        public String cls { get { return this.attributes.GetOrDefault<String>("cls", [Ext.baseCSSPrefix + 'message-box', Ext.baseCSSPrefix + 'hide-offsets']); } set { this.attributes["cls"] = value; } }                
                    
                    
        private _constrain_default = true;
                    
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", true); } set { this.attributes["constrain"] = value; } }                
                    
                    
        private _hideMode_default = 'offsets';
                    
                    
        [JsonIgnore]
        public String hideMode { get { return this.attributes.GetOrDefault<String>("hideMode", 'offsets'); } set { this.attributes["hideMode"] = value; } }                
                    
                    
        private _layout_default = {type: 'vbox', align: 'stretch'};
                    
                    
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", {type: 'vbox', align: 'stretch'}); } set { this.attributes["layout"] = value; } }                

                    
                    
        [JsonIgnore]
        public Number maxHeight { get { return this.attributes.GetOrDefault<Number>("maxHeight", ); } set { this.attributes["maxHeight"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number maxWidth { get { return this.attributes.GetOrDefault<Number>("maxWidth", ); } set { this.attributes["maxWidth"] = value; } }                
                    
                    
        private _minHeight_default = 50;
                    
                    
        [JsonIgnore]
        public Number minHeight { get { return this.attributes.GetOrDefault<Number>("minHeight", 50); } set { this.attributes["minHeight"] = value; } }                
                    
                    
        private _minWidth_default = 50;
                    
                    
        [JsonIgnore]
        public Number minWidth { get { return this.attributes.GetOrDefault<Number>("minWidth", 50); } set { this.attributes["minWidth"] = value; } }                
                    
                    
        private _resizable_default = false;
                    
                    
        public class MultiType_resizable {
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
        public MultiType_resizable resizable { get { return this.attributes.GetOrDefault<MultiType_resizable>("resizable", false); } set { this.attributes["resizable"] = value; } }                

                    
                    
        private _shrinkWrapDock_default = true;
                    
                    
        public class MultiType_shrinkWrapDock {
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
                            
                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_shrinkWrapDock shrinkWrapDock { get { return this.attributes.GetOrDefault<MultiType_shrinkWrapDock>("shrinkWrapDock", true); } set { this.attributes["shrinkWrapDock"] = value; } }                

                    
                    
        private _title_default = '&#160;';
                    
                    
        [JsonIgnore]
        public String title { get { return this.attributes.GetOrDefault<String>("title", '&#160;'); } set { this.attributes["title"] = value; } }                
                    
    }
}
