using System;
using System.Text;
using Cosmos.System.FileSystem.Listing;

namespace CosmosKernel2
{
    class FileSystemCommands
    {
        public static void Dir(string[] function)
        {
            string path = "";

            if (function.Length > 1) path = $@"0:/{function[1]}";
            else path = @"0:/";

            try
            {
                var files = Kernel.fs.GetDirectoryListing(path);

                foreach (var file in files)
                {
                    Console.WriteLine(file.mName);
                }
            }
            catch (Exception e)
            {
                Log.Error($"\n{e.Message}\n");
                CommandPrompt.Prompt();
            }
        }

        public static void Fcreate(string[] function)
        {
            foreach (char ch in function[1])
            {
                if (ch == ' ')
                {
                    Log.Error("\nNazwa pliku nie moze miec spacji.\n");
                    CommandPrompt.Prompt();
                }
            }

            try
            {
                if (function[1].Substring(function[1].Length - 3) == ".txt") Kernel.fs.CreateFile($@"0:\{function[1]}");
                else Kernel.fs.CreateDirectory($@"0:\{function[1]}");
            }
            catch (Exception e)
            {
                Log.Error($"\n{e.Message}\n");
                CommandPrompt.Prompt();
            }
        }
        

        public static void Fopen(string[] function)
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
        }

        public static void Fdelete(string[] function)
        {
            if (function.Length == 1)
            {
                Log.Error("\nMusi byc podana sciezka pliku.\n");
            }
            else
            {
                if (function[1].Substring(function[1].Length - 4) == ".txt")
                {
                    DirectoryEntry dir = Kernel.fs.GetFile($"0:/{function[1]}");
                    Kernel.fs.DeleteFile(dir);
                }
                else
                {
                    DirectoryEntry dir = Kernel.fs.GetDirectory($@"0:/{function[1]}");
                    Kernel.fs.DeleteDirectory(dir);
                }
            }
        }

        public static void Fedit(string[] function)
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
        }
        

    }
}
