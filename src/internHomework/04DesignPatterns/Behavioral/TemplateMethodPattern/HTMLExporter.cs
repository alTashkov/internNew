using System;

namespace TemplateMethodPattern
{
    class HTMLExporter : DocumentExporter
    {
        protected override void ConvertToFormat()
        {
            Console.WriteLine("Converting file to HTML...");
        }

        protected override void ParseContent()
        {
            Console.WriteLine("Parsing content for HTML...");
        }
    }
}
