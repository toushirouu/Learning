using System;
using System.Xml;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WordStreamingScript
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"E:\Learning\C#\Projects\WordStreamingScript\WordStreamingScript\WordStreamingScript\bin\Debug", "str*.xml");
            foreach (string file in files)
            {
                ProcessFile(file);
            }
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
                XmlDocument xml = new XmlDocument();
                xml.Load(files[i]);

                XmlNodeList xnList = xml.SelectNodes("/Names/Name");
                foreach (XmlNode xn in xnList)
                {

                    using (StreamWriter StreamW = new StreamWriter(("lol.txt"), true))
                    {
                        StreamW.WriteLine(xn.InnerText);
                    }
                }
            }
            File.WriteAllLines("lol1.txt", File.ReadAllLines("lol.txt").Distinct());

        }
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}',", path);
        }


    }
}

