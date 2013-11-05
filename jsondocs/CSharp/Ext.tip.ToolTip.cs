using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.tip.ToolTip : Ext.tip.Tip {
                    
        [JsonIgnore]
        public String anchor { get { return this.attributes.GetOrDefault<String>("anchor", ); } set { this.attributes["anchor"] = value; } }                
                    
                    
        private _anchorOffset_default = 0;
                    
                    
        [JsonIgnore]
        public Number anchorOffset { get { return this.attributes.GetOrDefault<Number>("anchorOffset", 0); } set { this.attributes["anchorOffset"] = value; } }                
                    
                    
        private _anchorToTarget_default = true;
                    
                    
        [JsonIgnore]
        public Boolean anchorToTarget { get { return this.attributes.GetOrDefault<Boolean>("anchorToTarget", true); } set { this.attributes["anchorToTarget"] = value; } }                
                    
                    
        private _autoHide_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoHide { get { return this.attributes.GetOrDefault<Boolean>("autoHide", true); } set { this.attributes["autoHide"] = value; } }                
                    
                    
        [JsonIgnore]
        public String delegate { get { return this.attributes.GetOrDefault<String>("delegate", ); } set { this.attributes["delegate"] = value; } }                
                    
                    
        private _dismissDelay_default = 5000;
                    
                    
        [JsonIgnore]
        public Number dismissDelay { get { return this.attributes.GetOrDefault<Number>("dismissDelay", 5000); } set { this.attributes["dismissDelay"] = value; } }                
                    
                    
        private _hideDelay_default = 200;
                    
                    
        [JsonIgnore]
        public Number hideDelay { get { return this.attributes.GetOrDefault<Number>("hideDelay", 200); } set { this.attributes["hideDelay"] = value; } }                
                    
                    
        private _mouseOffset_default = [15,18];
                    
                    
        [JsonIgnore]
        public Number[] mouseOffset { get { return this.attributes.GetOrDefault<Number[]>("mouseOffset", [15,18]); } set { this.attributes["mouseOffset"] = value; } }                
                    
                    
        private _showDelay_default = 500;
                    
                    
        [JsonIgnore]
        public Number showDelay { get { return this.attributes.GetOrDefault<Number>("showDelay", 500); } set { this.attributes["showDelay"] = value; } }                
                    
                    
        public class MultiType_target {
            public new Type GetType()
            {
                return _value.GetType();
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
        public MultiType_target target { get { return this.attributes.GetOrDefault<MultiType_target>("target", ); } set { this.attributes["target"] = value; } }                

                    
                    
        private _trackMouse_default = false;
                    
                    
        [JsonIgnore]
        public Boolean trackMouse { get { return this.attributes.GetOrDefault<Boolean>("trackMouse", false); } set { this.attributes["trackMouse"] = value; } }                
                    
    }
}
