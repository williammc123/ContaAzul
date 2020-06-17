using System;

namespace ContaAzul.Model.Interfaces
{
    interface IFixedIncome
    {
        int ApplicationValue { get; set; }
        double Rate { get; set; }
        DateTime DateInitial { get; set; }
        DateTime DateFinal { get; set; }
    }
}
