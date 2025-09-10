namespace StatePattern
{
    public class Canvas
    {
        private ITool _tool;

        public Canvas(ITool tool)
        {
            _tool = tool;
        }

        public void MouseDown()
        {
            _tool.MouseDown();
        }

        public void MouseUp()
        {
            _tool.MouseUp();
        }
    }
}
