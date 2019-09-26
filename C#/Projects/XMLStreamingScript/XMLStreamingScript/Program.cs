using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WordStreamingScript
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSwitch; 

            Console.WriteLine("Enter xml directory");
            string xmlPath = Console.ReadLine();

            string[] xmlFilesDirectory = Directory.GetFiles(@xmlPath, "*.xml", SearchOption.AllDirectories);
            foreach (string file in xmlFilesDirectory)
            {
                ProcessFile(file);
            }
            foreach (string dirPath in Directory.GetDirectories(@xmlPath, "*", SearchOption.AllDirectories))

                Directory.CreateDirectory(dirPath.Replace(@xmlPath, @xmlPath + @"\temp\"));


            foreach (string newPath in Directory.GetFiles(@xmlPath, "*.xml*", SearchOption.AllDirectories))

                File.Copy(newPath, newPath.Replace(@xmlPath, @xmlPath + @"\temp\"), true);

            FileStream filestream = new FileStream(@xmlPath + @"/temp/logtemp.txt", FileMode.Create);
            var streamwriter = new StreamWriter(filestream);
            Console.WriteLine("Zrzucenie nazw obiektów do txt - wciśnij 1");
            Console.WriteLine("Zamiana nazw obiektów - wciśnij 2");
            Console.WriteLine("First letter to Uppercase");
            numSwitch = Convert.ToInt32(Console.ReadLine());

            string name = null;
            string newName = null;

            if (numSwitch == 2)
            {
                Console.WriteLine("Enter element value to change");
                name = Console.ReadLine();
                Console.WriteLine("Enter new element value");
                newName = Console.ReadLine();
            }
            for (int i = 0; i < xmlFilesDirectory.Length; i++)
            {

                Console.WriteLine(xmlFilesDirectory[i]);
                XmlDocument xml = new XmlDocument();
                xml.Load(xmlFilesDirectory[i]);
                XmlNodeList xnList = xml.SelectNodes("/annotation/object/name");

                switch (numSwitch)
                {

                    case 1:
                        foreach (XmlNode xn in xnList)
                        {
                            using (StreamWriter StreamW = new StreamWriter((@xmlPath + @"/temp/temp.txt"), true))

                            {
                                Console.WriteLine(xn.InnerText);
                                StreamW.WriteLine(xn.InnerText);
                            }
                        }


                        break;

                    case 2:

                        var doc = XDocument.Load(xmlFilesDirectory[i]);
                        var elementsToUpdate = doc.Descendants()
                                                  .Where(o => o.Value == name && !o.HasElements); ;

                        foreach (XElement element in elementsToUpdate)
                        {
                            element.Value = newName;

                        }

                        doc.Save(xmlFilesDirectory[i]);

                        break;

                        /* case 3:
                             foreach (XmlNode xn in xnList)
                             {
                                 UppercaseFirst(xn.Value);
                             }
                             xml.Save(files[i]);
                             break; */
                }
                streamwriter.AutoFlush = true;
                Console.SetOut(streamwriter);
                Console.SetError(streamwriter);
            }
            File.WriteAllLines(@xmlPath + " ClassNames.txt", File.ReadAllLines(@xmlPath + @"/temp/temp.txt").Distinct());
            File.WriteAllLines(@xmlPath + " log.txt", File.ReadAllLines(@xmlPath + @"/temp/logtemp.txt").Distinct());

            File.Delete(@xmlPath + @"/temp/temp.txt");
        }
        static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}',", path);
        }
        /*static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        } */
    }
}