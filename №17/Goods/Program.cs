using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace Goods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AllInfo> goods = new List<AllInfo>();

            Good good = new Good("washing machine", "BOSH", "123", 001, 1);
            Manufucturer manufucturer = new Manufucturer("Ukrain", new DateTime(2002, 08, 27));
            Chracteristics chracteristics = new Chracteristics("-", "-", "-");
            Price price = new Price(1000, 10000);
            Credit credit = new Credit(24, 20);
            AllInfo allInfo = new AllInfo(good, manufucturer, chracteristics, price, credit);

            goods.Add(allInfo);
            goods.Add(allInfo);
            goods.Add(allInfo);

            string path;
            int counter = 1;
            int index;

            XmlTextWriter writer = null;

            foreach (AllInfo item in goods)
            {
                path = "../../../Good.xml";
                index = path.IndexOf("d");
                path = path.Insert(index + 1, Convert.ToString(counter));

                writer = new XmlTextWriter(path, Encoding.UTF8);
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartElement("all info");

                #region good
                writer.WriteStartElement(item.Good.Name);

                writer.WriteStartElement("firm");
                writer.WriteStartAttribute("some atribute", null);
                writer.WriteString("-");
                writer.WriteEndAttribute();
                writer.WriteString(item.Good.Name);
                writer.WriteEndElement();

                writer.WriteStartElement("model");
                writer.WriteString(item.Good.Model);
                writer.WriteEndElement();

                writer.WriteStartElement("serial number");
                writer.WriteString(Convert.ToString(item.Good.SerialNumber));
                writer.WriteEndElement();

                writer.WriteStartElement("number");
                writer.WriteString(Convert.ToString(item.Good.Number));
                writer.WriteEndElement();

                writer.WriteEndElement();
                #endregion

                #region manufucturer
                writer.WriteStartElement("manufacturer");

                writer.WriteStartElement("country");
                writer.WriteStartAttribute("some atribute", null);
                writer.WriteString("-");
                writer.WriteEndAttribute();
                writer.WriteString(item.Manufucturer.Country);
                writer.WriteEndElement();

                writer.WriteStartElement("data");

                writer.WriteStartElement("day");
                writer.WriteString(Convert.ToString(item.Manufucturer.Date.Day));
                writer.WriteEndElement();
                writer.WriteStartElement("month");
                writer.WriteString(Convert.ToString(item.Manufucturer.Date.Month));
                writer.WriteEndElement();
                writer.WriteStartElement("year");
                writer.WriteString(Convert.ToString(item.Manufucturer.Date.Year));
                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteEndElement();
                #endregion

                #region characteristics
                writer.WriteStartElement("characteristics");

                writer.WriteStartElement("power");
                writer.WriteStartAttribute("some atribute", null);
                writer.WriteString("-");
                writer.WriteEndAttribute();
                writer.WriteString(item.Chracteristics.Power);
                writer.WriteEndElement();

                writer.WriteStartElement("model characteristics");
                writer.WriteString(item.Chracteristics.ModelCharacteristics);
                writer.WriteEndElement();

                writer.WriteStartElement("add characteristics");
                writer.WriteString(item.Chracteristics.AddCharacteristics);
                writer.WriteEndElement();

                writer.WriteEndElement();
                #endregion

                #region price
                writer.WriteStartElement("price");

                writer.WriteStartElement("price");
                writer.WriteStartAttribute("some atribute", null);
                writer.WriteString("-");
                writer.WriteEndAttribute();
                writer.WriteString(Convert.ToString(item.Price._Price));
                writer.WriteEndElement();

                writer.WriteStartElement("price for goods");
                writer.WriteString(Convert.ToString(item.Price.PriceForGoods));
                writer.WriteEndElement();

                writer.WriteEndElement();
                #endregion

                #region info of credit
                writer.WriteStartElement("info of credit");

                writer.WriteStartElement("amount month");
                writer.WriteStartAttribute("some atribute", null);
                writer.WriteString("-");
                writer.WriteEndAttribute();
                writer.WriteString(Convert.ToString(item.Credit.AmountMonth));
                writer.WriteEndElement();

                writer.WriteStartElement("sum to month");
                writer.WriteString(Convert.ToString(item.Credit.SumByMonth));
                writer.WriteEndElement();

                writer.WriteEndElement();
                #endregion

                writer.WriteEndElement();
                writer.Close();

                counter++;
            }
        }
    }
}
