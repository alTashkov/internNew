using System;

namespace StatePattern
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selecting elements...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Deselecting elements...");
        }
    }
}
