using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.data.writer.Writer : Ext.Base {
                    
        [JsonIgnore]
        public String dateFormat { get { return this.attributes.GetOrDefault<String>("dateFormat", ); } set { this.attributes["dateFormat"] = value; } }                
                    
                    
        private _nameProperty_default = 'name';
                    
                    
        [JsonIgnore]
        public String nameProperty { get { return this.attributes.GetOrDefault<String>("nameProperty", 'name'); } set { this.attributes["nameProperty"] = value; } }                
                    
                    
        private _writeAllFields_default = true;
                    
                    
        [JsonIgnore]
        public Boolean writeAllFields { get { return this.attributes.GetOrDefault<Boolean>("writeAllFields", true); } set { this.attributes["writeAllFields"] = value; } }                
                    
                    
        private _writeRecordId_default = true;
                    
                    
        [JsonIgnore]
        public Boolean writeRecordId { get { return this.attributes.GetOrDefault<Boolean>("writeRecordId", true); } set { this.attributes["writeRecordId"] = value; } }                
                    
    }
}
