using System;
using System.IO;
using System.Security.Permissions;

namespace FileSurveillance
{
    class SystemSurveillance
    {
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
                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnRenamed;

                // Starts the watcher
                watcher.EnableRaisingEvents = true;

                // Wait for the user to quit the program.
                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }
        }

        
        private static void OnChanged(object source, FileSystemEventArgs e) =>
            // Shows the path from the file made changes on.
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}" + "hej " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));

        private static void OnRenamed(object source, RenamedEventArgs e) =>
            // Shows the path of the renamed file from the old location to the new
            Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}" + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
    }

}
