using System;

namespace CosmosKernel2
{
    class SystemInformation
    {
        public static void Show()
        {
            Console.WriteLine("System: Iterkocze Company, It-VMOS 32-Bit OS");
            Console.WriteLine("System Version: 0.0.5.9");
            Console.WriteLine("Build Date: 28.12.2020");
            Console.WriteLine("RAM: " + Cosmos.Core.CPU.GetAmountOfRAM() + " MB");
            Console.WriteLine($"Disk Freespace: {Kernel.fs.GetAvailableFreeSpace("0:/") / 1000000}MB");
            Console.WriteLine($"Filesystem Type: {Kernel.fs.GetFileSystemType("0:/")}");
        }
    }
}
