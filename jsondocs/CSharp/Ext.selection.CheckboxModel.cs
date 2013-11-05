using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.selection.CheckboxModel : Ext.selection.RowModel {
                    
        private _checkOnly_default = false;
                    
                    
        [JsonIgnore]
        public Boolean checkOnly { get { return this.attributes.GetOrDefault<Boolean>("checkOnly", false); } set { this.attributes["checkOnly"] = value; } }                
                    
                    
        private _checkSelector_default = "x-grid-row-checker";
                    
                    
        [JsonIgnore]
        public String checkSelector { get { return this.attributes.GetOrDefault<String>("checkSelector", "x-grid-row-checker"); } set { this.attributes["checkSelector"] = value; } }                
                    
                    
        private _injectCheckbox_default = 0;
                    
                    
        public class MultiType_injectCheckbox {
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
        public MultiType_injectCheckbox injectCheckbox { get { return this.attributes.GetOrDefault<MultiType_injectCheckbox>("injectCheckbox", 0); } set { this.attributes["injectCheckbox"] = value; } }                

                    
                    
        private _mode_default = 'MULTI';
                    
                    
        public class MultiType_mode {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int ("SINGLE" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "SINGLE" (int m) {
                return new "SINGLE" { _value = m };
            }
                            
                            
            public static explicit operator int ("SIMPLE" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "SIMPLE" (int m) {
                return new "SIMPLE" { _value = m };
            }
                            
                            
            public static explicit operator int ("MULTI" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "MULTI" (int m) {
                return new "MULTI" { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_mode mode { get { return this.attributes.GetOrDefault<MultiType_mode>("mode", 'MULTI'); } set { this.attributes["mode"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean showHeaderCheckbox { get { return this.attributes.GetOrDefault<Boolean>("showHeaderCheckbox", ); } set { this.attributes["showHeaderCheckbox"] = value; } }                
                    
    }
}
