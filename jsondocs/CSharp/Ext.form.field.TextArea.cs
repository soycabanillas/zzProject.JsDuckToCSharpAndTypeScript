using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.TextArea : Ext.form.field.Text {
                    
        private _cols_default = 20;
                    
                    
        [JsonIgnore]
        public Number cols { get { return this.attributes.GetOrDefault<Number>("cols", 20); } set { this.attributes["cols"] = value; } }                
                    
                    
        private _componentLayout_default = 'textareafield';
                    
                    
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
        public MultiType_componentLayout componentLayout { get { return this.attributes.GetOrDefault<MultiType_componentLayout>("componentLayout", 'textareafield'); } set { this.attributes["componentLayout"] = value; } }                

                    
                    
        private _enterIsSpecial_default = false;
                    
                    
        [JsonIgnore]
        public Boolean enterIsSpecial { get { return this.attributes.GetOrDefault<Boolean>("enterIsSpecial", false); } set { this.attributes["enterIsSpecial"] = value; } }                
                    
                    
        private _growAppend_default = '\n-';
                    
                    
        [JsonIgnore]
        public String growAppend { get { return this.attributes.GetOrDefault<String>("growAppend", '\n-'); } set { this.attributes["growAppend"] = value; } }                
                    
                    
        private _growMax_default = 1000;
                    
                    
        [JsonIgnore]
        public Number growMax { get { return this.attributes.GetOrDefault<Number>("growMax", 1000); } set { this.attributes["growMax"] = value; } }                
                    
                    
        private _growMin_default = 60;
                    
                    
        [JsonIgnore]
        public Number growMin { get { return this.attributes.GetOrDefault<Number>("growMin", 60); } set { this.attributes["growMin"] = value; } }                
                    
                    
        private _preventScrollbars_default = false;
                    
                    
        [JsonIgnore]
        public Boolean preventScrollbars { get { return this.attributes.GetOrDefault<Boolean>("preventScrollbars", false); } set { this.attributes["preventScrollbars"] = value; } }                
                    
                    
        private _rows_default = 4;
                    
                    
        [JsonIgnore]
        public Number rows { get { return this.attributes.GetOrDefault<Number>("rows", 4); } set { this.attributes["rows"] = value; } }                
                    
    }
}
