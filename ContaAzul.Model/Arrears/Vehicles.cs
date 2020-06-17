using System;

namespace ContaAzul.Model.Arrears
{
    //Veículo
    public class Vehicles : IArrears
    {
        public int Amount { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
    }
}
