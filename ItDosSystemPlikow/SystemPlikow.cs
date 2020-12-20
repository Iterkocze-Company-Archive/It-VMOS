using System;
using System.Text;
using Cosmos.System.FileSystem.Listing;

namespace CosmosKernel2
{
    class SystemPlikow
    {
        public static void Dir(string[] function)
        {
            var files = Kernel.fs.GetDirectoryListing("0:/");
            if (function.Length > 1)
            {
                string directory = function[1];

                files = Kernel.fs.GetDirectoryListing($"0:/{directory}");
            }
            foreach (var directoryEntry in files)
            {
                Console.WriteLine(directoryEntry.mName);
            }
        }

        public static void StworzPlik()
        {
            Console.Write("Wprowadz sciezke do pliku: ");
            string fileName = Console.ReadLine();
            foreach (char c in fileName)
            {
                if (c == ' ')
                {
                    Console.WriteLine("W sciezce nie moze byc spacji");
                    WyborFunkcjiVoid.wyborFunkcjiVoid();
                }
            }
            
            try
            {
                if (fileName.Substring(fileName.Length - 4) == ".txt")
                {
                    Kernel.fs.CreateFile($@"0:\{fileName}");
                }
                else
                {
                    Kernel.fs.CreateDirectory($@"0:\{fileName}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n{e.Message}\n");
            }
        }
        

        public static void OtworzPlik()
        {
            Console.Write("Wpisz sciezke do pliku: ");
            string fileName = Console.ReadLine();
            try
            {
                string filePath = $@"0:/{fileName}";
                DirectoryEntry dir = Kernel.fs.GetFile(filePath);
                var fileStream = dir.GetFileStream();

                if (fileName.Substring(fileName.Length - 4) == ".txt")
                {
                    if (fileStream.CanRead)
                    {
                        byte[] fileText = new byte[fileStream.Length];
                        fileStream.Read(fileText, 0, (int)fileStream.Length);
                        Console.WriteLine(Encoding.Default.GetString(fileText));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n{e.Message}\n");
            }
        }

        public static void UsunPlik()
        {
            Console.Write("Wprowadz sciezke do pliku: ");
            string fileName = Console.ReadLine();
            if (fileName.Substring(fileName.Length - 4) == ".txt")
            {
                DirectoryEntry dir = Kernel.fs.GetFile($@"0:/{fileName}");
                Kernel.fs.DeleteFile(dir);
            }
            else
            {
                DirectoryEntry dir = Kernel.fs.GetDirectory($@"0:/{fileName}");
                Kernel.fs.DeleteDirectory(dir);
            }
        }

        public static void EdytujPlik()
        {
             Console.Write("Wpisz sciezke do pliku: ");
             string fileName = Console.ReadLine();
             var file = Kernel.fs.GetFile($@"0:\{fileName}");
             var fileStream = file.GetFileStream();

             if (fileStream.CanWrite)
             {
                 string tekst = Console.ReadLine();
                 byte[] text_do_zapisania = Encoding.ASCII.GetBytes(tekst);
                 fileStream.Write(text_do_zapisania, 0, text_do_zapisania.Length);
             }
        }
    }
}
