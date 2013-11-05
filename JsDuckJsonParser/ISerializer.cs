using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsDuckJsonParser {
    public interface ISerializer {
        System.IO.StreamWriter Serialize(string name);
    }
}
