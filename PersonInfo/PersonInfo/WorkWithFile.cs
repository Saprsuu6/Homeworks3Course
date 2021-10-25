using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PersonInfo
{
    class WorkWithFile
    {
        static private string path = @"..\..\..\PersonInfo\";

        static private FileInfo[] FindDirictory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            FileInfo[] fileInfos = directoryInfo.GetFiles();

            return directoryInfo.GetFiles();
        }

        static public void ReadingXml(List<Person> people, Persons form)
        {
            FileInfo[] fileInfos = FindDirictory();

            if (fileInfos.Length < 1)
                return;

            XmlDocument xdoc = new XmlDocument();
            string newPath;

            foreach (FileInfo item in fileInfos)
            {
                if (item.Extension == ".xml")
                {
                    newPath = path + item.Name;
                    xdoc.Load(newPath);
                    string info = "";

                    XmlNode node = xdoc.DocumentElement;
                    XmlAttributeCollection xmlAttributeCollection = node.Attributes;
                    foreach (XmlAttribute attribute in xmlAttributeCollection)
                        info += attribute.Value + ";";

                    XmlNodeList xmlNodeList = node.ChildNodes;
                    foreach (XmlNode child in xmlNodeList)
                        info += child.InnerText + ";";

                    string[] correctInfo = info.Split(new[] { ';' });
                    Person person = new Person(correctInfo);
                    people.Add(person);
                    form.List.Items.Add(person.Surname + " " + person.Name + " " + person.Patronimic);
                }
            }
        } 

        static public void WriteToFileXml(Person person)
        {
            string newPath = path + person.Name + " " 
                + person.Surname + " " +
                person.Patronimic + ".xml";

            using (XmlTextWriter xmlwriter = new XmlTextWriter(newPath, Encoding.UTF8))
            {
                xmlwriter.WriteStartDocument();
                xmlwriter.Formatting = Formatting.Indented;
                xmlwriter.IndentChar = '\t';
                xmlwriter.Indentation = 1;

                xmlwriter.WriteStartElement("Person");

                xmlwriter.WriteStartAttribute("Name", null);
                xmlwriter.WriteString(person.Name);
                xmlwriter.WriteEndAttribute();

                xmlwriter.WriteStartAttribute("Surname", null);
                xmlwriter.WriteString(person.Surname);
                xmlwriter.WriteEndAttribute();

                xmlwriter.WriteStartAttribute("Patronimic", null);
                xmlwriter.WriteString(person.Patronimic);
                xmlwriter.WriteEndAttribute();

                xmlwriter.WriteStartElement("Sex");
                xmlwriter.WriteString(person.Sex);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("Birthday");
                xmlwriter.WriteString(person.Birthday.Year.ToString() + "/" +
                    person.Birthday.Month.ToString() + "/" +
                    person.Birthday.Day.ToString());
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("FamalyStatus");
                xmlwriter.WriteString(person.FamalyStatus);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteStartElement("Info");
                xmlwriter.WriteString(person.Info);
                xmlwriter.WriteEndElement();

                xmlwriter.WriteEndElement();
            }
        }

        static public void WriteToFileTxt(Person person)
        {
            string newPath = path + person.Name + " "
                + person.Surname + " " +
                person.Patronimic + ".txt";

            using (StreamWriter txtWriter = new StreamWriter(newPath, false))
            {
                txtWriter.WriteLine("Name: " + person.Name);
                txtWriter.WriteLine("Surname: " + person.Surname);
                txtWriter.WriteLine("Patronimic: " + person.Patronimic);
                txtWriter.WriteLine("Sex: " + person.Sex);
                txtWriter.WriteLine("Birthday:\n\tYear: {0}\n\tMonth: {1}\n\tDay: {2}",
                    person.Birthday.Year, person.Birthday.Month, person.Birthday.Day);
                txtWriter.WriteLine("Info: " + person.Info);
            }
        }
    }
}
