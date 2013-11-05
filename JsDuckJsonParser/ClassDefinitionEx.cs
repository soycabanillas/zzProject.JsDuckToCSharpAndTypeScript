using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsDuckJsonParser {

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
}
