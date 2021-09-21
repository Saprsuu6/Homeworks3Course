using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicGroup
{
    class Student : Person/*, IComparable*/
    {
        private uint avarage;
        private string numberOfGroup;

        public Student(string name, string surname, uint age, string phoneNumber,
            uint avarage, string numberOfGroup) : base(name, surname, age, phoneNumber)
        {
            this.avarage = avarage;
            this.numberOfGroup = numberOfGroup;
        }

        public uint Avarage { set { avarage = value; } get { return avarage; } }
        public string NumberOfGroup { set { numberOfGroup = value; } get { return numberOfGroup; } }

        //public int CompareTo(object obj)
        //{
        //    if (obj is Student)
        //        return name.CompareTo((obj as Student).name);

        //    throw new NotImplementedException();
        //}

        public class SortByName : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).name.CompareTo((obj2 as Student).name);

                throw new NotImplementedException();
            }
        }
        public class SortBySurname : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).Surame.CompareTo((obj2 as Student).Surame);

                throw new NotImplementedException();
            }
        }
        public class SortByAge : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).Age.CompareTo((obj2 as Student).Age);

                throw new NotImplementedException();
            }
        }
        public class SortByAvarage : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).avarage.CompareTo((obj2 as Student).avarage);

                throw new NotImplementedException();
            }
        }
        public class SortByNumberOfGroup : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).numberOfGroup.CompareTo((obj2 as Student).numberOfGroup);

                throw new NotImplementedException();
            }
        }
    }
}
