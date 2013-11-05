using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.resizer.Resizer : Ext.Base {
                    
        public class MultiType_constrainTo {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.Element m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Element (int m) {
                return new Ext.Element { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.util.Region m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.util.Region (int m) {
                return new Ext.util.Region { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_constrainTo constrainTo { get { return this.attributes.GetOrDefault<MultiType_constrainTo>("constrainTo", ); } set { this.attributes["constrainTo"] = value; } }                

                    
                    
        private _dynamic_default = true;
                    
                    
        [JsonIgnore]
        public Boolean dynamic { get { return this.attributes.GetOrDefault<Boolean>("dynamic", true); } set { this.attributes["dynamic"] = value; } }                
                    
                    
        private _handles_default = 's e se';
                    
                    
        [JsonIgnore]
        public String handles { get { return this.attributes.GetOrDefault<String>("handles", 's e se'); } set { this.attributes["handles"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number height { get { return this.attributes.GetOrDefault<Number>("height", ); } set { this.attributes["height"] = value; } }                
                    
                    
        private _heightIncrement_default = 0;
                    
                    
        [JsonIgnore]
        public Number heightIncrement { get { return this.attributes.GetOrDefault<Number>("heightIncrement", 0); } set { this.attributes["heightIncrement"] = value; } }                
                    
                    
        private _maxHeight_default = 10000;
                    
                    
        [JsonIgnore]
        public Number maxHeight { get { return this.attributes.GetOrDefault<Number>("maxHeight", 10000); } set { this.attributes["maxHeight"] = value; } }                
                    
                    
        private _maxWidth_default = 10000;
                    
                    
        [JsonIgnore]
        public Number maxWidth { get { return this.attributes.GetOrDefault<Number>("maxWidth", 10000); } set { this.attributes["maxWidth"] = value; } }                
                    
                    
        private _minHeight_default = 20;
                    
                    
        [JsonIgnore]
        public Number minHeight { get { return this.attributes.GetOrDefault<Number>("minHeight", 20); } set { this.attributes["minHeight"] = value; } }                
                    
                    
        private _minWidth_default = 20;
                    
                    
        [JsonIgnore]
        public Number minWidth { get { return this.attributes.GetOrDefault<Number>("minWidth", 20); } set { this.attributes["minWidth"] = value; } }                
                    
                    
        private _pinned_default = false;
                    
                    
        [JsonIgnore]
        public Boolean pinned { get { return this.attributes.GetOrDefault<Boolean>("pinned", false); } set { this.attributes["pinned"] = value; } }                
                    
                    
        private _preserveRatio_default = false;
                    
                    
        [JsonIgnore]
        public Boolean preserveRatio { get { return this.attributes.GetOrDefault<Boolean>("preserveRatio", false); } set { this.attributes["preserveRatio"] = value; } }                
                    
                    
        public class MultiType_target {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.Element m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Element (int m) {
                return new Ext.Element { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.Component m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Component (int m) {
                return new Ext.Component { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_target target { get { return this.attributes.GetOrDefault<MultiType_target>("target", ); } set { this.attributes["target"] = value; } }                

                    
                    
        private _transparent_default = false;
                    
                    
        [JsonIgnore]
        public Boolean transparent { get { return this.attributes.GetOrDefault<Boolean>("transparent", false); } set { this.attributes["transparent"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number width { get { return this.attributes.GetOrDefault<Number>("width", ); } set { this.attributes["width"] = value; } }                
                    
                    
        private _widthIncrement_default = 0;
                    
                    
        [JsonIgnore]
        public Number widthIncrement { get { return this.attributes.GetOrDefault<Number>("widthIncrement", 0); } set { this.attributes["widthIncrement"] = value; } }                
                    
    }
}
