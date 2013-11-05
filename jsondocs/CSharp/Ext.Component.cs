using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.Component : Ext.AbstractComponent {
                    
        private _autoScroll_default = false;
                    
                    
        [JsonIgnore]
        public Boolean autoScroll { get { return this.attributes.GetOrDefault<Boolean>("autoScroll", false); } set { this.attributes["autoScroll"] = value; } }                
                    
                    
        private _columnWidth_default = undefined;
                    
                    
        public class MultiType_columnWidth {
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
        public MultiType_columnWidth columnWidth { get { return this.attributes.GetOrDefault<MultiType_columnWidth>("columnWidth", undefined); } set { this.attributes["columnWidth"] = value; } }                

                    
                    
        public class MultiType_constrainTo {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.util.Region m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.util.Region (int m) {
                return new Ext.util.Region { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.Element m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Element (int m) {
                return new Ext.Element { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_constrainTo constrainTo { get { return this.attributes.GetOrDefault<MultiType_constrainTo>("constrainTo", ); } set { this.attributes["constrainTo"] = value; } }                

                    
                    
        public class MultiType_constraintInsets {
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
        public MultiType_constraintInsets constraintInsets { get { return this.attributes.GetOrDefault<MultiType_constraintInsets>("constraintInsets", ); } set { this.attributes["constraintInsets"] = value; } }                

                    
                    
        private _defaultAlign_default = "tl-bl?";
                    
                    
        [JsonIgnore]
        public String defaultAlign { get { return this.attributes.GetOrDefault<String>("defaultAlign", "tl-bl?"); } set { this.attributes["defaultAlign"] = value; } }                
                    
                    
        private _draggable_default = false;
                    
                    
        public class MultiType_draggable {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
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
        public MultiType_draggable draggable { get { return this.attributes.GetOrDefault<MultiType_draggable>("draggable", false); } set { this.attributes["draggable"] = value; } }                

                    
                    
        private _floating_default = false;
                    
                    
        [JsonIgnore]
        public Boolean floating { get { return this.attributes.GetOrDefault<Boolean>("floating", false); } set { this.attributes["floating"] = value; } }                
                    
                    
        private _formBind_default = false;
                    
                    
        [JsonIgnore]
        public Boolean formBind { get { return this.attributes.GetOrDefault<Boolean>("formBind", false); } set { this.attributes["formBind"] = value; } }                
                    
                    
        [JsonIgnore]
        public String overflowX { get { return this.attributes.GetOrDefault<String>("overflowX", ); } set { this.attributes["overflowX"] = value; } }                
                    
                    
        [JsonIgnore]
        public String overflowY { get { return this.attributes.GetOrDefault<String>("overflowY", ); } set { this.attributes["overflowY"] = value; } }                
                    
                    
        private _region_default = undefined;
                    
                    
        public class MultiType_region {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int ("north" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "north" (int m) {
                return new "north" { _value = m };
            }
                            
                            
            public static explicit operator int ("south" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "south" (int m) {
                return new "south" { _value = m };
            }
                            
                            
            public static explicit operator int ("east" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "east" (int m) {
                return new "east" { _value = m };
            }
                            
                            
            public static explicit operator int ("west" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "west" (int m) {
                return new "west" { _value = m };
            }
                            
                            
            public static explicit operator int ("center" m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator "center" (int m) {
                return new "center" { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_region region { get { return this.attributes.GetOrDefault<MultiType_region>("region", undefined); } set { this.attributes["region"] = value; } }                

                    
                    
        public class MultiType_resizable {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
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
        public MultiType_resizable resizable { get { return this.attributes.GetOrDefault<MultiType_resizable>("resizable", ); } set { this.attributes["resizable"] = value; } }                

                    
                    
        private _resizeHandles_default = 'all';
                    
                    
        [JsonIgnore]
        public String resizeHandles { get { return this.attributes.GetOrDefault<String>("resizeHandles", 'all'); } set { this.attributes["resizeHandles"] = value; } }                
                    
                    
        private _toFrontOnShow_default = true;
                    
                    
        [JsonIgnore]
        public Boolean toFrontOnShow { get { return this.attributes.GetOrDefault<Boolean>("toFrontOnShow", true); } set { this.attributes["toFrontOnShow"] = value; } }                
                    
    }
}
