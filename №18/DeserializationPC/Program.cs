using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Json;
using ClassLib;

namespace DeserializationPC
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../../PCsInfo.json";

            List<PC> pCs = null;

            try
            {
                if (!File.Exists(path))
                    throw new ApplicationException("File is not exists.");

                FileStream stream = new FileStream(path, FileMode.Open);
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<PC>));
                pCs = (List<PC>)jsonFormatter.ReadObject(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Type type = typeof(PC);
            foreach (MemberInfo mi in type.GetMembers())
                Console.WriteLine(mi.DeclaringType + " " + mi.MemberType + " " + mi.Name);
        }
    }
}
