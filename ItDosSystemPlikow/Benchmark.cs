using Cosmos.System.Graphics;
using SysD = System.Drawing;

namespace CosmosKernel2
{
    class Benchmark
    {
        public void BenchmarkGO()
        {
            VGACanvas can = new VGACanvas();
            VGAScreen.SetGraphicsMode(Cosmos.HAL.VGADriver.ScreenSize.Size640x480, ColorDepth.ColorDepth4);
            can.Clear(SysD.Color.Black);
            Pen p = new Pen(SysD.Color.Red);

            int x = 0;
            int y = 0;
            for (int i = 0; i <= 192; i++)
            {
                for (int j = 0; j <= 40; j++)
                    can.DrawFilledRectangle(p, x, y, j, j);
                x += 40;
                if (x == 640)
                {
                    x = 0;
                    y += 40;
                }
            }
        }
    }
}