using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.draw.Sprite : Ext.Base {
                    
        [JsonIgnore]
        public Boolean draggable { get { return this.attributes.GetOrDefault<Boolean>("draggable", ); } set { this.attributes["draggable"] = value; } }                
                    
                    
        [JsonIgnore]
        public String fill { get { return this.attributes.GetOrDefault<String>("fill", ); } set { this.attributes["fill"] = value; } }                
                    
                    
        [JsonIgnore]
        public String font { get { return this.attributes.GetOrDefault<String>("font", ); } set { this.attributes["font"] = value; } }                
                    
                    
        public class MultiType_group {
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
        public MultiType_group group { get { return this.attributes.GetOrDefault<MultiType_group>("group", ); } set { this.attributes["group"] = value; } }                

                    
                    
        [JsonIgnore]
        public Number height { get { return this.attributes.GetOrDefault<Number>("height", ); } set { this.attributes["height"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number opacity { get { return this.attributes.GetOrDefault<Number>("opacity", ); } set { this.attributes["opacity"] = value; } }                
                    
                    
        [JsonIgnore]
        public String path { get { return this.attributes.GetOrDefault<String>("path", ); } set { this.attributes["path"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number radius { get { return this.attributes.GetOrDefault<Number>("radius", ); } set { this.attributes["radius"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number radiusX { get { return this.attributes.GetOrDefault<Number>("radiusX", ); } set { this.attributes["radiusX"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number radiusY { get { return this.attributes.GetOrDefault<Number>("radiusY", ); } set { this.attributes["radiusY"] = value; } }                
                    
                    
        [JsonIgnore]
        public String src { get { return this.attributes.GetOrDefault<String>("src", ); } set { this.attributes["src"] = value; } }                
                    
                    
        [JsonIgnore]
        public String stroke { get { return this.attributes.GetOrDefault<String>("stroke", ); } set { this.attributes["stroke"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number stroke-width { get { return this.attributes.GetOrDefault<Number>("stroke-width", ); } set { this.attributes["stroke-width"] = value; } }                
                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", ); } set { this.attributes["text"] = value; } }                
                    
                    
        [JsonIgnore]
        public String type { get { return this.attributes.GetOrDefault<String>("type", ); } set { this.attributes["type"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number width { get { return this.attributes.GetOrDefault<Number>("width", ); } set { this.attributes["width"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number x { get { return this.attributes.GetOrDefault<Number>("x", ); } set { this.attributes["x"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number y { get { return this.attributes.GetOrDefault<Number>("y", ); } set { this.attributes["y"] = value; } }                
                    
    }
}
