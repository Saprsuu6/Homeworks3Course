using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicGroup
{
    class AcademyGroup : ICloneable, IEnumerable, IEnumerator
    {
        private Student[] array;
        private int counter = -1;

        public AcademyGroup() => array = new Student[0];

        public int Amount { get { return array.Length; } }

        public object Current => throw new NotImplementedException();

        public void AddStudent(Student student)
        {
            int i = 0;
            Student[] newArray = new Student[array.Length + 1];

            foreach (Student temp in array)
            {
                newArray[i] = temp;
                i++;
            }
            newArray[array.Length] = student;

            array = newArray;
        }

        public void DeleteStudent(string surname)
        {
            if (array.Length == 0)
                throw new ApplicationException("The group is empty.");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Surame == surname)
                {
                    Student[] newArray = new Student[array.Length - 1];

                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (j < i)
                        {
                            newArray[j] = array[j];
                            continue;
                        }
                        newArray[i] = array[j + 1];
                    }

                    array = newArray;
                    throw new ApplicationException("The student was delete.");
                }

                if (i == array.Length - 1)
                    throw new ApplicationException("The student are not exists.");
            }
        }

        public Student this[string surname]
        {
            get
            {
                if (array.Length == 0)
                    throw new ApplicationException("The group is empty.");

                Student student = null;
                foreach (Student temp in array)
                {
                    if (temp.Surame == surname)
                    {
                        student = temp;
                        break;
                    }                      
                }

                if (student == null)
                    throw new ApplicationException("The student are not exists.");

                return student;
            }
        }

        public Student this[uint i]
        {
            get
            {
                if (array.Length == 0)
                    throw new ApplicationException("The group is empty.");

                if (i < array.Length)
                    throw new ApplicationException("Out index array.");

                return array[i];
            }
        }

        public void EditStudent(string surname)
        {
            Student student = this[surname];

            Console.Write("Name - 1\nSuname - 2\nAge - 3\nPhone number - 4\n" +
                "Avarage - 5\nNumber of group - 6\nMake your choose: ");

            int temp = Convert.ToInt32(Console.ReadLine());

            switch (temp)
            {
                case 1:
                    Console.Write("Enter name: ");
                    student.Name = Console.ReadLine();
                    break;

                case 2:
                    Console.Write("Enter surname: ");
                    student.Surame = Console.ReadLine();
                    break;

                case 3:
                    Console.Write("Enter age: ");
                    student.Age = Convert.ToUInt32(Console.ReadLine());
                    break;

                case 4:
                    Console.Write("Enter phone number: ");
                    student.PhoneNumber = Console.ReadLine();
                    break;

                case 5:
                    Console.Write("Enter avarage: ");
                    student.Avarage = Convert.ToUInt32(Console.ReadLine());
                    break;

                case 6:
                    Console.Write("Enter number of group: ");
                    student.NumberOfGroup = Console.ReadLine();
                    break;
            }
        }

        public void PrintGroup()
        {
            foreach (Student temp in array)
            {
                Console.WriteLine("Name - {0}\nSurname - {1}\nAge - {2}\n" +
                    "Phone number - {3}\nAvarage - {4}\nNumber of group - {5}",
                    temp.Name, temp.Surame, temp.Age, temp.NumberOfGroup, temp.Avarage, temp.NumberOfGroup);
            }
        }

        public void SortByName()
        {
            Array.Sort(array, new Student.SortByName());
            throw new ApplicationException("Group was sorted");
        }

        public void SortBySurname()
        {
            Array.Sort(array, new Student.SortByName());
            throw new ApplicationException("Group was sorted");
        }

        public void SortByAge()
        {
            Array.Sort(array, new Student.SortByAge());
            throw new ApplicationException("Group was sorted");
        }

        public void SortByNumberOfGroup()
        {
            Array.Sort(array, new Student.SortByNumberOfGroup());
            throw new ApplicationException("Group was sorted");
        }

        public void SortByAvarage()
        {
            Array.Sort(array, new Student.SortByAvarage());
            throw new ApplicationException("Group was sorted");
        }

        public object Clone()
        {
            int i = 0;
            Student[] newArray = new Student[array.Length];

            foreach (Student temp in array)
            {
                newArray[i] = temp;
                i++;
            }

            return newArray;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (counter < array.Length - 1)
            {
                counter++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            counter = -1;
        }
    }
}
