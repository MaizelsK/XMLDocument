using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLDocuments
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASSWORK

            /*XmlDocument document = new XmlDocument();

            document.Load("Book.xml");
            var root = document.DocumentElement;

            XmlElement element = document.CreateElement("Book");
            element.SetAttribute("Id", "e538a333-031f-4808-b37c-2276fcee2377");

            root.AppendChild(element);

            foreach(XmlNode child in root.ChildNodes)
            {
                Book book = new Book();
                book.Id = Guid.Parse(child.Attributes["Id"].InnerText);
            }

            document.Save("Book.xml");*/

            //PRACTICE

            //XDocument.PrintTags("Book.xml");

            //HOMEWORK

            Homework.Task2();
        }

        static public void PrintItem(Item item)
        {
            Console.WriteLine($"{item.Title}\n\n" +
                $"{item.Description}\n\n" +
                $"{item.Link}\n" +
                $"{item.PubDate}\n" +
                $"-----------------------------------------");
        }
    }
}
