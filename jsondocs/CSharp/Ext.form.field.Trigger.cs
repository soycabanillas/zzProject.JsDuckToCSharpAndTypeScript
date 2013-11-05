using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.Trigger : Ext.form.field.Text {
                    
        private _componentLayout_default = 'triggerfield';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'triggerfield'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _editable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean editable { get { return this.attributes.GetOrDefault<Boolean>("editable", true); } set { this.attributes["editable"] = value; } }                
                    
                    
        private _hideTrigger_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideTrigger { get { return this.attributes.GetOrDefault<Boolean>("hideTrigger", false); } set { this.attributes["hideTrigger"] = value; } }                
                    
                    
        private _readOnly_default = false;
                    
                    
        [JsonIgnore]
        public Boolean readOnly { get { return this.attributes.GetOrDefault<Boolean>("readOnly", false); } set { this.attributes["readOnly"] = value; } }                
                    
                    
        private _repeatTriggerClick_default = false;
                    
                    
        [JsonIgnore]
        public Boolean repeatTriggerClick { get { return this.attributes.GetOrDefault<Boolean>("repeatTriggerClick", false); } set { this.attributes["repeatTriggerClick"] = value; } }                
                    
                    
        private _selectOnFocus_default = false;
                    
                    
        [JsonIgnore]
        public Boolean selectOnFocus { get { return this.attributes.GetOrDefault<Boolean>("selectOnFocus", false); } set { this.attributes["selectOnFocus"] = value; } }                
                    
                    
        private _triggerBaseCls_default = Ext.baseCSSPrefix + 'form-trigger';
                    
                    
        [JsonIgnore]
        public String triggerBaseCls { get { return this.attributes.GetOrDefault<String>("triggerBaseCls", Ext.baseCSSPrefix + 'form-trigger'); } set { this.attributes["triggerBaseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String triggerCls { get { return this.attributes.GetOrDefault<String>("triggerCls", ); } set { this.attributes["triggerCls"] = value; } }                
                    
                    
        private _triggerNoEditCls_default = Ext.baseCSSPrefix + 'trigger-noedit';
                    
                    
        [JsonIgnore]
        public String triggerNoEditCls { get { return this.attributes.GetOrDefault<String>("triggerNoEditCls", Ext.baseCSSPrefix + 'trigger-noedit'); } set { this.attributes["triggerNoEditCls"] = value; } }                
                    
                    
        private _triggerWrapCls_default = Ext.baseCSSPrefix + 'form-trigger-wrap';
                    
                    
        [JsonIgnore]
        public String triggerWrapCls { get { return this.attributes.GetOrDefault<String>("triggerWrapCls", Ext.baseCSSPrefix + 'form-trigger-wrap'); } set { this.attributes["triggerWrapCls"] = value; } }                
                    
    }
}
