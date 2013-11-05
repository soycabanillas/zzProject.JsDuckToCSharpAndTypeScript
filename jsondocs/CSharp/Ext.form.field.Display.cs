using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Display : Ext.form.field.Base {
                    
        private _fieldBodyCls_default = Ext.baseCSSPrefix + 'form-display-field-body';
                    
                    
        [JsonIgnore]
        public String fieldBodyCls { get { return this.attributes.GetOrDefault<String>("fieldBodyCls", Ext.baseCSSPrefix + 'form-display-field-body'); } set { this.attributes["fieldBodyCls"] = value; } }                
                    
                    
        private _fieldCls_default = "x-form-display-field";
                    
                    
        [JsonIgnore]
        public String fieldCls { get { return this.attributes.GetOrDefault<String>("fieldCls", "x-form-display-field"); } set { this.attributes["fieldCls"] = value; } }                
                    
                    
        private _htmlEncode_default = false;
                    
                    
        [JsonIgnore]
        public Boolean htmlEncode { get { return this.attributes.GetOrDefault<Boolean>("htmlEncode", false); } set { this.attributes["htmlEncode"] = value; } }                
                    
                    
        [JsonIgnore]
        public Function renderer { get { return this.attributes.GetOrDefault<Function>("renderer", ); } set { this.attributes["renderer"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object scope { get { return this.attributes.GetOrDefault<Object>("scope", ); } set { this.attributes["scope"] = value; } }                
                    
                    
        private _submitValue_default = false;
                    
                    
        [JsonIgnore]
        public Boolean submitValue { get { return this.attributes.GetOrDefault<Boolean>("submitValue", false); } set { this.attributes["submitValue"] = value; } }                
                    
    }
}
