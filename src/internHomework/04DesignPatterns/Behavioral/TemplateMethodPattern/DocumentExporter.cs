using System;

namespace TemplateMethodPattern
{
    abstract class DocumentExporter
    {
        public void Export()
        {
            OpenDocument();
            ParseContent();
            ConvertToFormat();
            SaveDocument();
        }

        protected void OpenDocument()
        {
            Console.WriteLine("Opening document...");
        }

        protected abstract void ParseContent();

        protected abstract void ConvertToFormat();

        protected void SaveDocument()
        {
            Console.WriteLine("Saving document...");
        }

    }
}
