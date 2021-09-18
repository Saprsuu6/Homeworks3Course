using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Logic
    {
        private GoodsBase @base;
        private GoodsBase sold;
        private string[] exportDates;
        private string[] importDate;

        public Logic()
        {
            @base = new GoodsBase();
            sold = new GoodsBase();
            exportDates = new string[0];
            importDate = new string[0];
        }

        public void Add(Goods goods)
        {
            @base.AddGoods(goods);
            string[] newImpotDate = new string[importDate.Length + 1];
            for (int i = 0; i < importDate.Length; i++)
            {
                newImpotDate[i] = importDate[i];
            }
            newImpotDate[importDate.Length] = DateTime.Now.ToString();

            importDate = newImpotDate;
        }

        public void Sell(string name)
        {
            try
            {
                Goods goods = @base[name];
                sold.AddGoods(goods);
                string[] newExportDate = new string[exportDates.Length + 1];
                for (int i = 0; i < exportDates.Length; i++)
                {
                    newExportDate[i] = exportDates[i];
                }
                newExportDate[exportDates.Length] = DateTime.Now.ToString();

                exportDates = newExportDate;

                @base.DeleteGoods(name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
