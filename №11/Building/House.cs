using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class House : IEnumerable, IEnumerator
    {
        private Basemant basemant;
        private Wall[] walls;
        private Window[] windows;
        private Door door;
        private Roof roof;

        private int current = -1;

        public House() { }

        public Basemant Basemant { set { basemant = value; } get { return basemant; } }
        public Wall[] Walls { set { walls = value; } get { return walls; } }
        public Window[] Windows { set { windows = value; }get { return windows; } }
        public Door Door { set { door = value; } get { return door; } }
        public Roof Roof { set { roof = value; } get { return roof; } }

        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if ((current < walls.Length - 1) || (current < windows.Length - 1))
            {
                current++;
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
            current = -1;
        }
    }
}
