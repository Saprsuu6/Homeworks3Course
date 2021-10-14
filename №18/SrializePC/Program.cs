using System;
using System.Collections.Generic;
using System.Reflection;
using ClassLib;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization.Json;

namespace SrializePC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> pCs = new List<PC>();
            pCs.Add(new PC("samsung", "123qwe", "pc123", "intel core i7"));
            pCs.Add(new PC("apple", "456qwe", "pc123", "intel core i7"));
            pCs.Add(new PC("lenovo", "789qwe", "pc123", "intel core i7"));
            pCs.Add(new PC("THinkCenter", "012qwe", "pc123", "intel core i7"));

            Type type = typeof(PC);
            foreach (MemberInfo mi in type.GetMembers())
                Console.WriteLine(mi.DeclaringType + " " + mi.MemberType + " " + mi.Name);

            string path = "../../../../PCsInfo.json";

            try
            {
                if (File.Exists(path))
                    File.Delete(path);

                FileStream stream = new FileStream(path, FileMode.Create);
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<PC>));
                jsonFormatter.WriteObject(stream, pCs);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
