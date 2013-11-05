using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.panel.Panel : Ext.panel.AbstractPanel {
                    
        [JsonIgnore]
        public Boolean animCollapse { get { return this.attributes.GetOrDefault<Boolean>("animCollapse", ); } set { this.attributes["animCollapse"] = value; } }                
                    
                    
        public class MultiType_bbar {
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
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_bbar bbar { get { return this.attributes.GetOrDefault<MultiType_bbar>("bbar", ); } set { this.attributes["bbar"] = value; } }                

                    
                    
        [JsonIgnore]
        public String buttonAlign { get { return this.attributes.GetOrDefault<String>("buttonAlign", ); } set { this.attributes["buttonAlign"] = value; } }                
                    
                    
        public class MultiType_buttons {
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
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_buttons buttons { get { return this.attributes.GetOrDefault<MultiType_buttons>("buttons", ); } set { this.attributes["buttons"] = value; } }                

                    
                    
        private _closable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean closable { get { return this.attributes.GetOrDefault<Boolean>("closable", false); } set { this.attributes["closable"] = value; } }                
                    
                    
        private _closeAction_default = 'destroy';
                    
                    
        [JsonIgnore]
        public String closeAction { get { return this.attributes.GetOrDefault<String>("closeAction", 'destroy'); } set { this.attributes["closeAction"] = value; } }                
                    
                    
        [JsonIgnore]
        public String collapseDirection { get { return this.attributes.GetOrDefault<String>("collapseDirection", ); } set { this.attributes["collapseDirection"] = value; } }                
                    
                    
        private _collapseFirst_default = true;
                    
                    
        [JsonIgnore]
        public Boolean collapseFirst { get { return this.attributes.GetOrDefault<Boolean>("collapseFirst", true); } set { this.attributes["collapseFirst"] = value; } }                
                    
                    
        [JsonIgnore]
        public String collapseMode { get { return this.attributes.GetOrDefault<String>("collapseMode", ); } set { this.attributes["collapseMode"] = value; } }                
                    
                    
        private _collapsed_default = false;
                    
                    
        [JsonIgnore]
        public Boolean collapsed { get { return this.attributes.GetOrDefault<Boolean>("collapsed", false); } set { this.attributes["collapsed"] = value; } }                
                    
                    
        private _collapsedCls_default = 'collapsed';
                    
                    
        [JsonIgnore]
        public String collapsedCls { get { return this.attributes.GetOrDefault<String>("collapsedCls", 'collapsed'); } set { this.attributes["collapsedCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean collapsible { get { return this.attributes.GetOrDefault<Boolean>("collapsible", ); } set { this.attributes["collapsible"] = value; } }                
                    
                    
        private _constrain_default = false;
                    
                    
        [JsonIgnore]
        public Boolean constrain { get { return this.attributes.GetOrDefault<Boolean>("constrain", false); } set { this.attributes["constrain"] = value; } }                
                    
                    
        private _constrainHeader_default = false;
                    
                    
        [JsonIgnore]
        public Boolean constrainHeader { get { return this.attributes.GetOrDefault<Boolean>("constrainHeader", false); } set { this.attributes["constrainHeader"] = value; } }                
                    
                    
        public class MultiType_dockedItems {
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
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_dockedItems dockedItems { get { return this.attributes.GetOrDefault<MultiType_dockedItems>("dockedItems", ); } set { this.attributes["dockedItems"] = value; } }                

                    
                    
        public class MultiType_fbar {
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
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_fbar fbar { get { return this.attributes.GetOrDefault<MultiType_fbar>("fbar", ); } set { this.attributes["fbar"] = value; } }                

                    
                    
        private _floatable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean floatable { get { return this.attributes.GetOrDefault<Boolean>("floatable", true); } set { this.attributes["floatable"] = value; } }                
                    
                    
        private _frame_default = false;
                    
                    
        [JsonIgnore]
        public Boolean frame { get { return this.attributes.GetOrDefault<Boolean>("frame", false); } set { this.attributes["frame"] = value; } }                
                    
                    
        private _frameHeader_default = true;
                    
                    
        [JsonIgnore]
        public Boolean frameHeader { get { return this.attributes.GetOrDefault<Boolean>("frameHeader", true); } set { this.attributes["frameHeader"] = value; } }                
                    
                    
        public class MultiType_glyph {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
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
        public MultiType_glyph glyph { get { return this.attributes.GetOrDefault<MultiType_glyph>("glyph", ); } set { this.attributes["glyph"] = value; } }                

                    
                    
        public class MultiType_header {
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
        public MultiType_header header { get { return this.attributes.GetOrDefault<MultiType_header>("header", ); } set { this.attributes["header"] = value; } }                

                    
                    
        [JsonIgnore]
        public String headerOverCls { get { return this.attributes.GetOrDefault<String>("headerOverCls", ); } set { this.attributes["headerOverCls"] = value; } }                
                    
                    
        private _headerPosition_default = 'top';
                    
                    
        [JsonIgnore]
        public String headerPosition { get { return this.attributes.GetOrDefault<String>("headerPosition", 'top'); } set { this.attributes["headerPosition"] = value; } }                
                    
                    
        private _hideCollapseTool_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideCollapseTool { get { return this.attributes.GetOrDefault<Boolean>("hideCollapseTool", false); } set { this.attributes["hideCollapseTool"] = value; } }                
                    
                    
        [JsonIgnore]
        public String icon { get { return this.attributes.GetOrDefault<String>("icon", ); } set { this.attributes["icon"] = value; } }                
                    
                    
        [JsonIgnore]
        public String iconCls { get { return this.attributes.GetOrDefault<String>("iconCls", ); } set { this.attributes["iconCls"] = value; } }                
                    
                    
        public class MultiType_lbar {
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
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_lbar lbar { get { return this.attributes.GetOrDefault<MultiType_lbar>("lbar", ); } set { this.attributes["lbar"] = value; } }                

                    
                    
        private _manageHeight_default = true;
                    
                    
        [JsonIgnore]
        public Boolean manageHeight { get { return this.attributes.GetOrDefault<Boolean>("manageHeight", true); } set { this.attributes["manageHeight"] = value; } }                
                    
                    
        private _minButtonWidth_default = 75;
                    
                    
        [JsonIgnore]
        public Number minButtonWidth { get { return this.attributes.GetOrDefault<Number>("minButtonWidth", 75); } set { this.attributes["minButtonWidth"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean overlapHeader { get { return this.attributes.GetOrDefault<Boolean>("overlapHeader", ); } set { this.attributes["overlapHeader"] = value; } }                
                    
                    
        public class MultiType_placeholder {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.Component m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Component (int m) {
                return new Ext.Component { _value = m };
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
        public MultiType_placeholder placeholder { get { return this.attributes.GetOrDefault<MultiType_placeholder>("placeholder", ); } set { this.attributes["placeholder"] = value; } }                

                    
                    
        [JsonIgnore]
        public Number placeholderCollapseHideMode { get { return this.attributes.GetOrDefault<Number>("placeholderCollapseHideMode", ); } set { this.attributes["placeholderCollapseHideMode"] = value; } }                
                    
                    
        private _preventHeader_default = false;
                    
                    
        [JsonIgnore]
        public Boolean preventHeader { get { return this.attributes.GetOrDefault<Boolean>("preventHeader", false); } set { this.attributes["preventHeader"] = value; } }                
                    
                    
        public class MultiType_rbar {
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
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_rbar rbar { get { return this.attributes.GetOrDefault<MultiType_rbar>("rbar", ); } set { this.attributes["rbar"] = value; } }                

                    
                    
        private _simpleDrag_default = false;
                    
                    
        [JsonIgnore]
        public Boolean simpleDrag { get { return this.attributes.GetOrDefault<Boolean>("simpleDrag", false); } set { this.attributes["simpleDrag"] = value; } }                
                    
                    
        public class MultiType_tbar {
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
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_tbar tbar { get { return this.attributes.GetOrDefault<MultiType_tbar>("tbar", ); } set { this.attributes["tbar"] = value; } }                

                    
                    
        private _title_default = '';
                    
                    
        [JsonIgnore]
        public String title { get { return this.attributes.GetOrDefault<String>("title", ''); } set { this.attributes["title"] = value; } }                
                    
                    
        [JsonIgnore]
        public String titleAlign { get { return this.attributes.GetOrDefault<String>("titleAlign", ); } set { this.attributes["titleAlign"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean titleCollapse { get { return this.attributes.GetOrDefault<Boolean>("titleCollapse", ); } set { this.attributes["titleCollapse"] = value; } }                
                    
                    
        public class MultiType_tools {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.panel.Tool[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.panel.Tool[] (int m) {
                return new Ext.panel.Tool[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_tools tools { get { return this.attributes.GetOrDefault<MultiType_tools>("tools", ); } set { this.attributes["tools"] = value; } }                

                    
    }
}
