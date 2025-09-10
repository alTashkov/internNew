using System;

namespace StatePattern
{
    internal class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Erasing elements...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Stopped erasing elements...");
        }
    }
}
