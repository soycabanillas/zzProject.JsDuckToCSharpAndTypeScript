using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.ComboBox : Ext.form.field.Picker {
                    
        private _allQuery_default = '';
                    
                    
        [JsonIgnore]
        public String allQuery { get { return this.attributes.GetOrDefault<String>("allQuery", ''); } set { this.attributes["allQuery"] = value; } }                
                    
                    
        private _anyMatch_default = false;
                    
                    
        [JsonIgnore]
        public Boolean anyMatch { get { return this.attributes.GetOrDefault<Boolean>("anyMatch", false); } set { this.attributes["anyMatch"] = value; } }                
                    
                    
        private _autoSelect_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoSelect { get { return this.attributes.GetOrDefault<Boolean>("autoSelect", true); } set { this.attributes["autoSelect"] = value; } }                
                    
                    
        private _caseSensitive_default = false;
                    
                    
        [JsonIgnore]
        public Boolean caseSensitive { get { return this.attributes.GetOrDefault<Boolean>("caseSensitive", false); } set { this.attributes["caseSensitive"] = value; } }                
                    
                    
        private _componentLayout_default = 'combobox';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'combobox'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _defaultListConfig_default = {loadingHeight: 70, minWidth: 70, maxHeight: 300, shadow: 'sides'};
                    
                    
        [JsonIgnore]
        public Object defaultListConfig { get { return this.attributes.GetOrDefault<Object>("defaultListConfig", {loadingHeight: 70, minWidth: 70, maxHeight: 300, shadow: 'sides'}); } set { this.attributes["defaultListConfig"] = value; } }                
                    
                    
        private _delimiter_default = ', ';
                    
                    
        [JsonIgnore]
        public String delimiter { get { return this.attributes.GetOrDefault<String>("delimiter", ', '); } set { this.attributes["delimiter"] = value; } }                
                    
                    
        private _displayField_default = 'text';
                    
                    
        [JsonIgnore]
        public String displayField { get { return this.attributes.GetOrDefault<String>("displayField", 'text'); } set { this.attributes["displayField"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean enableRegEx { get { return this.attributes.GetOrDefault<Boolean>("enableRegEx", ); } set { this.attributes["enableRegEx"] = value; } }                
                    
                    
        private _fieldSubTpl_default = ['<div class="{hiddenDataCls}" role="presentation"></div>', '<input id="{id}" type="{type}" {inputAttrTpl} class="{fieldCls} {typeCls} {editableCls}" autocomplete="off"', '<tpl if="value"> value="{[Ext.util.Format.htmlEncode(values.value)]}"</tpl>', '<tpl if="name"> name="{name}"</tpl>', '<tpl if="placeholder"> placeholder="{placeholder}"</tpl>', '<tpl if="size"> size="{size}"</tpl>', '<tpl if="maxLength !== undefined"> maxlength="{maxLength}"</tpl>', '<tpl if="readOnly"> readonly="readonly"</tpl>', '<tpl if="disabled"> disabled="disabled"</tpl>', '<tpl if="tabIdx"> tabIndex="{tabIdx}"</tpl>', '<tpl if="fieldStyle"> style="{fieldStyle}"</tpl>', '/>', {compiled: true, disableFormats: true}];
                    
                    
        [JsonIgnore]
        public Ext.XTemplate fieldSubTpl { get { return this.attributes.GetOrDefault<Ext.XTemplate>("fieldSubTpl", ['<div class="{hiddenDataCls}" role="presentation"></div>', '<input id="{id}" type="{type}" {inputAttrTpl} class="{fieldCls} {typeCls} {editableCls}" autocomplete="off"', '<tpl if="value"> value="{[Ext.util.Format.htmlEncode(values.value)]}"</tpl>', '<tpl if="name"> name="{name}"</tpl>', '<tpl if="placeholder"> placeholder="{placeholder}"</tpl>', '<tpl if="size"> size="{size}"</tpl>', '<tpl if="maxLength !== undefined"> maxlength="{maxLength}"</tpl>', '<tpl if="readOnly"> readonly="readonly"</tpl>', '<tpl if="disabled"> disabled="disabled"</tpl>', '<tpl if="tabIdx"> tabIndex="{tabIdx}"</tpl>', '<tpl if="fieldStyle"> style="{fieldStyle}"</tpl>', '/>', {compiled: true, disableFormats: true}]); } set { this.attributes["fieldSubTpl"] = value; } }                
                    
                    
        private _forceSelection_default = false;
                    
                    
        [JsonIgnore]
        public Boolean forceSelection { get { return this.attributes.GetOrDefault<Boolean>("forceSelection", false); } set { this.attributes["forceSelection"] = value; } }                
                    
                    
        private _growToLongestValue_default = true;
                    
                    
        [JsonIgnore]
        public Boolean growToLongestValue { get { return this.attributes.GetOrDefault<Boolean>("growToLongestValue", true); } set { this.attributes["growToLongestValue"] = value; } }                
                    
                    
        private _hiddenName_default = "";
                    
                    
        [JsonIgnore]
        public String hiddenName { get { return this.attributes.GetOrDefault<String>("hiddenName", ""); } set { this.attributes["hiddenName"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object listConfig { get { return this.attributes.GetOrDefault<Object>("listConfig", ); } set { this.attributes["listConfig"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number minChars { get { return this.attributes.GetOrDefault<Number>("minChars", ); } set { this.attributes["minChars"] = value; } }                
                    
                    
        private _multiSelect_default = false;
                    
                    
        [JsonIgnore]
        public Boolean multiSelect { get { return this.attributes.GetOrDefault<Boolean>("multiSelect", false); } set { this.attributes["multiSelect"] = value; } }                
                    
                    
        private _pageSize_default = 0;
                    
                    
        [JsonIgnore]
        public Number pageSize { get { return this.attributes.GetOrDefault<Number>("pageSize", 0); } set { this.attributes["pageSize"] = value; } }                
                    
                    
        private _queryCaching_default = true;
                    
                    
        [JsonIgnore]
        public Boolean queryCaching { get { return this.attributes.GetOrDefault<Boolean>("queryCaching", true); } set { this.attributes["queryCaching"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number queryDelay { get { return this.attributes.GetOrDefault<Number>("queryDelay", ); } set { this.attributes["queryDelay"] = value; } }                
                    
                    
        private _queryMode_default = 'remote';
                    
                    
        [JsonIgnore]
        public String queryMode { get { return this.attributes.GetOrDefault<String>("queryMode", 'remote'); } set { this.attributes["queryMode"] = value; } }                
                    
                    
        private _queryParam_default = 'query';
                    
                    
        [JsonIgnore]
        public String queryParam { get { return this.attributes.GetOrDefault<String>("queryParam", 'query'); } set { this.attributes["queryParam"] = value; } }                
                    
                    
        private _selectOnTab_default = true;
                    
                    
        [JsonIgnore]
        public Boolean selectOnTab { get { return this.attributes.GetOrDefault<Boolean>("selectOnTab", true); } set { this.attributes["selectOnTab"] = value; } }                
                    
                    
        public class MultiType_store {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.data.Store m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.data.Store (int m) {
                return new Ext.data.Store { _value = m };
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
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_store store { get { return this.attributes.GetOrDefault<MultiType_store>("store", ); } set { this.attributes["store"] = value; } }                

                    
                    
        public class MultiType_transform {
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
                            
                            
            public static explicit operator int (HTMLElement m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator HTMLElement (int m) {
                return new HTMLElement { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.Element m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Element (int m) {
                return new Ext.Element { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_transform transform { get { return this.attributes.GetOrDefault<MultiType_transform>("transform", ); } set { this.attributes["transform"] = value; } }                

                    
                    
        private _triggerAction_default = 'all';
                    
                    
        [JsonIgnore]
        public String triggerAction { get { return this.attributes.GetOrDefault<String>("triggerAction", 'all'); } set { this.attributes["triggerAction"] = value; } }                
                    
                    
        private _triggerCls_default = 'x-form-arrow-trigger';
                    
                    
        [JsonIgnore]
        public String triggerCls { get { return this.attributes.GetOrDefault<String>("triggerCls", 'x-form-arrow-trigger'); } set { this.attributes["triggerCls"] = value; } }                
                    
                    
        private _typeAhead_default = false;
                    
                    
        [JsonIgnore]
        public Boolean typeAhead { get { return this.attributes.GetOrDefault<Boolean>("typeAhead", false); } set { this.attributes["typeAhead"] = value; } }                
                    
                    
        private _typeAheadDelay_default = 250;
                    
                    
        [JsonIgnore]
        public Number typeAheadDelay { get { return this.attributes.GetOrDefault<Number>("typeAheadDelay", 250); } set { this.attributes["typeAheadDelay"] = value; } }                
                    
                    
        [JsonIgnore]
        public String valueField { get { return this.attributes.GetOrDefault<String>("valueField", ); } set { this.attributes["valueField"] = value; } }                
                    
                    
        [JsonIgnore]
        public String valueNotFoundText { get { return this.attributes.GetOrDefault<String>("valueNotFoundText", ); } set { this.attributes["valueNotFoundText"] = value; } }                
                    
    }
}
