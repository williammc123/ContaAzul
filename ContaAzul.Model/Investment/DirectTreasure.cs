using System;
using ContaAzul.Model.Interfaces;

namespace ContaAzul.Model.Investment
{
    class DirectTreasure : IFixedIncome
    {
        public int ApplicationValue { get; set; }
        public double Rate { get; set; }
        public DateTime DateInitial { get; set; }
        public DateTime DateFinal { get; set; }
    }
}
