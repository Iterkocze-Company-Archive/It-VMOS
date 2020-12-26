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
            Run();
        }
        protected override void Run()
        {
            System.Menu(true);
        }
    }
}
