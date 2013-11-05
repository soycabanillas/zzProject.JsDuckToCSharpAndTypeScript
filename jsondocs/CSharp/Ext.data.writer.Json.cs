using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.writer.Json : Ext.data.writer.Writer {
                    
        private _allowSingle_default = true;
                    
                    
        [JsonIgnore]
        public Boolean allowSingle { get { return this.attributes.GetOrDefault<Boolean>("allowSingle", true); } set { this.attributes["allowSingle"] = value; } }                
                    
                    
        private _encode_default = false;
                    
                    
        [JsonIgnore]
        public Boolean encode { get { return this.attributes.GetOrDefault<Boolean>("encode", false); } set { this.attributes["encode"] = value; } }                
                    
                    
        private _expandData_default = false;
                    
                    
        [JsonIgnore]
        public Boolean expandData { get { return this.attributes.GetOrDefault<Boolean>("expandData", false); } set { this.attributes["expandData"] = value; } }                
                    
                    
        [JsonIgnore]
        public String root { get { return this.attributes.GetOrDefault<String>("root", ); } set { this.attributes["root"] = value; } }                
                    
    }
}
