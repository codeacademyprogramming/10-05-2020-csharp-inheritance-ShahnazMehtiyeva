using System;

namespace _10._05._2020task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter type of document (basic , pro , expert) ");
            string docType = Console.ReadLine();

            DocumentProgram program =new DocumentProgram();
            switch (docType)
            {
                case "basic":
                    program = new DocumentProgram();
                    break;
                case "pro":
                    program = new ProDocumentProgram();
                    break;
                case "expert":
                    program = new ExpertDocument();
                    break;
                default:
                    Console.WriteLine("There is no such program type");
                    break;
            }
            program.OpenDocument();
            program.EditDocument();
            program.SaveDocument();
        }
    }

    class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }

    class ProDocumentProgram : DocumentProgram
    {
        public override sealed void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }

    class ExpertDocument : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
