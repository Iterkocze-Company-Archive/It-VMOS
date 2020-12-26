using Cosmos.System.Graphics;
using Cosmos.HAL;
using System.Drawing;

namespace CosmosKernel2
{
    class TestGrafiki
    {
        public void Pulpit()
        {
            VGACanvas can = new VGACanvas();
            VGAScreen.SetGraphicsMode(VGADriver.ScreenSize.Size640x480, ColorDepth.ColorDepth4);
            can.Clear(Color.Blue);
        } 
    }
}
