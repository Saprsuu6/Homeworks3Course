using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class BuilderTeam : IEnumerable, IEnumerator
    {
        private Builder[] builders;

        private int current = -1;

        public BuilderTeam() => builders = new Builder[0];

        public object Current => throw new NotImplementedException();

        public void AddBuilder(Builder builder)
        {
            int i = 0;
            Builder[] newBuilders = new Builder[builders.Length + 1];

            foreach (Builder item in builders)
            {
                newBuilders[i] = item;
                i++;
            }
            newBuilders[builders.Length] = builder;

            builders = newBuilders;
        }

        public void DeleteBuilder(string speciality)
        {
            if (builders.Length == 0)
                throw new ApplicationException("The team is empty.");

            for (int i = 0; i < builders.Length; i++)
            {
                if (builders[i].Speciality == speciality)
                {
                    Builder[] newBuilders = new Builder[builders.Length - 1];

                    for (int j = 0; j < builders.Length - 1; j++)
                    {
                        if (j < i)
                        {
                            newBuilders[j] = builders[j];
                            continue;
                        }
                        newBuilders[i] = newBuilders[j + 1];
                    }

                    builders = newBuilders;
                    throw new ApplicationException("The builder was delete.");
                }

                if (i == builders.Length - 1)
                    throw new ApplicationException("The builder are not exists.");
            }
        }

        public Builder this[string speciality]
        {
            get
            {
                if (builders.Length == 0)
                    throw new ApplicationException("The temp is empty.");

                Builder builder = null;
                foreach (Builder temp in builders)
                {
                    if (temp.Speciality == speciality)
                    {
                        builder = temp;
                        break;
                    }
                }

                if (builder == null)
                    throw new ApplicationException("The builder are not exists.");

                return builder;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if ((current < builders.Length - 1))
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
