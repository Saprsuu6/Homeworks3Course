using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    class Contract : IContract
    {
        private static uint contractNumber;
        private uint clientCode;
        private string dateOfIssue;
        private string termTo;
        private List<Sale> sales = new List<Sale>();

        private Sale ReturnSale(string furnitureName, string model)
        {
            Sale temp = null;

            foreach (Sale item in sales)
            {
                if (item.FurnitureName == furnitureName &&
                    item.Model == model)
                {
                    temp = item;
                    break;
                }
            }

            return temp;
        }

        public Contract(uint clientCode, string dateOfIssue, string termTo)
        {
            this.clientCode = clientCode;
            this.dateOfIssue = dateOfIssue;
            this.termTo = termTo;

            contractNumber++;
        }

        public uint ContractNumber => contractNumber;
        public uint ClientCode { get => clientCode; set => clientCode = value; }
        public string DateOfIssue { get => dateOfIssue; set => dateOfIssue = value; }
        public string TermTo { get => termTo; set => termTo = value; }
        public Sale this[string furnitureName, string model]
        {
            get
            {
                return ReturnSale(furnitureName, model);
            }
            set
            {
                Sale sale = ReturnSale(furnitureName, model);
                sale = value;
            }
        }
        public void AddSale(Sale sale) => sales.Add(sale);
    }
}
