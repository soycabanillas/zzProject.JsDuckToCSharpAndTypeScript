using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.container.DockingContainer : Ext.Base {
                    
        private _defaultDockWeights_default = {top: {render: 1, visual: 1}, left: {render: 3, visual: 5}, right: {render: 5, visual: 7}, bottom: {render: 7, visual: 3}};
                    
                    
        [JsonIgnore]
        public Object defaultDockWeights { get { return this.attributes.GetOrDefault<Object>("defaultDockWeights", {top: {render: 1, visual: 1}, left: {render: 3, visual: 5}, right: {render: 5, visual: 7}, bottom: {render: 7, visual: 3}}); } set { this.attributes["defaultDockWeights"] = value; } }                
                    
    }
}
