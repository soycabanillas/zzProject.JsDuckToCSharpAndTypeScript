using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.container.AbstractContainer : Ext.Component {
                    
        public class MultiType_activeItem {
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
        public MultiType_activeItem activeItem { get { return this.attributes.GetOrDefault<MultiType_activeItem>("activeItem", ); } set { this.attributes["activeItem"] = value; } }                

                    
                    
        private _autoDestroy_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoDestroy { get { return this.attributes.GetOrDefault<Boolean>("autoDestroy", true); } set { this.attributes["autoDestroy"] = value; } }                
                    
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'container';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'container'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String[] bubbleEvents { get { return this.attributes.GetOrDefault<String[]>("bubbleEvents", ); } set { this.attributes["bubbleEvents"] = value; } }                
                    
                    
        private _defaultType_default = "panel";
                    
                    
        [JsonIgnore]
        public String defaultType { get { return this.attributes.GetOrDefault<String>("defaultType", "panel"); } set { this.attributes["defaultType"] = value; } }                
                    
                    
        public class MultiType_defaults {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
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
        public MultiType_defaults defaults { get { return this.attributes.GetOrDefault<MultiType_defaults>("defaults", ); } set { this.attributes["defaults"] = value; } }                

                    
                    
        private _detachOnRemove_default = true;
                    
                    
        [JsonIgnore]
        public Boolean detachOnRemove { get { return this.attributes.GetOrDefault<Boolean>("detachOnRemove", true); } set { this.attributes["detachOnRemove"] = value; } }                
                    
                    
        public class MultiType_items {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Object m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object (int m) {
                return new Object { _value = m };
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

                    
                    
        public class MultiType_layout {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.enums.Layout m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.enums.Layout (int m) {
                return new Ext.enums.Layout { _value = m };
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", ); } set { this.attributes["layout"] = value; } }                

                    
                    
        private _renderTpl_default = '{%this.renderContainer(out,values)%}';
                    
                    
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
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", '{%this.renderContainer(out,values)%}'); } set { this.attributes["renderTpl"] = value; } }                

                    
                    
        private _suspendLayout_default = false;
                    
                    
        [JsonIgnore]
        public Boolean suspendLayout { get { return this.attributes.GetOrDefault<Boolean>("suspendLayout", false); } set { this.attributes["suspendLayout"] = value; } }                
                    
    }
}
