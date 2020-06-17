using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Azul.Dominio.Contrato
{
    public interface ITipoDespesa <T> where T : class, new()
    {
        T GetT(T classe);
    }
}
