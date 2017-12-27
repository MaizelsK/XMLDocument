using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace XMLDocuments
{
    public class Homework
    {
        static public void Task1()
        {
            List<Item> items = new List<Item>();

            XmlTextReader reader = new XmlTextReader("https://habrahabr.ru/rss/interesting/");

            while (reader.Read())
            {
                Item item = new Item();

                while (reader.Read() && item.PubDate == null)
                {
                    if (reader.NodeType == XmlNodeType.Element)
                        switch (reader.Name)
                        {
                            case "title":
                                reader.Read();
                                item.Title = reader.ReadString();
                                break;

                            case "link":
                                reader.Read();
                                item.Link = reader.ReadString();
                                break;

                            case "description":
                                reader.Read();
                                item.Description = reader.ReadString();
                                break;

                            case "pubDate":
                                reader.Read();
                                item.PubDate = reader.ReadString();
                                break;
                        }
                }
                items.Add(item);
            }

            foreach (var item in items)
            {
                Program.PrintItem(item);

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static public void Task2()
        {
            XmlDocument document = new XmlDocument();
            document.Load("student.xml");

            var root = document.DocumentElement;

            foreach(XmlNode child in root.ChildNodes)
            {
                if(child.NodeType == XmlNodeType.Text)
                    Console.WriteLine(child.InnerText);
            }
        }
    }
}