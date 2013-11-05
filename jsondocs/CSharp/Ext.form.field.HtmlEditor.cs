using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.HtmlEditor : Ext.form.FieldContainer {
                    
        public class MultiType_afterIFrameTpl {
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
        public MultiType_afterIFrameTpl afterIFrameTpl { get { return this.attributes.GetOrDefault<MultiType_afterIFrameTpl>("afterIFrameTpl", ); } set { this.attributes["afterIFrameTpl"] = value; } }                

                    
                    
        public class MultiType_afterTextAreaTpl {
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
        public MultiType_afterTextAreaTpl afterTextAreaTpl { get { return this.attributes.GetOrDefault<MultiType_afterTextAreaTpl>("afterTextAreaTpl", ); } set { this.attributes["afterTextAreaTpl"] = value; } }                

                    
                    
        public class MultiType_beforeIFrameTpl {
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
        public MultiType_beforeIFrameTpl beforeIFrameTpl { get { return this.attributes.GetOrDefault<MultiType_beforeIFrameTpl>("beforeIFrameTpl", ); } set { this.attributes["beforeIFrameTpl"] = value; } }                

                    
                    
        public class MultiType_beforeTextAreaTpl {
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
        public MultiType_beforeTextAreaTpl beforeTextAreaTpl { get { return this.attributes.GetOrDefault<MultiType_beforeTextAreaTpl>("beforeTextAreaTpl", ); } set { this.attributes["beforeTextAreaTpl"] = value; } }                

                    
                    
        private _componentLayout_default = 'htmleditor';
                    
                    
        public class MultiType_componentLayout {
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'htmleditor'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _createLinkText_default = 'Please enter the URL for the link:';
                    
                    
        [JsonIgnore]
        public String createLinkText { get { return this.attributes.GetOrDefault<String>("createLinkText", 'Please enter the URL for the link:'); } set { this.attributes["createLinkText"] = value; } }                
                    
                    
        [JsonIgnore]
        public String defaultButtonUI { get { return this.attributes.GetOrDefault<String>("defaultButtonUI", ); } set { this.attributes["defaultButtonUI"] = value; } }                
                    
                    
        private _defaultLinkValue_default = 'http://';
                    
                    
        [JsonIgnore]
        public String defaultLinkValue { get { return this.attributes.GetOrDefault<String>("defaultLinkValue", 'http://'); } set { this.attributes["defaultLinkValue"] = value; } }                
                    
                    
        [JsonIgnore]
        public String defaultValue { get { return this.attributes.GetOrDefault<String>("defaultValue", ); } set { this.attributes["defaultValue"] = value; } }                
                    
                    
        private _enableAlignments_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableAlignments { get { return this.attributes.GetOrDefault<Boolean>("enableAlignments", true); } set { this.attributes["enableAlignments"] = value; } }                
                    
                    
        private _enableColors_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableColors { get { return this.attributes.GetOrDefault<Boolean>("enableColors", true); } set { this.attributes["enableColors"] = value; } }                
                    
                    
        private _enableFont_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableFont { get { return this.attributes.GetOrDefault<Boolean>("enableFont", true); } set { this.attributes["enableFont"] = value; } }                
                    
                    
        private _enableFontSize_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableFontSize { get { return this.attributes.GetOrDefault<Boolean>("enableFontSize", true); } set { this.attributes["enableFontSize"] = value; } }                
                    
                    
        private _enableFormat_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableFormat { get { return this.attributes.GetOrDefault<Boolean>("enableFormat", true); } set { this.attributes["enableFormat"] = value; } }                
                    
                    
        private _enableLinks_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableLinks { get { return this.attributes.GetOrDefault<Boolean>("enableLinks", true); } set { this.attributes["enableLinks"] = value; } }                
                    
                    
        private _enableLists_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableLists { get { return this.attributes.GetOrDefault<Boolean>("enableLists", true); } set { this.attributes["enableLists"] = value; } }                
                    
                    
        private _enableSourceEdit_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableSourceEdit { get { return this.attributes.GetOrDefault<Boolean>("enableSourceEdit", true); } set { this.attributes["enableSourceEdit"] = value; } }                
                    
                    
        private _fontFamilies_default = ['Arial', 'Courier New', 'Tahoma', 'Times New Roman', 'Verdana'];
                    
                    
        [JsonIgnore]
        public String[] fontFamilies { get { return this.attributes.GetOrDefault<String[]>("fontFamilies", ['Arial', 'Courier New', 'Tahoma', 'Times New Roman', 'Verdana']); } set { this.attributes["fontFamilies"] = value; } }                
                    
                    
        public class MultiType_iframeAttrTpl {
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
        public MultiType_iframeAttrTpl iframeAttrTpl { get { return this.attributes.GetOrDefault<MultiType_iframeAttrTpl>("iframeAttrTpl", ); } set { this.attributes["iframeAttrTpl"] = value; } }                

                    
    }
}
