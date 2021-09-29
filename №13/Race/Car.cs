using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    abstract class Car : IEnumerable, IEnumerator
    {
        protected List<MyDelegate> list = new List<MyDelegate>();
        protected string name;
        protected uint speed;
        protected uint progress;
        protected uint maxSpeed;
        protected int minSpeed;
        protected bool engine;
        protected int current = -1;

        public Car(string name, uint maxSpeed, int minSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.minSpeed = minSpeed;
        }

        public uint Speed { get { return speed; } }
        public uint Progress { get { return progress; } }
        public string Name { get { return name; } }
        public object Current { get { return current; } }

        public event MyDelegate ev { add { list.Add(value); } remove { list.Remove(value); } }

        public void StratEnd()
        {
            foreach (MyDelegate item in list)
            {
                item.Invoke();
            }
        }
        public abstract void ChangeColour();
        public void EngineOn()
        {
            if (!engine) 
                engine = true;
        }
        public void EngineOff()
        {
            if (engine)
                engine = false;
        }
        public void Stop() => speed = 0;
        public void Go()
        {
            if (engine)
            {
                Random random = new Random();
                int temp = 5;
                speed = maxSpeed;

                for (int i = 0; i < 100; i++)
                {
                    if (random.Next(0, 10) == temp)
                        progress++;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (current < list.Count - 1)
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
