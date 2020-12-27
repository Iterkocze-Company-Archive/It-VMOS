using System;
using Cosmos.System.FileSystem;
using Sys = Cosmos.System;

namespace CosmosKernel2
{
    public class Kernel : Sys.Kernel
    {
        public static CosmosVFS fs = new CosmosVFS();
        protected override void Run()
        {
            Log.Suk("Pomyslnie uruchomiono system It-VMOS");
            Console.Clear();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            System.Menu(true);
        }
    }
}