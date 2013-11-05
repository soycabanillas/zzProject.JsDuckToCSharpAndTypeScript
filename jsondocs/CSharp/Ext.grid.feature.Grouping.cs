using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.feature.Grouping : Ext.grid.feature.Feature {
                    
        private _collapsible_default = true;
                    
                    
        [JsonIgnore]
        public Boolean collapsible { get { return this.attributes.GetOrDefault<Boolean>("collapsible", true); } set { this.attributes["collapsible"] = value; } }                
                    
                    
        private _depthToIndent_default = 17;
                    
                    
        [JsonIgnore]
        public Number depthToIndent { get { return this.attributes.GetOrDefault<Number>("depthToIndent", 17); } set { this.attributes["depthToIndent"] = value; } }                
                    
                    
        private _enableGroupingMenu_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableGroupingMenu { get { return this.attributes.GetOrDefault<Boolean>("enableGroupingMenu", true); } set { this.attributes["enableGroupingMenu"] = value; } }                
                    
                    
        private _enableNoGroups_default = true;
                    
                    
        [JsonIgnore]
        public Boolean enableNoGroups { get { return this.attributes.GetOrDefault<Boolean>("enableNoGroups", true); } set { this.attributes["enableNoGroups"] = value; } }                
                    
                    
        private _groupByText_default = "Group by this field";
                    
                    
        [JsonIgnore]
        public String groupByText { get { return this.attributes.GetOrDefault<String>("groupByText", "Group by this field"); } set { this.attributes["groupByText"] = value; } }                
                    
                    
        private _groupHeaderTpl_default = '{columnName}: {name}';
                    
                    
        public class MultiType_groupHeaderTpl {
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
                            
                            
            public static explicit operator int (Array m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Array (int m) {
                return new Array { _value = m };
            }
                            
                            
            public static explicit operator int (Ext.Template m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.Template (int m) {
                return new Ext.Template { _value = m };
            }
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_groupHeaderTpl groupHeaderTpl { get { return this.attributes.GetOrDefault<MultiType_groupHeaderTpl>("groupHeaderTpl", '{columnName}: {name}'); } set { this.attributes["groupHeaderTpl"] = value; } }                

                    
                    
        private _hideGroupedHeader_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideGroupedHeader { get { return this.attributes.GetOrDefault<Boolean>("hideGroupedHeader", false); } set { this.attributes["hideGroupedHeader"] = value; } }                
                    
                    
        private _showGroupsText_default = "Show in groups";
                    
                    
        [JsonIgnore]
        public String showGroupsText { get { return this.attributes.GetOrDefault<String>("showGroupsText", "Show in groups"); } set { this.attributes["showGroupsText"] = value; } }                
                    
                    
        private _showSummaryRow_default = false;
                    
                    
        [JsonIgnore]
        public Boolean showSummaryRow { get { return this.attributes.GetOrDefault<Boolean>("showSummaryRow", false); } set { this.attributes["showSummaryRow"] = value; } }                
                    
                    
        private _startCollapsed_default = false;
                    
                    
        [JsonIgnore]
        public Boolean startCollapsed { get { return this.attributes.GetOrDefault<Boolean>("startCollapsed", false); } set { this.attributes["startCollapsed"] = value; } }                
                    
    }
}
