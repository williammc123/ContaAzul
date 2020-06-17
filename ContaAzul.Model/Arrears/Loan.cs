using System;

namespace ContaAzul.Model
{
    //Emprestimos
   public class Loan : IArrears
    {
        public int Amount { get ; set ; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
    }
}
