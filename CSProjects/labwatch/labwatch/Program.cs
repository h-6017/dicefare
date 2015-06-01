using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwatch
{
    class Program
    {
        static string toPath = @"C:\Users\bbrown_h\Dropbox\labs";
        static string fromPath = @"\\app\students\h\_LapOps";

        static void Main(string[] args)
        {
            FileSystemWatcher _watcher = new FileSystemWatcher();
            _watcher.Path = fromPath;
            _watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
            _watcher.Filter = "*";
            _watcher.Created += _watcher_Created;
            _watcher.Changed += _watcher_Changed;
            _watcher.Error += _watcher_Error;
            _watcher.EnableRaisingEvents = true;
            Console.ReadKey();
        }

        static void _watcher_Error(object sender, ErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        static void _watcher_Changed(object sender, FileSystemEventArgs e)
        {
            SyncFiles(fromPath, toPath);
        }

        private static void SyncFiles(string source, string destination)
        {
            if (File.Exists(source))
            {
                source = Path.GetDirectoryName(source);
            }
            string[] files = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories);
            Parallel.ForEach(files, newpath =>
               {
                   string fullDest = newpath.Replace(source, destination);
                   if (!File.Exists(fullDest))
                   {
                       if (!Directory.Exists(Path.GetDirectoryName(fullDest)))
                       {
                           Directory.CreateDirectory(Path.GetDirectoryName(fullDest));
                       }
                       File.Copy(newpath, fullDest);
                   }
                   else
                   {
                       Console.WriteLine("{0} already exists.", fullDest);
                   }
               });
        }
 
        static void _watcher_Created(object sender, FileSystemEventArgs e)
        {
            SyncFiles(fromPath, toPath);

        }
    }
}
