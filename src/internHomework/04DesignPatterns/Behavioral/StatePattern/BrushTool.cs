using System;

namespace StatePattern
{
    class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Drawing with the brush...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Stopped drawing with the brush...");
        }
    }
}
