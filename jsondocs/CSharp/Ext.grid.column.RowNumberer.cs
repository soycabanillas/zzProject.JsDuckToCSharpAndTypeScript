using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.grid.column.RowNumberer : Ext.grid.column.Column {
                    
        private _align_default = 'right';
                    
                    
        [JsonIgnore]
        public String align { get { return this.attributes.GetOrDefault<String>("align", 'right'); } set { this.attributes["align"] = value; } }                
                    
                    
        private _cls_default = Ext.baseCSSPrefix + 'row-numberer';
                    
                    
        [JsonIgnore]
        public String cls { get { return this.attributes.GetOrDefault<String>("cls", Ext.baseCSSPrefix + 'row-numberer'); } set { this.attributes["cls"] = value; } }                
                    
                    
        private _dataIndex_default = '';
                    
                    
        [JsonIgnore]
        public String dataIndex { get { return this.attributes.GetOrDefault<String>("dataIndex", ''); } set { this.attributes["dataIndex"] = value; } }                
                    
                    
        private _draggable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean draggable { get { return this.attributes.GetOrDefault<Boolean>("draggable", false); } set { this.attributes["draggable"] = value; } }                
                    
                    
        private _hideable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean hideable { get { return this.attributes.GetOrDefault<Boolean>("hideable", false); } set { this.attributes["hideable"] = value; } }                
                    
                    
        private _lockable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean lockable { get { return this.attributes.GetOrDefault<Boolean>("lockable", false); } set { this.attributes["lockable"] = value; } }                
                    
                    
        private _menuDisabled_default = true;
                    
                    
        [JsonIgnore]
        public Boolean menuDisabled { get { return this.attributes.GetOrDefault<Boolean>("menuDisabled", true); } set { this.attributes["menuDisabled"] = value; } }                
                    
                    
        private _resizable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean resizable { get { return this.attributes.GetOrDefault<Boolean>("resizable", false); } set { this.attributes["resizable"] = value; } }                
                    
                    
        private _tdCls_default = Ext.baseCSSPrefix + 'grid-cell-row-numberer ' + Ext.baseCSSPrefix + 'grid-cell-special';
                    
                    
        [JsonIgnore]
        public String tdCls { get { return this.attributes.GetOrDefault<String>("tdCls", Ext.baseCSSPrefix + 'grid-cell-row-numberer ' + Ext.baseCSSPrefix + 'grid-cell-special'); } set { this.attributes["tdCls"] = value; } }                
                    
                    
        private _text_default = "&#160";
                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", "&#160"); } set { this.attributes["text"] = value; } }                
                    
                    
        private _width_default = 23;
                    
                    
        [JsonIgnore]
        public Number width { get { return this.attributes.GetOrDefault<Number>("width", 23); } set { this.attributes["width"] = value; } }                
                    
    }
}
