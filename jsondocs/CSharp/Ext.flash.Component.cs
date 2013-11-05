using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.flash.Component : Ext.Component {
                    
        private _backgroundColor_default = "#ffffff";
                    
                    
        [JsonIgnore]
        public String backgroundColor { get { return this.attributes.GetOrDefault<String>("backgroundColor", "#ffffff"); } set { this.attributes["backgroundColor"] = value; } }                
                    
                    
        private _expressInstall_default = false;
                    
                    
        [JsonIgnore]
        public Boolean expressInstall { get { return this.attributes.GetOrDefault<Boolean>("expressInstall", false); } set { this.attributes["expressInstall"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object flashAttributes { get { return this.attributes.GetOrDefault<Object>("flashAttributes", ); } set { this.attributes["flashAttributes"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object flashParams { get { return this.attributes.GetOrDefault<Object>("flashParams", ); } set { this.attributes["flashParams"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object flashVars { get { return this.attributes.GetOrDefault<Object>("flashVars", ); } set { this.attributes["flashVars"] = value; } }                
                    
                    
        private _flashVersion_default = "9.0.115";
                    
                    
        [JsonIgnore]
        public String flashVersion { get { return this.attributes.GetOrDefault<String>("flashVersion", "9.0.115"); } set { this.attributes["flashVersion"] = value; } }                
                    
                    
        private _renderTpl_default = ['<div id="{swfId}"></div>'];
                    
                    
        public class MultiType_renderTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
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
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<div id="{swfId}"></div>']); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        private _swfHeight_default = "100%";
                    
                    
        public class MultiType_swfHeight {
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
                            
                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_swfHeight swfHeight { get { return this.attributes.GetOrDefault<MultiType_swfHeight>("swfHeight", "100%"); } set { this.attributes["swfHeight"] = value; } }                

                    
                    
        private _swfWidth_default = "100%";
                    
                    
        public class MultiType_swfWidth {
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
                            
                            
            public static explicit operator int (Double m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Double (int m) {
                return new Double { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_swfWidth swfWidth { get { return this.attributes.GetOrDefault<MultiType_swfWidth>("swfWidth", "100%"); } set { this.attributes["swfWidth"] = value; } }                

                    
                    
        [JsonIgnore]
        public String url { get { return this.attributes.GetOrDefault<String>("url", ); } set { this.attributes["url"] = value; } }                
                    
                    
        private _wmode_default = "opaque";
                    
                    
        [JsonIgnore]
        public String wmode { get { return this.attributes.GetOrDefault<String>("wmode", "opaque"); } set { this.attributes["wmode"] = value; } }                
                    
    }
}
