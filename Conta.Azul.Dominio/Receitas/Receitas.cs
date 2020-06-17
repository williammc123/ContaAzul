using Validacao;

namespace Conta.Azul.Dominio.Receitas
{
    public class Receitas: ClasseBase
    {
        public decimal Salario { get; set; }
        public decimal Aluguel { get; set; }
        //public decimal Pensao { get; set; }
        //public decimal HorasExtras { get; set; }
        //public decimal DecimoTerceiroSalario { get; set; }
        //public decimal Ferias { get; set; }
        //public decimal ValeAlimentacao { get; set; }
        //public decimal ValeRefeicao { get; set; }
        //public decimal Dividendos { get; set; }
        //public decimal JurosSobreCapital { get; set; }
        //public decimal Venda { get; set; }
        //public decimal GoogleAdssence { get; set; }

        public void AlterarSalario(decimal salario)
        {
            Validation.AssertArgumentLessThanZero(salario, "Salario não pode ser menor que zero");
            this.Salario = salario;
        }

        public void AlterarAluguel(decimal aluguel)
        {
            Validation.AssertArgumentLessThanZero(aluguel, "Aluguel não pode ser menor que zero");
            this.Aluguel = aluguel;
        }
    }
}
