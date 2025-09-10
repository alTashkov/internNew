using System;

namespace TemplateMethodPattern
{
    class WordExporter : DocumentExporter
    {
        protected override void ConvertToFormat()
        {
            Console.WriteLine("Converting file to Word...");
        }

        protected override void ParseContent()
        {
            Console.WriteLine("Parsing content for Word...");
        }
    }
}
