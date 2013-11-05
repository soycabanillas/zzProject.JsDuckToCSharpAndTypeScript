using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsDuckJsonParser {
    public class Autodetected {

        [JsonProperty("aliases")]
        public bool Aliases { get; set; }

        [JsonProperty("alternateClassNames")]
        public bool AlternateClassNames { get; set; }

        [JsonProperty("extends")]
        public bool Extends { get; set; }

        [JsonProperty("mixins")]
        public bool Mixins { get; set; }

        [JsonProperty("requires")]
        public bool Requires { get; set; }

        [JsonProperty("uses")]
        public bool Uses { get; set; }

        [JsonProperty("members")]
        public bool Members { get; set; }

        [JsonProperty("code_type")]
        public bool CodeType { get; set; }
    }

    public class File {

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("linenr")]
        public int Linenr { get; set; }
    }

    public class Docauthor {

        [JsonProperty("tagname")]
        public string Tagname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Aliases {

        [JsonProperty("widget")]
        public IList<string> Widget { get; set; }
    }

    public class Autodetected2 {

        [JsonProperty("inheritdoc")]
        public bool? Inheritdoc { get; set; }

        [JsonProperty("static")]
        public bool? Static { get; set; }

        [JsonProperty("private")]
        public bool? Private { get; set; }

        [JsonProperty("inheritable")]
        public bool? Inheritable { get; set; }

        [JsonProperty("linenr")]
        public bool? Linenr { get; set; }

        [JsonProperty("default")]
        public bool? Default { get; set; }

        [JsonProperty("accessor")]
        public bool? Accessor { get; set; }

        [JsonProperty("evented")]
        public bool? Evented { get; set; }

        [JsonProperty("tagname")]
        public string Tagname { get; set; }

        [JsonProperty("type")]
        public bool? Type { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("chainable")]
        public bool? Chainable { get; set; }

        [JsonProperty("fires")]
        public bool? Fires { get; set; }

        [JsonProperty("method_calls")]
        public bool? MethodCalls { get; set; }

        [JsonProperty("params")]
        public bool? Params { get; set; }
    }

    public class File2 {

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("linenr")]
        public int Linenr { get; set; }
    }

    public class Property {

        [JsonProperty("tagname")]
        public string Tagname { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("doc")]
        public string Doc { get; set; }

        [JsonProperty("html_type")]
        public string HtmlType { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("optional")]
        public bool? Optional { get; set; }
    }

    public class Deprecated {

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class Override {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Property2 {

        [JsonProperty("tagname")]
        public string Tagname { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("doc")]
        public string Doc { get; set; }

        [JsonProperty("html_type")]
        public string HtmlType { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("optional")]
        public bool? Optional { get; set; }
    }

    public class Param {

        [JsonProperty("tagname")]
        public string Tagname { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("doc")]
        public string Doc { get; set; }

        [JsonProperty("html_type")]
        public string HtmlType { get; set; }

        [JsonProperty("optional")]
        public bool? Optional { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("properties")]
        public IList<Property2> Properties { get; set; }

        [JsonProperty("ext4_auto_param")]
        public bool? Ext4AutoParam { get; set; }
    }

    public class Property3 {

        [JsonProperty("tagname")]
        public string Tagname { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("doc")]
        public string Doc { get; set; }

        [JsonProperty("html_type")]
        public string HtmlType { get; set; }
    }

    public class Return {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("doc")]
        public string Doc { get; set; }

        [JsonProperty("html_type")]
        public string HtmlType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public IList<Property3> Properties { get; set; }
    }

    public class Member {

        [JsonProperty("tagname")]
        public string Tagname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("autodetected")]
        public Autodetected2 Autodetected { get; set; }

        [JsonProperty("files")]
        public IList<File2> Files { get; set; }

        [JsonProperty("doc")]
        public string Doc { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("properties")]
        public IList<Property> Properties { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("short_doc")]
        public string ShortDoc { get; set; }

        [JsonProperty("html_type")]
        public string HtmlType { get; set; }

        [JsonProperty("inheritdoc")]
        public object Inheritdoc { get; set; }

        [JsonProperty("static")]
        public bool? Static { get; set; }

        [JsonProperty("private")]
        public bool? Private { get; set; }

        [JsonProperty("inheritable")]
        public bool? Inheritable { get; set; }

        [JsonProperty("linenr")]
        public int? Linenr { get; set; }

        [JsonProperty("accessor")]
        public object Accessor { get; set; }

        [JsonProperty("evented")]
        public object Evented { get; set; }

        [JsonProperty("since")]
        public string Since { get; set; }

        [JsonProperty("deprecated")]
        public Deprecated Deprecated { get; set; }

        [JsonProperty("overrides")]
        public IList<Override> Overrides { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("protected")]
        public bool? Protected { get; set; }

        [JsonProperty("params")]
        public IList<Param> Params { get; set; }

        [JsonProperty("chainable")]
        public bool? Chainable { get; set; }

        [JsonProperty("fires")]
        public IList<string> Fires { get; set; }

        [JsonProperty("method_calls")]
        public IList<string> MethodCalls { get; set; }

        [JsonProperty("return")]
        public Return Return { get; set; }

        [JsonProperty("throws")]
        public object Throws { get; set; }

        [JsonProperty("template")]
        public bool? Template { get; set; }
    }

    public partial class ClassDefinition {

        [JsonProperty("tagname")]
        public string Tagname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("autodetected")]
        public Autodetected Autodetected { get; set; }

        [JsonProperty("files")]
        public IList<File> Files { get; set; }

        [JsonProperty("doc")]
        public string Doc { get; set; }

        [JsonProperty("docauthor")]
        public IList<Docauthor> Docauthor { get; set; }

        [JsonProperty("aliases")]
        public Aliases Aliases { get; set; }

        [JsonProperty("alternateClassNames")]
        public IList<string> AlternateClassNames { get; set; }

        [JsonProperty("extends")]
        public string Extends { get; set; }

        [JsonProperty("mixins")]
        public IList<string> Mixins { get; set; }

        [JsonProperty("requires")]
        public IList<string> Requires { get; set; }

        [JsonProperty("uses")]
        public IList<object> Uses { get; set; }

        [JsonProperty("members")]
        public IList<Member> Members { get; set; }

        [JsonProperty("code_type")]
        public string CodeType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("short_doc")]
        public string ShortDoc { get; set; }

        //[JsonExtensionData]
        //public IDictionary<string, JToken> _additionalData;
    }
}
