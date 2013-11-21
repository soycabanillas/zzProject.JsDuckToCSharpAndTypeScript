using JsDuckJsonParser.Class.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsDuckJsonParser.Class {

    [Flags]
    public enum MemberTypeEnum {
        cfg = 0 << 0,
        property = 1 << 1,
        @event = 1 << 2,
        method = 1 << 3
    }

    public partial class ClassDefinition {
        public IEnumerable<Member> GetMembers(MemberTypeEnum memberType)
        {
            return this.Members.Where(m => m.Tagname == memberType.ToString());
        }
    }

    public partial class Member {
        public TypesAndConstants GetTypes() {
            //Test: "prueba"/"test"/object/"arroz/marisco"/"otro"
            //Expresion: \G(?<const>"[^"]*")(/|\z)|\G(?<type>[^"][^/"]*)(/|\z)
            System.Text.RegularExpressions.MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(this.Type, @"\G(?<const>""[^""]*"")(/|\z)|\G(?<type>[^""][^/""]*)(/|\z)", System.Text.RegularExpressions.RegexOptions.Multiline);
            var types = new List<string>();
            var constants = new System.Collections.Generic.SortedSet<string>();
            for (int i = 0; i < matches.Count; i++) {
                var match = matches[i];
                var typeValue = match.Groups["type"].Value;
                var constValue = match.Groups["const"].Value;
                if (!string.IsNullOrEmpty(typeValue)) {
                    types.Add(typeValue);
                } else if (!string.IsNullOrEmpty(constValue)) {
                    constants.Add(constValue);
                }
            }
            return new TypesAndConstants(types, constants.ToList(), this.Default);
        }
    }
}
