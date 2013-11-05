using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.writer.Xml : Ext.data.writer.Writer {
                    
        private _defaultDocumentRoot_default = 'xmlData';
                    
                    
        [JsonIgnore]
        public String defaultDocumentRoot { get { return this.attributes.GetOrDefault<String>("defaultDocumentRoot", 'xmlData'); } set { this.attributes["defaultDocumentRoot"] = value; } }                
                    
                    
        private _documentRoot_default = 'xmlData';
                    
                    
        [JsonIgnore]
        public String documentRoot { get { return this.attributes.GetOrDefault<String>("documentRoot", 'xmlData'); } set { this.attributes["documentRoot"] = value; } }                
                    
                    
        private _header_default = '';
                    
                    
        [JsonIgnore]
        public String header { get { return this.attributes.GetOrDefault<String>("header", ''); } set { this.attributes["header"] = value; } }                
                    
                    
        private _record_default = 'record';
                    
                    
        [JsonIgnore]
        public String record { get { return this.attributes.GetOrDefault<String>("record", 'record'); } set { this.attributes["record"] = value; } }                
                    
    }
}
