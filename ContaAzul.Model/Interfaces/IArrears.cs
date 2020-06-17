using System;

namespace ContaAzul.Model
{
    //Dividas
    public  interface IArrears
    {
         int Amount { get; set; }
         DateTime InitialDate { get; set; }
         DateTime FinalDate { get; set; }
    }
}
