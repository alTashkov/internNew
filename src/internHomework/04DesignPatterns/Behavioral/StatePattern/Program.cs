using System;

namespace StatePattern
{
    internal class Program
    {
        //state pattern takes states within a class and places
        //them in interfaces.
        //This strongly supports the open closed principle.
        //the class becomes open for extension - more states can be
        //added and applied
        //closed for modification - we only modify the states outside of 
        //the class
        static void Main(string[] args)
        {
            SelectionTool selection = new SelectionTool();
            BrushTool brush = new BrushTool();

            Canvas canvas = new Canvas(selection);
            canvas.MouseDown();
            canvas.MouseUp();

            Console.WriteLine();
            Canvas canvas2 = new Canvas(brush);
            canvas2.MouseDown();
            canvas2.MouseUp();
        }
    }
}
