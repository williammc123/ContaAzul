using ContaAzul.Model.Interfaces;

namespace ContaAzul.Model
{
    class FIIS : IVariableIncome
    {
        public int CurrentPrice { get; set; }//preço atual
        public int SalePrice { get; set; }//preço de venda
        public int Amount { get; set; }//montante
        public string Assets { get; set; }//ativo
        public int PurchasePrice { get; set; }// preço de compra
        public int Dividend { get; set; }//dividendo
    }
}
