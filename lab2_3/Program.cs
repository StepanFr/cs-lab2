namespace lab2_3
{

    using System;

    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }

    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }

    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ доступа (pro/exp): ");
            string key = Console.ReadLine();

            DocumentWorker worker;

            switch (key)
            {
                case "pro":
                    worker = new ProDocumentWorker();
                    break;
                case "exp":
                    worker = new ExpertDocumentWorker();
                    break;
                default:
                    worker = new DocumentWorker();
                    break;
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.ReadKey();
        }
    }

}
