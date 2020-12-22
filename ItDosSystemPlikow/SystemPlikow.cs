using System;
using System.Text;
using Cosmos.System.FileSystem.Listing;

namespace CosmosKernel2
{
    class SystemPlikow
    {
        public static void Dir(string[] function)
        {
            var files = Kernel.fs.GetDirectoryListing($"0:/");

            if (function.Length > 1)
            {
                string directory = function[1];
                files = Kernel.fs.GetDirectoryListing($@"{directory}");
            }
            foreach (var directoryEntry in files)
            {
                Console.WriteLine(directoryEntry.mName);
            }
            WyborFunkcjiVoid.wyborFunkcjiVoid();
        }

        public static void StworzPlik(string[] function)
        {
            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podana sciezka pliku\n");
            }
            else
            {
                string filePath = $@"{function[1]}";

                foreach (char c in filePath)
                {
                    if (c == ' ')
                    {
                        Console.WriteLine("W sciezce nie moze byc spacji.");
                    }
                }

                try
                {
                    if (filePath.Substring(filePath.Length - 4) == ".txt")
                    {
                        Kernel.fs.CreateFile(filePath);
                    }
                    else
                    {
                        Kernel.fs.CreateDirectory(filePath);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                }
            }
            WyborFunkcjiVoid.wyborFunkcjiVoid();
        }
        

        public static void OtworzPlik(string[] function)
        {
            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podana sciezka pliku.\n");
            }
            else
            {
                string filePath = $@"0:/{function[1]}";

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
            WyborFunkcjiVoid.wyborFunkcjiVoid();
        }

        public static void UsunPlik(string[] function)
        {
            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podana sciezka pliku.\n");
            }
            else
            {
                string filePath = $@"0:/{function[1]}";

                if (filePath.Substring(filePath.Length - 4) == ".txt")
                {
                    DirectoryEntry dir = Kernel.fs.GetFile(filePath);
                    Kernel.fs.DeleteFile(dir);
                }
                else
                {
                    DirectoryEntry dir = Kernel.fs.GetDirectory(filePath);
                    Kernel.fs.DeleteDirectory(dir);
                }
            }
            WyborFunkcjiVoid.wyborFunkcjiVoid();
        }

        public static void EdytujPlik(string[] function)
        {
            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podana sciezka pliku.\n");
            }
            else
            {
                var file = Kernel.fs.GetFile($@"0:/{function[1]}");
                var fileStream = file.GetFileStream();
                if (fileStream.CanWrite)
                {
                    string text = Console.ReadLine();
                    fileStream.Write(Encoding.ASCII.GetBytes(text), 0, Encoding.ASCII.GetBytes(text).Length);
                }
            }
            WyborFunkcjiVoid.wyborFunkcjiVoid();
        }
        

    }
}
