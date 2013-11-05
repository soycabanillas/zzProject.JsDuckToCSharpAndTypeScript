using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.Labelable : Ext.Base {
                    
        [JsonIgnore]
        public String activeError { get { return this.attributes.GetOrDefault<String>("activeError", ); } set { this.attributes["activeError"] = value; } }                
                    
                    
        public class MultiType_activeErrorsTpl {
            public new Type GetType()
            {
                return _value.GetType();
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
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_activeErrorsTpl activeErrorsTpl { get { return this.attributes.GetOrDefault<MultiType_activeErrorsTpl>("activeErrorsTpl", ); } set { this.attributes["activeErrorsTpl"] = value; } }                

                    
                    
        public class MultiType_afterBodyEl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_afterBodyEl afterBodyEl { get { return this.attributes.GetOrDefault<MultiType_afterBodyEl>("afterBodyEl", ); } set { this.attributes["afterBodyEl"] = value; } }                

                    
                    
        public class MultiType_afterLabelTextTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_afterLabelTextTpl afterLabelTextTpl { get { return this.attributes.GetOrDefault<MultiType_afterLabelTextTpl>("afterLabelTextTpl", ); } set { this.attributes["afterLabelTextTpl"] = value; } }                

                    
                    
        public class MultiType_afterLabelTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_afterLabelTpl afterLabelTpl { get { return this.attributes.GetOrDefault<MultiType_afterLabelTpl>("afterLabelTpl", ); } set { this.attributes["afterLabelTpl"] = value; } }                

                    
                    
        public class MultiType_afterSubTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_afterSubTpl afterSubTpl { get { return this.attributes.GetOrDefault<MultiType_afterSubTpl>("afterSubTpl", ); } set { this.attributes["afterSubTpl"] = value; } }                

                    
                    
        private _autoFitErrors_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoFitErrors { get { return this.attributes.GetOrDefault<Boolean>("autoFitErrors", true); } set { this.attributes["autoFitErrors"] = value; } }                
                    
                    
        private _baseBodyCls_default = Ext.baseCSSPrefix + 'form-item-body';
                    
                    
        [JsonIgnore]
        public String baseBodyCls { get { return this.attributes.GetOrDefault<String>("baseBodyCls", Ext.baseCSSPrefix + 'form-item-body'); } set { this.attributes["baseBodyCls"] = value; } }                
                    
                    
        public class MultiType_beforeBodyEl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_beforeBodyEl beforeBodyEl { get { return this.attributes.GetOrDefault<MultiType_beforeBodyEl>("beforeBodyEl", ); } set { this.attributes["beforeBodyEl"] = value; } }                

                    
                    
        public class MultiType_beforeLabelTextTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_beforeLabelTextTpl beforeLabelTextTpl { get { return this.attributes.GetOrDefault<MultiType_beforeLabelTextTpl>("beforeLabelTextTpl", ); } set { this.attributes["beforeLabelTextTpl"] = value; } }                

                    
                    
        public class MultiType_beforeLabelTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_beforeLabelTpl beforeLabelTpl { get { return this.attributes.GetOrDefault<MultiType_beforeLabelTpl>("beforeLabelTpl", ); } set { this.attributes["beforeLabelTpl"] = value; } }                

                    
                    
        public class MultiType_beforeSubTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_beforeSubTpl beforeSubTpl { get { return this.attributes.GetOrDefault<MultiType_beforeSubTpl>("beforeSubTpl", ); } set { this.attributes["beforeSubTpl"] = value; } }                

                    
                    
        private _clearCls_default = Ext.baseCSSPrefix + 'clear';
                    
                    
        [JsonIgnore]
        public String clearCls { get { return this.attributes.GetOrDefault<String>("clearCls", Ext.baseCSSPrefix + 'clear'); } set { this.attributes["clearCls"] = value; } }                
                    
                    
        private _errorMsgCls_default = Ext.baseCSSPrefix + 'form-error-msg';
                    
                    
        [JsonIgnore]
        public String errorMsgCls { get { return this.attributes.GetOrDefault<String>("errorMsgCls", Ext.baseCSSPrefix + 'form-error-msg'); } set { this.attributes["errorMsgCls"] = value; } }                
                    
                    
        private _fieldBodyCls_default = '';
                    
                    
        [JsonIgnore]
        public String fieldBodyCls { get { return this.attributes.GetOrDefault<String>("fieldBodyCls", ''); } set { this.attributes["fieldBodyCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String fieldLabel { get { return this.attributes.GetOrDefault<String>("fieldLabel", ); } set { this.attributes["fieldLabel"] = value; } }                
                    
                    
        private _formItemCls_default = Ext.baseCSSPrefix + 'form-item';
                    
                    
        [JsonIgnore]
        public String formItemCls { get { return this.attributes.GetOrDefault<String>("formItemCls", Ext.baseCSSPrefix + 'form-item'); } set { this.attributes["formItemCls"] = value; } }                
                    
                    
        private _hideEmptyLabel_default = true;
                    
                    
        [JsonIgnore]
        public Boolean hideEmptyLabel { get { return this.attributes.GetOrDefault<Boolean>("hideEmptyLabel", true); } set { this.attributes["hideEmptyLabel"] = value; } }                
                    
                    
        private _hideLabel_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideLabel { get { return this.attributes.GetOrDefault<Boolean>("hideLabel", false); } set { this.attributes["hideLabel"] = value; } }                
                    
                    
        private _invalidCls_default = Ext.baseCSSPrefix + 'form-invalid';
                    
                    
        [JsonIgnore]
        public String invalidCls { get { return this.attributes.GetOrDefault<String>("invalidCls", Ext.baseCSSPrefix + 'form-invalid'); } set { this.attributes["invalidCls"] = value; } }                
                    
                    
        private _labelAlign_default = 'left';
                    
                    
        [JsonIgnore]
        public String labelAlign { get { return this.attributes.GetOrDefault<String>("labelAlign", 'left'); } set { this.attributes["labelAlign"] = value; } }                
                    
                    
        public class MultiType_labelAttrTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (String m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator String (int m) {
                return new String { _value = m };
            }
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_labelAttrTpl labelAttrTpl { get { return this.attributes.GetOrDefault<MultiType_labelAttrTpl>("labelAttrTpl", ); } set { this.attributes["labelAttrTpl"] = value; } }                

                    
                    
        private _labelCls_default = Ext.baseCSSPrefix + 'form-item-label';
                    
                    
        [JsonIgnore]
        public String labelCls { get { return this.attributes.GetOrDefault<String>("labelCls", Ext.baseCSSPrefix + 'form-item-label'); } set { this.attributes["labelCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String labelClsExtra { get { return this.attributes.GetOrDefault<String>("labelClsExtra", ); } set { this.attributes["labelClsExtra"] = value; } }                
                    
                    
        private _labelPad_default = 5;
                    
                    
        [JsonIgnore]
        public Number labelPad { get { return this.attributes.GetOrDefault<Number>("labelPad", 5); } set { this.attributes["labelPad"] = value; } }                
                    
                    
        private _labelSeparator_default = ':';
                    
                    
        [JsonIgnore]
        public String labelSeparator { get { return this.attributes.GetOrDefault<String>("labelSeparator", ':'); } set { this.attributes["labelSeparator"] = value; } }                
                    
                    
        [JsonIgnore]
        public String labelStyle { get { return this.attributes.GetOrDefault<String>("labelStyle", ); } set { this.attributes["labelStyle"] = value; } }                
                    
                    
        private _labelWidth_default = 100;
                    
                    
        [JsonIgnore]
        public Number labelWidth { get { return this.attributes.GetOrDefault<Number>("labelWidth", 100); } set { this.attributes["labelWidth"] = value; } }                
                    
                    
        private _msgTarget_default = 'qtip';
                    
                    
        [JsonIgnore]
        public String msgTarget { get { return this.attributes.GetOrDefault<String>("msgTarget", 'qtip'); } set { this.attributes["msgTarget"] = value; } }                
                    
                    
        private _preventMark_default = false;
                    
                    
        [JsonIgnore]
        public Boolean preventMark { get { return this.attributes.GetOrDefault<Boolean>("preventMark", false); } set { this.attributes["preventMark"] = value; } }                
                    
    }
}
