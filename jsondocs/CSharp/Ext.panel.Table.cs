using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.panel.Table : Ext.panel.Panel {
                    
        private _allowDeselect_default = false;
                    
                    
        [JsonIgnore]
        public Boolean allowDeselect { get { return this.attributes.GetOrDefault<Boolean>("allowDeselect", false); } set { this.attributes["allowDeselect"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean columnLines { get { return this.attributes.GetOrDefault<Boolean>("columnLines", ); } set { this.attributes["columnLines"] = value; } }                
                    
                    
        public class MultiType_columns {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.grid.column.Column[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.grid.column.Column[] (int m) {
                return new Ext.grid.column.Column[] { _value = m };
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
        public MultiType_columns columns { get { return this.attributes.GetOrDefault<MultiType_columns>("columns", ); } set { this.attributes["columns"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean deferRowRender { get { return this.attributes.GetOrDefault<Boolean>("deferRowRender", ); } set { this.attributes["deferRowRender"] = value; } }                
                    
                    
        private _disableSelection_default = false;
                    
                    
        [JsonIgnore]
        public Boolean disableSelection { get { return this.attributes.GetOrDefault<Boolean>("disableSelection", false); } set { this.attributes["disableSelection"] = value; } }                
                    
                    
        [JsonIgnore]
        public String emptyText { get { return this.attributes.GetOrDefault<String>("emptyText", ); } set { this.attributes["emptyText"] = value; } }                
                    
                    
        private _enableColumnHide_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableColumnHide { get { return this.attributes.GetOrDefault<Boolean>("enableColumnHide", true); } set { this.attributes["enableColumnHide"] = value; } }                
                    
                    
        private _enableColumnMove_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableColumnMove { get { return this.attributes.GetOrDefault<Boolean>("enableColumnMove", true); } set { this.attributes["enableColumnMove"] = value; } }                
                    
                    
        private _enableColumnResize_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableColumnResize { get { return this.attributes.GetOrDefault<Boolean>("enableColumnResize", true); } set { this.attributes["enableColumnResize"] = value; } }                
                    
                    
        private _enableLocking_default = false;
                    
                    
        [JsonIgnore]
        public Boolean enableLocking { get { return this.attributes.GetOrDefault<Boolean>("enableLocking", false); } set { this.attributes["enableLocking"] = value; } }                
                    
                    
        public class MultiType_features {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.grid.feature.Feature[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.grid.feature.Feature[] (int m) {
                return new Ext.grid.feature.Feature[] { _value = m };
            }
                            
                            
            public static explicit operator int (Object[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Object[] (int m) {
                return new Object[] { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.enums.Feature[] m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.enums.Feature[] (int m) {
                return new Ext.enums.Feature[] { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_features features { get { return this.attributes.GetOrDefault<MultiType_features>("features", ); } set { this.attributes["features"] = value; } }                

                    
                    
        [JsonIgnore]
        public Boolean forceFit { get { return this.attributes.GetOrDefault<Boolean>("forceFit", ); } set { this.attributes["forceFit"] = value; } }                
                    
                    
        private _hideHeaders_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideHeaders { get { return this.attributes.GetOrDefault<Boolean>("hideHeaders", false); } set { this.attributes["hideHeaders"] = value; } }                
                    
                    
        private _layout_default = 'fit';
                    
                    
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
        public MultiType_layout layout { get { return this.attributes.GetOrDefault<MultiType_layout>("layout", 'fit'); } set { this.attributes["layout"] = value; } }                

                    
                    
        private _multiSelect_default = false;
                    
                    
        [JsonIgnore]
        public Boolean multiSelect { get { return this.attributes.GetOrDefault<Boolean>("multiSelect", false); } set { this.attributes["multiSelect"] = value; } }                
                    
                    
        private _rowLines_default = true;
                    
                    
        [JsonIgnore]
        public Boolean rowLines { get { return this.attributes.GetOrDefault<Boolean>("rowLines", true); } set { this.attributes["rowLines"] = value; } }                
                    
                    
        private _scroll_default = true;
                    
                    
        public class MultiType_scroll {
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
        public MultiType_scroll scroll { get { return this.attributes.GetOrDefault<MultiType_scroll>("scroll", true); } set { this.attributes["scroll"] = value; } }                

                    
                    
        private _sealedColumns_default = false;
                    
                    
        [JsonIgnore]
        public Boolean sealedColumns { get { return this.attributes.GetOrDefault<Boolean>("sealedColumns", false); } set { this.attributes["sealedColumns"] = value; } }                
                    
                    
        public class MultiType_selModel {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.selection.Model m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.selection.Model (int m) {
                return new Ext.selection.Model { _value = m };
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
        public MultiType_selModel selModel { get { return this.attributes.GetOrDefault<MultiType_selModel>("selModel", ); } set { this.attributes["selModel"] = value; } }                

                    
                    
        private _selType_default = 'rowmodel';
                    
                    
        [JsonIgnore]
        public String selType { get { return this.attributes.GetOrDefault<String>("selType", 'rowmodel'); } set { this.attributes["selType"] = value; } }                
                    
                    
        private _simpleSelect_default = false;
                    
                    
        [JsonIgnore]
        public Boolean simpleSelect { get { return this.attributes.GetOrDefault<Boolean>("simpleSelect", false); } set { this.attributes["simpleSelect"] = value; } }                
                    
                    
        private _sortableColumns_default = true;
                    
                    
        [JsonIgnore]
        public Boolean sortableColumns { get { return this.attributes.GetOrDefault<Boolean>("sortableColumns", true); } set { this.attributes["sortableColumns"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.Store store { get { return this.attributes.GetOrDefault<Ext.data.Store>("store", ); } set { this.attributes["store"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object verticalScroller { get { return this.attributes.GetOrDefault<Object>("verticalScroller", ); } set { this.attributes["verticalScroller"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.view.Table view { get { return this.attributes.GetOrDefault<Ext.view.Table>("view", ); } set { this.attributes["view"] = value; } }                
                    
                    
        [JsonIgnore]
        public Object viewConfig { get { return this.attributes.GetOrDefault<Object>("viewConfig", ); } set { this.attributes["viewConfig"] = value; } }                
                    
                    
        [JsonIgnore]
        public String viewType { get { return this.attributes.GetOrDefault<String>("viewType", ); } set { this.attributes["viewType"] = value; } }                
                    
    }
}
