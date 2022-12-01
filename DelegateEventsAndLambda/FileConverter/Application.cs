namespace DelegateEventsAndLambda.FileConverter
{
    //public delegate File HandleFile (File file); 
    internal class Application
    {
        public static void Run()
        {
            Func<File, File> handleFile = Processes.ReadFile;
            handleFile += Processes.EditFile;
            handleFile += Processes.ConvertFile;

            var file = Processes.ProcessFile("Alexa", handleFile);
            Console.WriteLine(file.Name);
        }
       
    }

    public class File
    {
        public string Name { get; set; }
        public File(string name)
        {
            Name = name;
        }
    }

    public static class Processes
    {
        public static File ReadFile (File file)
        {
            Console.WriteLine("File is being read");
            file.Name = $"Read{file.Name}";
            Thread.Sleep(3000);
            return file;
        }

        public static File EditFile(File file)
        {
            Console.WriteLine("File is being edited");
            file.Name = $"Edit{file.Name}";
            Thread.Sleep(3000);
            return file;
        }

        public static File ConvertFile(File file)
        {
            Console.WriteLine("File is being converted");
            file.Name = $"COnvert{file.Name}";
            Thread.Sleep(3000);
            return file;
        }

        public static File ProcessFile(string filename, Func<File,File> handleFile)
        {
            File file = new File(filename);
            File newFile = handleFile(file);
            return newFile;           
        }
    }
}
