using System;

namespace TemplateMethodPattern
{
    class PdfExporter : DocumentExporter
    {
        protected override void ConvertToFormat()
        {
            Console.WriteLine("Converting file to PDF...");
        }

        protected override void ParseContent()
        {
            Console.WriteLine("Parsing content for PDF...");
        }
    }
}
