using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonTypescriptConverter {
    public class ParseProgress {
        public string FileName { get; set; }
        public int Current { get; set; }
        public int Total { get; set; }
    }

    public class Parser : JsDuckJsonParser.ISerializer {
        private System.IO.DirectoryInfo _directoryDestiny;

        private Parser() {
        }

        public static void Parse(System.IO.DirectoryInfo directorySource, System.IO.DirectoryInfo directoryDestiny, JsDuckJsonParser.IJsDuckJsonParser jsDuckJsonParser, Action<ParseProgress> progressFunc = null)
        {
            Parser parser = new Parser();
            parser.InnerParse(directorySource, directoryDestiny, jsDuckJsonParser, progressFunc);
        }

        private void InnerParse(System.IO.DirectoryInfo directorySource, System.IO.DirectoryInfo directoryDestiny, JsDuckJsonParser.IJsDuckJsonParser jsDuckJsonParser, Action<ParseProgress> progressFunc) {
            _directoryDestiny = directoryDestiny;

            JsDuckJsonParser.Parser parser = new JsDuckJsonParser.Parser(jsDuckJsonParser);


            parser.Begin(this);

            var files = directorySource.GetFiles("*.json", System.IO.SearchOption.TopDirectoryOnly);
            var currentFile = 0;
            var totalFiles = files.Count();

            if (progressFunc != null) progressFunc(new ParseProgress() { FileName = String.Empty, Current = currentFile, Total = totalFiles });

            foreach (var file in files) {
                currentFile = currentFile + 1;
                if (progressFunc != null) progressFunc(new ParseProgress() { FileName = String.Empty, Current = currentFile, Total = totalFiles });

                parser.Parse(new System.IO.StreamReader(file.FullName));
            }

            parser.End();
        }

        System.IO.StreamWriter JsDuckJsonParser.ISerializer.Serialize(string name) {
            System.IO.Directory.CreateDirectory(_directoryDestiny.FullName);
            return new System.IO.StreamWriter(System.IO.Path.Combine(_directoryDestiny.FullName, name));
        }
    }
}
