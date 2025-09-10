using System;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentExporter pdfExporter = new PdfExporter();

            DocumentExporter wordExporter = new WordExporter();

            DocumentExporter htmlExporter = new HTMLExporter();

            Console.WriteLine("Exporting PDF: ");
            pdfExporter.Export();

            Console.WriteLine("\nExporting Word: ");
            wordExporter.Export();

            Console.WriteLine("\nExporting HTML: ");
            htmlExporter.Export();
        }
    }
}
