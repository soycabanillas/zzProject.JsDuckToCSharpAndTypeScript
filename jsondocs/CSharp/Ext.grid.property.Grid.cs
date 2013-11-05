using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.property.Grid : Ext.grid.Panel {
                    
        private _columnLines_default = true;
                    
                    
        [JsonIgnore]
        public Boolean columnLines { get { return this.attributes.GetOrDefault<Boolean>("columnLines", true); } set { this.attributes["columnLines"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object customEditors { get { return this.attributes.GetOrDefault<Object>("customEditors", ); } set { this.attributes["customEditors"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object customRenderers { get { return this.attributes.GetOrDefault<Object>("customRenderers", ); } set { this.attributes["customRenderers"] = value; } }                
                    
                    
        private _enableColumnMove_default = false;
                    
                    
        [JsonIgnore]
        public Boolean enableColumnMove { get { return this.attributes.GetOrDefault<Boolean>("enableColumnMove", false); } set { this.attributes["enableColumnMove"] = value; } }                
                    
                    
        private _inferTypes_default = true;
                    
                    
        [JsonIgnore]
        public Boolean inferTypes { get { return this.attributes.GetOrDefault<Boolean>("inferTypes", true); } set { this.attributes["inferTypes"] = value; } }                
                    
                    
        private _nameColumnWidth_default = 115;
                    
                    
        public class MultiType_nameColumnWidth {
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
        public MultiType_nameColumnWidth nameColumnWidth { get { return this.attributes.GetOrDefault<MultiType_nameColumnWidth>("nameColumnWidth", 115); } set { this.attributes["nameColumnWidth"] = value; } }                

                    
                    
        private _nameField_default = 'name';
                    
                    
        [JsonIgnore]
        public String nameField { get { return this.attributes.GetOrDefault<String>("nameField", 'name'); } set { this.attributes["nameField"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object propertyNames { get { return this.attributes.GetOrDefault<Object>("propertyNames", ); } set { this.attributes["propertyNames"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object source { get { return this.attributes.GetOrDefault<Object>("source", ); } set { this.attributes["source"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object sourceConfig { get { return this.attributes.GetOrDefault<Object>("sourceConfig", ); } set { this.attributes["sourceConfig"] = value; } }                
                    
                    
        private _valueField_default = 'value';
                    
                    
        [JsonIgnore]
        public String valueField { get { return this.attributes.GetOrDefault<String>("valueField", 'value'); } set { this.attributes["valueField"] = value; } }                
                    
    }
}
