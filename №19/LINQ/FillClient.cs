using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    delegate void Filling();

    abstract class FillClient
    {
        static private List<Filling> filling = new List<Filling>();

        static private string name;
        static private string surname;
        static private string recordingTime;
        static private string endTime;
        static private uint computerNumber;

        static private event Filling ev
        {
            add => filling.Add(value);
            remove => filling.Remove(value);
        }

        static private void Name()
        {
            Console.Write("Введите имя клиента: ");
            name = Console.ReadLine();
        }

        static private void Surname()
        {
            Console.Write("Введите фамилию клиента: ");
            surname = Console.ReadLine();
        }

        static private void RecordingTime()
        {
            Console.Write("Введите время начала (*:*): ");
            recordingTime = Console.ReadLine();
        }

        static private void EndTime()
        {
            Console.Write("Введите время конца (*:*): ");
            endTime = Console.ReadLine();
        }

        static private void ComputerNumber()
        {
            Console.Write("Введите номер комьютера: ");
            computerNumber = Convert.ToUInt32(Console.ReadLine());
        }

        static public Client Invoke()
        {
            ev += Name;
            ev += Surname;
            ev += ComputerNumber;
            ev += RecordingTime;
            ev += EndTime;

            foreach (Filling item in filling)
                item?.Invoke();

            return new Client(new Person(name, surname),
                              computerNumber,
                              DateTime.Parse(recordingTime),
                              DateTime.Parse(endTime));
        }
    }
}
