using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerialization
{
    public class clsPerson
    {
        public string FirstName;
        public string MI;
        public string LastName;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson p = new clsPerson();
            p.FirstName = "Jeff";
            p.MI = "A";
            p.LastName = "Price";
            XmlSerializer x = new XmlSerializer(p.GetType());
            x.Serialize(Console.Out, p);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
