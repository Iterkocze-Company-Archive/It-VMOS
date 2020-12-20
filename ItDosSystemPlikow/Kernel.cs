using System;
using Cosmos.System.FileSystem;
using Sys = Cosmos.System;

namespace CosmosKernel2
{
    public class Kernel : Sys.Kernel
    {
        public static CosmosVFS fs = new CosmosVFS();
        protected override void BeforeRun()
        {
            Console.Clear();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Log.Suk("\nPomyslnie zainicjalizowano system plikow!\nNacisnij dowolny klawisz aby kontynuowac...");
            Console.ReadKey();
            Console.Clear();
            Log.Suk("IT-DOS uruchomiony.\nNacisnij dowolny klawisz aby kontynuowac.");
            Console.ReadKey();
        }
        protected override void Run()
        {
            System.Menu(true);
        }
    }
}
