using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Text : Ext.form.field.Base {
                    
        private _allowBlank_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowBlank { get { return this.attributes.GetOrDefault<Boolean>("allowBlank", true); } set { this.attributes["allowBlank"] = value; } }                
                    
                    
        private _allowOnlyWhitespace_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowOnlyWhitespace { get { return this.attributes.GetOrDefault<Boolean>("allowOnlyWhitespace", true); } set { this.attributes["allowOnlyWhitespace"] = value; } }                
                    
                    
        private _blankText_default = 'This field is required';
                    
                    
        [JsonIgnore]
        public String blankText { get { return this.attributes.GetOrDefault<String>("blankText", 'This field is required'); } set { this.attributes["blankText"] = value; } }                
                    
                    
        private _disableKeyFilter_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disableKeyFilter { get { return this.attributes.GetOrDefault<Boolean>("disableKeyFilter", false); } set { this.attributes["disableKeyFilter"] = value; } }                
                    
                    
        private _emptyCls_default = 'x-form-empty-field';
                    
                    
        [JsonIgnore]
        public String emptyCls { get { return this.attributes.GetOrDefault<String>("emptyCls", 'x-form-empty-field'); } set { this.attributes["emptyCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String emptyText { get { return this.attributes.GetOrDefault<String>("emptyText", ); } set { this.attributes["emptyText"] = value; } }                
                    
                    
        private _enableKeyEvents_default = false;
                    
                    
        [JsonIgnore]
        public Boolean enableKeyEvents { get { return this.attributes.GetOrDefault<Boolean>("enableKeyEvents", false); } set { this.attributes["enableKeyEvents"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean enforceMaxLength { get { return this.attributes.GetOrDefault<Boolean>("enforceMaxLength", ); } set { this.attributes["enforceMaxLength"] = value; } }                
                    
                    
        private _grow_default = false;
                    
                    
        [JsonIgnore]
        public Boolean grow { get { return this.attributes.GetOrDefault<Boolean>("grow", false); } set { this.attributes["grow"] = value; } }                
                    
                    
        private _growAppend_default = 'W';
                    
                    
        [JsonIgnore]
        public String growAppend { get { return this.attributes.GetOrDefault<String>("growAppend", 'W'); } set { this.attributes["growAppend"] = value; } }                
                    
                    
        private _growMax_default = 800;
                    
                    
        [JsonIgnore]
        public Number growMax { get { return this.attributes.GetOrDefault<Number>("growMax", 800); } set { this.attributes["growMax"] = value; } }                
                    
                    
        private _growMin_default = 30;
                    
                    
        [JsonIgnore]
        public Number growMin { get { return this.attributes.GetOrDefault<Number>("growMin", 30); } set { this.attributes["growMin"] = value; } }                
                    
                    
        [JsonIgnore]
        public RegExp maskRe { get { return this.attributes.GetOrDefault<RegExp>("maskRe", ); } set { this.attributes["maskRe"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number maxLength { get { return this.attributes.GetOrDefault<Number>("maxLength", ); } set { this.attributes["maxLength"] = value; } }                
                    
                    
        private _maxLengthText_default = 'The maximum length for this field is {0}';
                    
                    
        [JsonIgnore]
        public String maxLengthText { get { return this.attributes.GetOrDefault<String>("maxLengthText", 'The maximum length for this field is {0}'); } set { this.attributes["maxLengthText"] = value; } }                
                    
                    
        private _minLength_default = 0;
                    
                    
        [JsonIgnore]
        public Number minLength { get { return this.attributes.GetOrDefault<Number>("minLength", 0); } set { this.attributes["minLength"] = value; } }                
                    
                    
        private _minLengthText_default = 'The minimum length for this field is {0}';
                    
                    
        [JsonIgnore]
        public String minLengthText { get { return this.attributes.GetOrDefault<String>("minLengthText", 'The minimum length for this field is {0}'); } set { this.attributes["minLengthText"] = value; } }                
                    
                    
        [JsonIgnore]
        public RegExp regex { get { return this.attributes.GetOrDefault<RegExp>("regex", ); } set { this.attributes["regex"] = value; } }                
                    
                    
        private _regexText_default = '';
                    
                    
        [JsonIgnore]
        public String regexText { get { return this.attributes.GetOrDefault<String>("regexText", ''); } set { this.attributes["regexText"] = value; } }                
                    
                    
        private _requiredCls_default = 'x-form-required-field';
                    
                    
        [JsonIgnore]
        public String requiredCls { get { return this.attributes.GetOrDefault<String>("requiredCls", 'x-form-required-field'); } set { this.attributes["requiredCls"] = value; } }                
                    
                    
        private _selectOnFocus_default = false;
                    
                    
        [JsonIgnore]
        public Boolean selectOnFocus { get { return this.attributes.GetOrDefault<Boolean>("selectOnFocus", false); } set { this.attributes["selectOnFocus"] = value; } }                
                    
                    
        private _size_default = 20;
                    
                    
        [JsonIgnore]
        public Number size { get { return this.attributes.GetOrDefault<Number>("size", 20); } set { this.attributes["size"] = value; } }                
                    
                    
        [JsonIgnore]
        public RegExp stripCharsRe { get { return this.attributes.GetOrDefault<RegExp>("stripCharsRe", ); } set { this.attributes["stripCharsRe"] = value; } }                
                    
                    
        private _validateBlank_default = false;
                    
                    
        [JsonIgnore]
        public Boolean validateBlank { get { return this.attributes.GetOrDefault<Boolean>("validateBlank", false); } set { this.attributes["validateBlank"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function validator { get { return this.attributes.GetOrDefault<Function>("validator", ); } set { this.attributes["validator"] = value; } }                
                    
                    
        [JsonIgnore]
        public String vtype { get { return this.attributes.GetOrDefault<String>("vtype", ); } set { this.attributes["vtype"] = value; } }                
                    
                    
        [JsonIgnore]
        public String vtypeText { get { return this.attributes.GetOrDefault<String>("vtypeText", ); } set { this.attributes["vtypeText"] = value; } }                
                    
    }
}
