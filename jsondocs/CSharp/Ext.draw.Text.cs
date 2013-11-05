using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.draw.Text : Ext.draw.Component {
                    
        private _autoSize_default = true;
                    
                    
        [JsonIgnore]
        public Boolean autoSize { get { return this.attributes.GetOrDefault<Boolean>("autoSize", true); } set { this.attributes["autoSize"] = value; } }                
                    
                    
        private _baseCls_default = Ext.baseCSSPrefix + 'surface ' + Ext.baseCSSPrefix + 'draw-text';
                    
                    
        [JsonIgnore]
        public String baseCls { get { return this.attributes.GetOrDefault<String>("baseCls", Ext.baseCSSPrefix + 'surface ' + Ext.baseCSSPrefix + 'draw-text'); } set { this.attributes["baseCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number degrees { get { return this.attributes.GetOrDefault<Number>("degrees", ); } set { this.attributes["degrees"] = value; } }                
                    
                    
        [JsonIgnore]
        public String styleSelector { get { return this.attributes.GetOrDefault<String>("styleSelector", ); } set { this.attributes["styleSelector"] = value; } }                
                    
                    
        private _text_default = '';
                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", ''); } set { this.attributes["text"] = value; } }                
                    
                    
        private _viewBox_default = false;
                    
                    
        [JsonIgnore]
        public Boolean viewBox { get { return this.attributes.GetOrDefault<Boolean>("viewBox", false); } set { this.attributes["viewBox"] = value; } }                
                    
    }
}
