using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class GoodsBase
    {
        private Goods[] goods;

        public GoodsBase() => goods = new Goods[0];

        public void AddGoods(Goods goods)
        {
            Goods[] newBase = new Goods[this.goods.Length + 1];
            for (int i = 0; i < this.goods.Length; i++)
            {
                newBase[i] = this.goods[i];
            }
            newBase[this.goods.Length] = goods;

            this.goods = newBase;
        }

        public void DeleteGoods(string name)
        {
            if(goods.Length == 0)
                throw new ApplicationException("The base is empty.");

            for (int i = 0; i < goods.Length; i++)
            {
                if (goods[i].Name == name)
                {
                    Goods[] newArray = new Goods[goods.Length - 1];
                    for (int j = 0; j < goods.Length - 1; j++)
                    {
                        if (j < i)
                        {
                            newArray[j] = goods[j];
                            continue;
                        }
                        newArray[i] = goods[j + 1];
                    }

                    goods = newArray;
                    throw new ApplicationException("The goods was deleted.");
                }
            }
        }

        public Goods this[string name] 
        {
            get
            {
                if (goods.Length == 0)
                    throw new ApplicationException("Base is empty.");

                int temp = 0;

                for (int i = 0; i < goods.Length; i++)
                {
                    if (goods[i].Name == name)
                    {
                        temp = i;
                        break;
                    }
                    else if (i == goods.Length - 1)
                        throw new ApplicationException("Goods was not found.");
                }

                return goods[temp];
            }
        }

        public int Length { get { return goods.Length; } }
    }
}
