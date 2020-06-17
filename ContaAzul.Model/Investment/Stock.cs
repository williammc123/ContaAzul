using ContaAzul.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaAzul.Model
{
    class Stock : IVariableIncome
    {
        public int CurrentPrice { get ; set ; }
        public int SalePrice { get; set; }
        public int Amount { get; set; }
        public string Assets { get; set; }
        public int PurchasePrice { get; set; }
        public int Dividend { get; set; }
    }
}
