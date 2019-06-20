//using System;
//using System.IO;
//using System.Text;
//using System.Threading;


//public class FileInputMonitor
//{

//    private FileSystemWatcher fileSystemWatcher;
//    private string folderToWatchFor
//        = AppDomain.CurrentDomain.BaseDirectory + "hejmeddig.txt";

//    public FileInputMonitor()
//    {
//        //Creates new Filesystem wather to Surveillance 
//        fileSystemWatcher = new FileSystemWatcher(folderToWatchFor);
//        fileSystemWatcher.EnableRaisingEvents = true;

//        // Instruct the file system watcher to call the FileCreated method
//        // when there are files created at the folder.
//        fileSystemWatcher.Created += new FileSystemEventHandler(FileCreated);

//    } // end FileInputMonitor()

//    private void FileCreated(Object sender, FileSystemEventArgs e)
//    {

//        if (e.Name == "report-for-" + System.DateTime.Now.ToString("yyyy-MM-dd"))
//        {
//            ProcessFile(e.FullPath);
//        } // end if

//    } // end public void FileCreated(Object sender, FileSystemEventArgs e)

//    private void ProcessFile(String fileName)
//    {
//        FileStream inputFileStream;
//        while (true)
//        {
//            try
//            {
//                inputFileStream = new FileStream(fileName,
//                    FileMode.Open, FileAccess.ReadWrite);
//                StreamReader reader = new StreamReader(inputFileStream);
//                Console.WriteLine(reader.ReadToEnd());
//                // Break out from the endless loop
//                break;
//            }
//            catch (IOException)
//            {
//                // Sleep for 3 seconds before trying
//                Thread.Sleep(3000);
//            } // end try
//        } // end while(true)
//    } // end private void ProcessFile(String fileName)

//} // end public class FileInputMonitor