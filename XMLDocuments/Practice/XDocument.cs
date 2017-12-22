using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLDocuments
{
    public class XDocument
    {
        public static void PrintTags(string path)
        {
            XmlTextReader reader = new XmlTextReader(path);

            while (reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Element) Console.Write(reader.Name + "  ");
            }

            Console.ReadLine();
        }
    }
}
