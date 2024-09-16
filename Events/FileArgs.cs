using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Delegates_Evenst.Events
{
    public class FileArgs : EventArgs
    {
        public FileArgs(string name)
        {
            FileName = name;
        }

        public string FileName { get; }
    }
}
