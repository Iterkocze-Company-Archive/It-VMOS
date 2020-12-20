using Cosmos.System.Graphics;
using System.Drawing;

namespace CosmosKernel2
{
    class Benchmark
    {

        public void BenchmarkGO()
        {
            VGACanvas can = new VGACanvas();
            VGAScreen.SetGraphicsMode(Cosmos.HAL.VGADriver.ScreenSize.Size640x480, ColorDepth.ColorDepth4);
            can.Clear(Color.Blue);
            Pen p = new Pen(Color.Red);

           
            can.DrawLine(p, 100,120,150,166);
            can.DrawSquare(p,280,300,40);
        }
    }
}
