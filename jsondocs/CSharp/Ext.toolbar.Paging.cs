using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.toolbar.Paging : Ext.toolbar.Toolbar {
                    
        private _afterPageText_default = 'of {0}';
                    
                    
        [JsonIgnore]
        public String afterPageText { get { return this.attributes.GetOrDefault<String>("afterPageText", 'of {0}'); } set { this.attributes["afterPageText"] = value; } }                
                    
                    
        private _beforePageText_default = 'Page';
                    
                    
        [JsonIgnore]
        public String beforePageText { get { return this.attributes.GetOrDefault<String>("beforePageText", 'Page'); } set { this.attributes["beforePageText"] = value; } }                
                    
                    
        private _displayInfo_default = false;
                    
                    
        [JsonIgnore]
        public Boolean displayInfo { get { return this.attributes.GetOrDefault<Boolean>("displayInfo", false); } set { this.attributes["displayInfo"] = value; } }                
                    
                    
        private _displayMsg_default = 'Displaying {0} - {1} of {2}';
                    
                    
        [JsonIgnore]
        public String displayMsg { get { return this.attributes.GetOrDefault<String>("displayMsg", 'Displaying {0} - {1} of {2}'); } set { this.attributes["displayMsg"] = value; } }                
                    
                    
        private _emptyMsg_default = 'No data to display';
                    
                    
        [JsonIgnore]
        public String emptyMsg { get { return this.attributes.GetOrDefault<String>("emptyMsg", 'No data to display'); } set { this.attributes["emptyMsg"] = value; } }                
                    
                    
        private _firstText_default = 'First Page';
                    
                    
        [JsonIgnore]
        public String firstText { get { return this.attributes.GetOrDefault<String>("firstText", 'First Page'); } set { this.attributes["firstText"] = value; } }                
                    
                    
        private _inputItemWidth_default = 30;
                    
                    
        [JsonIgnore]
        public Number inputItemWidth { get { return this.attributes.GetOrDefault<Number>("inputItemWidth", 30); } set { this.attributes["inputItemWidth"] = value; } }                
                    
                    
        private _lastText_default = 'Last Page';
                    
                    
        [JsonIgnore]
        public String lastText { get { return this.attributes.GetOrDefault<String>("lastText", 'Last Page'); } set { this.attributes["lastText"] = value; } }                
                    
                    
        private _nextText_default = 'Next Page';
                    
                    
        [JsonIgnore]
        public String nextText { get { return this.attributes.GetOrDefault<String>("nextText", 'Next Page'); } set { this.attributes["nextText"] = value; } }                
                    
                    
        private _prependButtons_default = false;
                    
                    
        [JsonIgnore]
        public Boolean prependButtons { get { return this.attributes.GetOrDefault<Boolean>("prependButtons", false); } set { this.attributes["prependButtons"] = value; } }                
                    
                    
        private _prevText_default = 'Previous Page';
                    
                    
        [JsonIgnore]
        public String prevText { get { return this.attributes.GetOrDefault<String>("prevText", 'Previous Page'); } set { this.attributes["prevText"] = value; } }                
                    
                    
        private _refreshText_default = 'Refresh';
                    
                    
        [JsonIgnore]
        public String refreshText { get { return this.attributes.GetOrDefault<String>("refreshText", 'Refresh'); } set { this.attributes["refreshText"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.Store store { get { return this.attributes.GetOrDefault<Ext.data.Store>("store", ); } set { this.attributes["store"] = value; } }                
                    
    }
}
