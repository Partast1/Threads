using System;
using System.IO;
using System.Security.Permissions;

namespace FileSurveillance
{
    class SystemSurveillance
    {
        private static string path = Convert.ToString(AppDomain.CurrentDomain);

        public void SystemWatcher()
        {
            // Create a new FileSystemWatcher and set its properties.
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {

                //Local Path for the Watcher
                watcher.Path = @"C:\Surveillance";


                // Watch for changes in LastAccess and LastWrite times, and
                // the renaming of files or directories.
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                // Only watch text files.
                watcher.Filter = "*.txt";

                // Add event handlers.
                watcher.Changed += Changes;
                watcher.Created += Changes;
                watcher.Deleted += Changes;
                watcher.Renamed += Namechange;

                // Starts the watcher
                watcher.EnableRaisingEvents = true;

                // Wait for the user to quit the program.
                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }
        }
        private void Changes(object source, FileSystemEventArgs e)
        {
            //Using FileStream to write change to a text document
            using (FileStream fileStream =
        File.Create(path + @"\Surveillance-Changes.Txt"))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine($"File: {e.FullPath} {e.ChangeType}" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));

                writer.Close();

            }
        }
        private void Namechange(object source, RenamedEventArgs e)
        {
            
            //Using FileStream to write namechanges to a text document
            using (FileStream fileStream =
  File.Create(path + @"\Surveillance-Namechanges.Txt"))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine($"File: {e.OldFullPath}  renamed to {e.FullPath}" + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                writer.Close();


            }
        }
    }
}

