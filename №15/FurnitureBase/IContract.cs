using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureBase
{
    interface IContract
    {
        uint ContractNumber { get; }
        uint ClientCode { get; set; }
        string DateOfIssue { get; set; }
        string TermTo { get; set; }
        void AddSale(Sale sale);
    }
}
