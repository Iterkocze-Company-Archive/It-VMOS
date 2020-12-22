using System;
using System.Text;
using Cosmos.System.FileSystem.Listing;

namespace CosmosKernel2
{
    class SystemPlikow
    {
        public static void Dir(string[] function)
        {
            var files = Kernel.fs.GetDirectoryListing(@"0:/");

            if (function.Length > 1)
            {
                string directory = function[1];

                files = Kernel.fs.GetDirectoryListing($@"0:/{directory}");
            }
            foreach (var directoryEntry in files)
            {
                Console.WriteLine(directoryEntry.mName);
            }
        }

        public static void StworzPlik(string[] function)
        {
            string filePath = $@"0:/{function[1]}";

            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podana sciezka pliku\n");
            }
            else
            {
                foreach (char c in filePath)
                {
                    if (c == ' ')
                    {
                        Console.WriteLine("W sciezce nie moze byc spacji.");
                        WyborFunkcjiVoid.wyborFunkcjiVoid();
                    }
                }

                try
                {
                    if (filePath.Substring(filePath.Length - 4) == ".txt")
                    {
                        Kernel.fs.CreateFile($@"0:/{filePath}");
                    }
                    else
                    {
                        Kernel.fs.CreateDirectory($@"0:/{filePath}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                }
            }
        }
        

        public static void OtworzPlik(string[] function)
        {
            string filePath = $@"0:/{function[1]}";

            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podana sciezka pliku.\n");
            }
            else
            {
                try
                {
                    DirectoryEntry dir = Kernel.fs.GetFile(filePath);
                    var fileStream = dir.GetFileStream();

                    if (filePath.Substring(filePath.Length - 4) == ".txt")
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
        }

        public static void UsunPlik(string[] function)
        {
            string filePath = $@"0:/{function[1]}";

            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podana sciezka pliku.\n");
            }
            else
            {
                if (filePath.Substring(filePath.Length - 4) == ".txt")
                {
                    DirectoryEntry dir = Kernel.fs.GetFile($@"0:/{filePath}");
                    Kernel.fs.DeleteFile(dir);
                }
                else
                {
                    DirectoryEntry dir = Kernel.fs.GetDirectory($@"0:/{filePath}");
                    Kernel.fs.DeleteDirectory(dir);
                }
            }
        }

        public static void EdytujPlik(string[] function)
        {
            string filePath = $@"0:/{function[1]}";

            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podana sciezka pliku.\n");
            }
            else
            {
                var file = Kernel.fs.GetFile($@"0:/{filePath}");
                var fileStream = file.GetFileStream();

                if (fileStream.CanWrite)
                {
                    string text = Console.ReadLine();
                    fileStream.Write(Encoding.ASCII.GetBytes(text), 0, Encoding.ASCII.GetBytes(text).Length);
                }
            }
        }
    }
}
