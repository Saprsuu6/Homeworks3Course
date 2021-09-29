using System;
/*
 * Records представляют новый ссылочный тип, который появился в C#9. Ключевая особенность records состоит в том, что они могут представлять неизменяемый (immutable) тип, который по умолчанию обладает рядом дополнительных возможностей по сравнению с классами. Зачем нам нужны неизменяемые типы? Такие типы более безопасны в тех ситуациях, когда нам надо гарантировать, что данные объекта не будут изменяться. 
 
 */
namespace Records
{
    public record Point
    {
        public int X { get; init; }
        public int Y { get; init; }

        public Point() { }

        public Point(int x, int y)
        {
            X = x; Y = y;
        }
        // реализован деконструктор, который позволяет разложить объект Person на кортеж значений
        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(1, 3);

            Point point2 = point with { X = 10 };

            var (x, y) = point2;

            int X = x;
            int Y = y;
        }
    }
  
}
