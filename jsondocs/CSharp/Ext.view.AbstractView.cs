using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.view.AbstractView : Ext.Component {
                    
        private _blockRefresh_default = false;
                    
                    
        [JsonIgnore]
        public Boolean blockRefresh { get { return this.attributes.GetOrDefault<Boolean>("blockRefresh", false); } set { this.attributes["blockRefresh"] = value; } }                
                    
                    
        private _deferEmptyText_default = true;
                    
                    
        [JsonIgnore]
        public Boolean deferEmptyText { get { return this.attributes.GetOrDefault<Boolean>("deferEmptyText", true); } set { this.attributes["deferEmptyText"] = value; } }                
                    
                    
        private _deferInitialRefresh_default = true;
                    
                    
        [JsonIgnore]
        public Boolean deferInitialRefresh { get { return this.attributes.GetOrDefault<Boolean>("deferInitialRefresh", true); } set { this.attributes["deferInitialRefresh"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean disableSelection { get { return this.attributes.GetOrDefault<Boolean>("disableSelection", ); } set { this.attributes["disableSelection"] = value; } }                
                    
                    
        private _emptyText_default = "";
                    
                    
        [JsonIgnore]
        public String emptyText { get { return this.attributes.GetOrDefault<String>("emptyText", ""); } set { this.attributes["emptyText"] = value; } }                
                    
                    
        private _itemCls_default = Ext.baseCSSPrefix + 'dataview-item';
                    
                    
        [JsonIgnore]
        public String itemCls { get { return this.attributes.GetOrDefault<String>("itemCls", Ext.baseCSSPrefix + 'dataview-item'); } set { this.attributes["itemCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public String itemSelector { get { return this.attributes.GetOrDefault<String>("itemSelector", ); } set { this.attributes["itemSelector"] = value; } }                
                    
                    
        public class MultiType_itemTpl {
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
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_itemTpl itemTpl { get { return this.attributes.GetOrDefault<MultiType_itemTpl>("itemTpl", ); } set { this.attributes["itemTpl"] = value; } }                

                    
                    
        private _loadMask_default = true;
                    
                    
        public class MultiType_loadMask {
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
        public MultiType_loadMask loadMask { get { return this.attributes.GetOrDefault<MultiType_loadMask>("loadMask", true); } set { this.attributes["loadMask"] = value; } }                

                    
                    
        [JsonIgnore]
        public String loadingCls { get { return this.attributes.GetOrDefault<String>("loadingCls", ); } set { this.attributes["loadingCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number loadingHeight { get { return this.attributes.GetOrDefault<Number>("loadingHeight", ); } set { this.attributes["loadingHeight"] = value; } }                
                    
                    
        private _loadingText_default = 'Loading...';
                    
                    
        [JsonIgnore]
        public String loadingText { get { return this.attributes.GetOrDefault<String>("loadingText", 'Loading...'); } set { this.attributes["loadingText"] = value; } }                
                    
                    
        private _multiSelect_default = false;
                    
                    
        [JsonIgnore]
        public Boolean multiSelect { get { return this.attributes.GetOrDefault<Boolean>("multiSelect", false); } set { this.attributes["multiSelect"] = value; } }                
                    
                    
        [JsonIgnore]
        public String overItemCls { get { return this.attributes.GetOrDefault<String>("overItemCls", ); } set { this.attributes["overItemCls"] = value; } }                
                    
                    
        private _preserveScrollOnRefresh_default = false;
                    
                    
        [JsonIgnore]
        public Boolean preserveScrollOnRefresh { get { return this.attributes.GetOrDefault<Boolean>("preserveScrollOnRefresh", false); } set { this.attributes["preserveScrollOnRefresh"] = value; } }                
                    
                    
        private _selectedItemCls_default = Ext.baseCSSPrefix + 'item-selected';
                    
                    
        [JsonIgnore]
        public String selectedItemCls { get { return this.attributes.GetOrDefault<String>("selectedItemCls", Ext.baseCSSPrefix + 'item-selected'); } set { this.attributes["selectedItemCls"] = value; } }                
                    
                    
        private _simpleSelect_default = false;
                    
                    
        [JsonIgnore]
        public Boolean simpleSelect { get { return this.attributes.GetOrDefault<Boolean>("simpleSelect", false); } set { this.attributes["simpleSelect"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean singleSelect { get { return this.attributes.GetOrDefault<Boolean>("singleSelect", ); } set { this.attributes["singleSelect"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.Store store { get { return this.attributes.GetOrDefault<Ext.data.Store>("store", ); } set { this.attributes["store"] = value; } }                
                    
                    
        public class MultiType_tpl {
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
                            
                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_tpl tpl { get { return this.attributes.GetOrDefault<MultiType_tpl>("tpl", ); } set { this.attributes["tpl"] = value; } }                

                    
                    
        private _trackOver_default = false;
                    
                    
        [JsonIgnore]
        public Boolean trackOver { get { return this.attributes.GetOrDefault<Boolean>("trackOver", false); } set { this.attributes["trackOver"] = value; } }                
                    
    }
}
