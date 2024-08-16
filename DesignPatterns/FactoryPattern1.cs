using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Document
    {
        public abstract void Open();
    }

    public class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Word document.");
        }
    }

    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening PDF document.");
        }
    }

    public class ExcelDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Excel document.");
        }
    }

    public class DocumentFactory
    {
        public static Document CreateDocument(string type)
        {
            switch (type.ToLower())
            {
                case "word":
                    return new WordDocument();
                case "pdf":
                    return new PdfDocument();
                case "excel":
                    return new ExcelDocument();
                default:
                    throw new ArgumentException("Invalid document type");
            }
        }
    }
}
