using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_exstension_files
{
    class FileCollections
    {
        List<string> filecoll;
        public FileCollections()
        {
            filecoll = new List<string>();
        }

        public void AddFile(string str)
        {
            filecoll.Add(str);
        }
    }
}
