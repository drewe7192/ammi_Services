using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace AmmiServices.Services
{
    public class ANN
    {
        public void getListOfStuff()
        {
            XmlReader xmlReader = XmlReader.Create("https://www.animenewsnetwork.com/encyclopedia/reports.xml?id=155");
            while(xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "name"))
                {
                    if (xmlReader.HasAttributes)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
        public void Run()
        {
            getListOfStuff();
        }
    }
}
