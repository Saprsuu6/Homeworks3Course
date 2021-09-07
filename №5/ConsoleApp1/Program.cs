using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class LogicExeption : Exception
    {
        public LogicExeption(string message)
            : base(message)
        { }
    }
    class CarInfo
    {
        private Car car;

        public CarInfo(Car car) => this.car = car;
        public void ShowInfo()
        {
            Console.WriteLine("Amount of weels is {0}", car.AmountWeels);
            Console.WriteLine("Country is {0}", car.Country);
            Console.WriteLine("Model is {0}", car.Model);
            Console.WriteLine("Colour is {0}", car.Colour);
            Console.WriteLine("Gas type is {0}", car.GasType);
            Console.WriteLine("Amount places is {0}", car.AmountPlaces);
            Console.WriteLine("Max speed is {0}", car.MaxSpeed);
            Console.WriteLine("amount of KPP is {0}", car.Transmission);
        }
        public void InfoInRealTime()
        {
            Console.WriteLine("Speed now is {0}", car.SpeedNow);
            Console.WriteLine("Transmission now is {0}", car.TransmissionNow);
        }
    }
    partial class Car
    {
        private static int amountWeels;
        private readonly string country;

        private string model;
        private string colour;
        private string type;
        private string gasType;

        private int amountPlaces;
        private const int maxSpeed = 250;
        private int speedNow = 0;
        private int transmissionNow = 0;
        private const int board = 50;
        private readonly int[] transmission = new int[] { 0, 1, 2, 3, 4, 5, -1 };

        private bool engine = false;

        static Car()
        {
            amountWeels = 4;
        }

        public Car() { }
        public Car(string country, string model, string colour, string type,
            string gasType, int amountPlaces)
        {
            this.country = country;
            this.model = model;
            this.colour = colour;
            this.type = type;
            this.gasType = gasType;
            this.amountPlaces = amountPlaces;
        }

        public int MaxSpeed { get { return maxSpeed; } }
        public int Board { get { return board; } }
        public int Transmission { get { return transmission.Length; } }
        public int TransmissionNow { get { return transmissionNow; } }
        public bool Engine { get { return engine; } }
        public int SpeedNow { get { return speedNow; } }
        public int AmountWeels { get { return amountWeels; } }
        public string Country { get { return country; } }
        public string Model { set { model = value; } get { return model; } }
        public string Colour { set { colour = value; } get { return colour; } }
        public string Type { set { type = value; } get { return type; } }
        public string GasType { set { gasType = value; } get { return gasType; } }
        public int AmountPlaces { set { amountPlaces = value; } get { return amountPlaces; } }

        public void SwitchOnEngine() => engine = true;
        public void SwitchOffEngine() => engine = false;
        public void changeTransmission(ref bool temp)
        {
            if (temp)
            {
                if (transmissionNow != transmission.Length - 2)
                {
                    transmissionNow = transmission[transmissionNow + 1];
                }
                else
                {
                    throw new LogicExeption("You get the boar!");
                }
            }
            else if (!temp)
            {
                if (transmissionNow != 0 && transmissionNow != -1)
                {
                    transmissionNow = transmission[transmissionNow - 1];
                }
                else if (transmissionNow == 0)
                {
                    transmissionNow = -1;
                }
                else
                {
                    throw new LogicExeption("You get the boar!");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Germany", "audi", "balck", "sidan", "95", 5);

            CarInfo info = new CarInfo(car);
            info.ShowInfo();

            car.SwitchOnEngine();

            bool True = true;
            bool False = false;

            if (car.Engine)
            {
                #region Разгон
                for (int i = 0; i < 5; i++)
                {
                    car.changeTransmission(ref True);

                    for (int j = 0; j < car.Board; j++)
                    {
                        car.GoFaster();
                        info.InfoInRealTime();
                    }
                }
                #endregion

                #region Понижение
                for (int a = 0; a < 5; a++)
                {
                    for (int j = 0; j < car.Board; j++)
                    {
                        car.GoSlowly();
                        info.InfoInRealTime();
                    }

                    car.changeTransmission(ref False);
                }
                #endregion

                #region Задняя передача
                car.changeTransmission(ref False);
                for (int j = 0; j < car.Board / 2; j++)
                {
                    car.GoFaster();
                    info.InfoInRealTime();
                }
                for (int j = 0; j < car.Board / 2; j++)
                {
                    car.GoSlowly();
                    info.InfoInRealTime();
                }
                #endregion

                #region Возврат на нейтральную
                car.changeTransmission(ref True);
                info.InfoInRealTime();
                #endregion
            }
        }
    }
}
