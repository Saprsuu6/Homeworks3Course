using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadCs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StringWriter newBufer = new StringWriter())
                {
                    string path = "RegistrationForm.cs";
                    using (StreamReader reader = new StreamReader(path))
                    {
                        Changing change = new Changing();
                        StringBuilder bufer = new StringBuilder();
                        while ((change.Line = reader.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(change.Line))
                            {
                                // замена слов длиннее 2 символов
                                if (change.Line.Any(@char => char.IsLetter(@char)))
                                {
                                    change.Split();
                                    change.UpperCase();
                                    change.Join();
                                    change.Tabulation();
                                }
                                //

                                bufer.AppendLine(change.Line);

                                // замена private на public
                                bufer.Replace("public", "private");
                                //

                                newBufer.Write(bufer);

                                bufer.Clear();

                                change.PrevLine = change.Line;
                            }
                        }
                    }

                    using (StreamWriter writer = new StreamWriter(path, false))
                    {
                        writer.Write(newBufer);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
