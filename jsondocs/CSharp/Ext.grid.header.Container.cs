using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.header.Container : Ext.container.Container {
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'grid-header-ct';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'grid-header-ct'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        private _border_default = true;
                    
                    
        public class MultiType_border {
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
                            
                            
            public static explicit operator int (Boolean m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Boolean (int m) {
                return new Boolean { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_border border { get { return this.attributes.GetOrDefault<MultiType_border>("border", true); } set { this.attributes["border"] = value; } }                

                    
                    
        private _defaultType_default = 'gridcolumn';
                    
                    
        [JsonIgnore]
        public String defaultType { get { return this.attributes.GetOrDefault<String>("defaultType", 'gridcolumn'); } set { this.attributes["defaultType"] = value; } }                
                    
                    
        private _defaultWidth_default = 100;
                    
                    
        [JsonIgnore]
        public Number defaultWidth { get { return this.attributes.GetOrDefault<Number>("defaultWidth", 100); } set { this.attributes["defaultWidth"] = value; } }                
                    
                    
        private _detachOnRemove_default = false;
                    
                    
        [JsonIgnore]
        public Boolean detachOnRemove { get { return this.attributes.GetOrDefault<Boolean>("detachOnRemove", false); } set { this.attributes["detachOnRemove"] = value; } }                
                    
                    
        private _enableColumnHide_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableColumnHide { get { return this.attributes.GetOrDefault<Boolean>("enableColumnHide", true); } set { this.attributes["enableColumnHide"] = value; } }                
                    
                    
        private _sealed_default = false;
                    
                    
        [JsonIgnore]
        public Boolean sealed { get { return this.attributes.GetOrDefault<Boolean>("sealed", false); } set { this.attributes["sealed"] = value; } }                
                    
                    
        private _sortable_default = true;
                    
                    
        [JsonIgnore]
        public Boolean sortable { get { return this.attributes.GetOrDefault<Boolean>("sortable", true); } set { this.attributes["sortable"] = value; } }                
                    
                    
        private _weight_default = 100;
                    
                    
        [JsonIgnore]
        public Number weight { get { return this.attributes.GetOrDefault<Number>("weight", 100); } set { this.attributes["weight"] = value; } }                
                    
    }
}
