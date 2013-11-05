using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.RadioGroup : Ext.form.CheckboxGroup {
                    
        private _allowBlank_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowBlank { get { return this.attributes.GetOrDefault<Boolean>("allowBlank", true); } set { this.attributes["allowBlank"] = value; } }                
                    
                    
        private _blankText_default = 'You must select one item in this group';
                    
                    
        [JsonIgnore]
        public String blankText { get { return this.attributes.GetOrDefault<String>("blankText", 'You must select one item in this group'); } set { this.attributes["blankText"] = value; } }                
                    
                    
        private _defaultType_default = 'radiofield';
                    
                    
        [JsonIgnore]
        public String defaultType { get { return this.attributes.GetOrDefault<String>("defaultType", 'radiofield'); } set { this.attributes["defaultType"] = value; } }                
                    
                    
        public class MultiType_items {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.form.field.Radio[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.form.field.Radio[] (int m) {
                return new Ext.form.field.Radio[] { _value = m };
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
        public MultiType_items items { get { return this.attributes.GetOrDefault<MultiType_items>("items", ); } set { this.attributes["items"] = value; } }                

                    
    }
}
