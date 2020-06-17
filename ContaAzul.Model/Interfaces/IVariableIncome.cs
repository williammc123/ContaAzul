namespace ContaAzul.Model.Interfaces
{
    interface IVariableIncome
    {
        int CurrentPrice { get; set; }
        int SalePrice { get; set; }
        int Amount { get; set; }
        string Assets { get; set; }
        int PurchasePrice { get; set; }
        int Dividend { get; set; }
    }
}
