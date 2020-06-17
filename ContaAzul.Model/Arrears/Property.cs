using System;

namespace ContaAzul.Model
{
    //imoveis
    public class Property : IArrears
    {
        public int Amount { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
    }
}
