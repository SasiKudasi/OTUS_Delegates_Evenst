using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Delegates_Evenst.Events
{
    public class FileSearcher
    {
        public event EventHandler<FileArgs> FileFound;

        public void Search(string path, CancellationToken cancellationToken)
        {
            foreach (var file in Directory.GetFiles(path))
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelled");
                    break;
                }
                OnFileFound(new FileArgs(file));
            }
        }

        protected virtual void OnFileFound(FileArgs args)
        {
            FileFound?.Invoke(this, args);
        }


    }
}
