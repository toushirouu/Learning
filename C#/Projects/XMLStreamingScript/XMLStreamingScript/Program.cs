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
        static void Main(string[] args) //This app has two functions, mass exctration objects names from XML file and changin objects name in all XML files
                                        //The rest of the comments are just for my learning
        {
            int numSwitch;
            string objectName = null;
            string objectNewName = null;

            Console.WriteLine("Enter xml directory");
            string xmlPath = Console.ReadLine();

            //searching for .xml files in the given directory and subdirectories, saving directories in array
            string[] xmlFilesDirectory = Directory.GetFiles(@xmlPath, "*.xml", SearchOption.AllDirectories);

            //print all files name on screen
            foreach (string file in xmlFilesDirectory)
            {
                ProcessFile(file);
            }

            //getting all directories and subdirectories from enterd xmlPath, then creating temp folder inside
            foreach (string dirPath in Directory.GetDirectories(@xmlPath, "*", SearchOption.AllDirectories))

                Directory.CreateDirectory(dirPath.Replace(@xmlPath, @xmlPath + @"\temp\"));

            //getting all files from xmlPath directory and subdirectories, then copying them to temp folder
            foreach (string newPath in Directory.GetFiles(@xmlPath, "*.xml*", SearchOption.AllDirectories))

                File.Copy(newPath, newPath.Replace(@xmlPath, @xmlPath + @"\temp\"), true);


            //creating txt file in which wiil be streaming everything printed on screen
            FileStream filestream = new FileStream(@xmlPath + @"/temp/logtemp.txt", FileMode.Create);
            var streamwriter = new StreamWriter(filestream);

            Console.WriteLine("Zrzucenie nazw obiektów do txt - wciśnij 1");
            Console.WriteLine("Zamiana nazw obiektów - wciśnij 2");
            Console.WriteLine("First letter to Uppercase");

            numSwitch = Convert.ToInt32(Console.ReadLine());

            if (numSwitch == 2)
            {
                Console.WriteLine("Enter element value to change");
                objectName = Console.ReadLine();
                Console.WriteLine("Enter new element value");
                objectNewName = Console.ReadLine();
            }

            for (int i = 0; i < xmlFilesDirectory.Length; i++)
            {
                //printing xml files directory on screen
                Console.WriteLine(xmlFilesDirectory[i]);

                //creating new xml document named xml
                XmlDocument xml = new XmlDocument();

                //loading every xml files to xml
                xml.Load(xmlFilesDirectory[i]);

                //creating xml list named xnList, selecting specific nodes from xml
                XmlNodeList xnList = xml.SelectNodes("/annotation/object/name");

                switch (numSwitch)
                {
                    case 1:

                        foreach (XmlNode xn in xnList)
                        {
                            //creating variable named streamW, pointing the path, true allow to overwritting
                            using (StreamWriter StreamW = new StreamWriter((@xmlPath + @"/temp/temp.txt"), true))

                            {
                                //printing on screen every objects name
                                Console.WriteLine(xn.InnerText);
                                //streaming to txt file every objects name
                                StreamW.WriteLine(xn.InnerText);
                            }
                        }
                        break;

                    case 2:


                        var doc = XDocument.Load(xmlFilesDirectory[i]);
                        var elementsToUpdate = doc.Descendants()
                                                  .Where(o => o.Value == objectName && !o.HasElements); ;

                        foreach (XElement element in elementsToUpdate)
                        {
                            element.Value = objectNewName;
                        }
                        doc.Save(xmlFilesDirectory[i]);
                        break;

                }
                streamwriter.AutoFlush = true;
                Console.SetOut(streamwriter);
                Console.SetError(streamwriter);
            }
            File.WriteAllLines(@xmlPath + " ClassNames.txt", File.ReadAllLines(@xmlPath + @"/temp/temp.txt").Distinct());
            File.WriteAllLines(@xmlPath + " log.txt", File.ReadAllLines(@xmlPath + @"/temp/logtemp.txt").Distinct());

            File.Delete(@xmlPath + @"/temp/temp.txt");
        }

        //print file name on screen
        static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}',", path);
        }

    }
}