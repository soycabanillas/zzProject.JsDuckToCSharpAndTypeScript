using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtJSToCSharp {
    public partial class Ext.form.field.FileButton : Ext.button.Button {
                    
        private _cls_default = Ext.baseCSSPrefix + 'form-file-btn';
                    
                    
        [JsonIgnore]
        public String cls { get { return this.attributes.GetOrDefault<String>("cls", Ext.baseCSSPrefix + 'form-file-btn'); } set { this.attributes["cls"] = value; } }                
                    
                    
        private _preventDefault_default = false;
                    
                    
        [JsonIgnore]
        public Boolean preventDefault { get { return this.attributes.GetOrDefault<Boolean>("preventDefault", false); } set { this.attributes["preventDefault"] = value; } }                
                    
                    
        private _renderTpl_default = ['<span id="{id}-btnWrap" class="{baseCls}-wrap', '<tpl if="splitCls"> {splitCls}</tpl>', '{childElCls}" unselectable="on">', '<span id="{id}-btnEl" class="{baseCls}-button">', '<span id="{id}-btnInnerEl" class="{baseCls}-inner {innerCls}', '{childElCls}" unselectable="on">', '{text}', '</span>', '<span role="img" id="{id}-btnIconEl" class="{baseCls}-icon-el {iconCls}', '{childElCls} {glyphCls}" unselectable="on" style="', '<tpl if="iconUrl">background-image:url({iconUrl});</tpl>', '<tpl if="glyph && glyphFontFamily">font-family:{glyphFontFamily};</tpl>">', '<tpl if="glyph">&#{glyph};</tpl><tpl if="iconCls || iconUrl">&#160;</tpl>', '</span>', '</span>', '</span>', '<input id="{id}-fileInputEl" class="{childElCls} {inputCls}" type="file" size="1" name="{inputName}">'];
                    
                    
        public class MultiType_renderTpl {
            public new Type GetType()
            {
                return _value.GetType();
            }

                            
            public static explicit operator int (Ext.XTemplate m)
            {
                if (m._value.GetType() == typeof(int)) return (int)m._value;
                else return default(int);
            }
            public static implicit operator Ext.XTemplate (int m) {
                return new Ext.XTemplate { _value = m };
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
                            

            private object _value;
            public object @object  { get { return _value; } set { _value = value; } }
            public int @int { get { return (int) _value; } set { _value = value; } }
            public string @function { get { return (string) _value; } set { _value = value; } }
        }

        [JsonIgnore]
        public MultiType_renderTpl renderTpl { get { return this.attributes.GetOrDefault<MultiType_renderTpl>("renderTpl", ['<span id="{id}-btnWrap" class="{baseCls}-wrap', '<tpl if="splitCls"> {splitCls}</tpl>', '{childElCls}" unselectable="on">', '<span id="{id}-btnEl" class="{baseCls}-button">', '<span id="{id}-btnInnerEl" class="{baseCls}-inner {innerCls}', '{childElCls}" unselectable="on">', '{text}', '</span>', '<span role="img" id="{id}-btnIconEl" class="{baseCls}-icon-el {iconCls}', '{childElCls} {glyphCls}" unselectable="on" style="', '<tpl if="iconUrl">background-image:url({iconUrl});</tpl>', '<tpl if="glyph && glyphFontFamily">font-family:{glyphFontFamily};</tpl>">', '<tpl if="glyph">&#{glyph};</tpl><tpl if="iconCls || iconUrl">&#160;</tpl>', '</span>', '</span>', '</span>', '<input id="{id}-fileInputEl" class="{childElCls} {inputCls}" type="file" size="1" name="{inputName}">']); } set { this.attributes["renderTpl"] = value; } }                

                    
    }
}
