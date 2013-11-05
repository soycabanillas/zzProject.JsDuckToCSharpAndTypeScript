using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.NodeInterface : Ext.Base {
                    
        private _allowDrag_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowDrag { get { return this.attributes.GetOrDefault<Boolean>("allowDrag", true); } set { this.attributes["allowDrag"] = value; } }                
                    
                    
        private _allowDrop_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowDrop { get { return this.attributes.GetOrDefault<Boolean>("allowDrop", true); } set { this.attributes["allowDrop"] = value; } }                
                    
                    
        private _checked_default = null;
                    
                    
        [JsonIgnore]
        public Boolean checked { get { return this.attributes.GetOrDefault<Boolean>("checked", null); } set { this.attributes["checked"] = value; } }                
                    
                    
        [JsonIgnore]
        public Ext.data.NodeInterface[] children { get { return this.attributes.GetOrDefault<Ext.data.NodeInterface[]>("children", ); } set { this.attributes["children"] = value; } }                
                    
                    
        [JsonIgnore]
        public String cls { get { return this.attributes.GetOrDefault<String>("cls", ); } set { this.attributes["cls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number depth { get { return this.attributes.GetOrDefault<Number>("depth", ); } set { this.attributes["depth"] = value; } }                
                    
                    
        private _expandable_default = false;
                    
                    
        [JsonIgnore]
        public Boolean expandable { get { return this.attributes.GetOrDefault<Boolean>("expandable", false); } set { this.attributes["expandable"] = value; } }                
                    
                    
        private _expanded_default = false;
                    
                    
        [JsonIgnore]
        public Boolean expanded { get { return this.attributes.GetOrDefault<Boolean>("expanded", false); } set { this.attributes["expanded"] = value; } }                
                    
                    
        [JsonIgnore]
        public String href { get { return this.attributes.GetOrDefault<String>("href", ); } set { this.attributes["href"] = value; } }                
                    
                    
        [JsonIgnore]
        public String hrefTarget { get { return this.attributes.GetOrDefault<String>("hrefTarget", ); } set { this.attributes["hrefTarget"] = value; } }                
                    
                    
        [JsonIgnore]
        public String icon { get { return this.attributes.GetOrDefault<String>("icon", ); } set { this.attributes["icon"] = value; } }                
                    
                    
        [JsonIgnore]
        public String iconCls { get { return this.attributes.GetOrDefault<String>("iconCls", ); } set { this.attributes["iconCls"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number index { get { return this.attributes.GetOrDefault<Number>("index", ); } set { this.attributes["index"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean isFirst { get { return this.attributes.GetOrDefault<Boolean>("isFirst", ); } set { this.attributes["isFirst"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean isLast { get { return this.attributes.GetOrDefault<Boolean>("isLast", ); } set { this.attributes["isLast"] = value; } }                
                    
                    
        private _leaf_default = false;
                    
                    
        [JsonIgnore]
        public Boolean leaf { get { return this.attributes.GetOrDefault<Boolean>("leaf", false); } set { this.attributes["leaf"] = value; } }                
                    
                    
        private _loaded_default = false;
                    
                    
        [JsonIgnore]
        public Boolean loaded { get { return this.attributes.GetOrDefault<Boolean>("loaded", false); } set { this.attributes["loaded"] = value; } }                
                    
                    
        private _loading_default = false;
                    
                    
        [JsonIgnore]
        public Boolean loading { get { return this.attributes.GetOrDefault<Boolean>("loading", false); } set { this.attributes["loading"] = value; } }                
                    
                    
        [JsonIgnore]
        public String parentId { get { return this.attributes.GetOrDefault<String>("parentId", ); } set { this.attributes["parentId"] = value; } }                
                    
                    
        [JsonIgnore]
        public Number qshowDelay { get { return this.attributes.GetOrDefault<Number>("qshowDelay", ); } set { this.attributes["qshowDelay"] = value; } }                
                    
                    
        [JsonIgnore]
        public String qtip { get { return this.attributes.GetOrDefault<String>("qtip", ); } set { this.attributes["qtip"] = value; } }                
                    
                    
        [JsonIgnore]
        public String qtitle { get { return this.attributes.GetOrDefault<String>("qtitle", ); } set { this.attributes["qtitle"] = value; } }                
                    
                    
        [JsonIgnore]
        public Boolean root { get { return this.attributes.GetOrDefault<Boolean>("root", ); } set { this.attributes["root"] = value; } }                
                    
                    
        [JsonIgnore]
        public String text { get { return this.attributes.GetOrDefault<String>("text", ); } set { this.attributes["text"] = value; } }                
                    
    }
}
