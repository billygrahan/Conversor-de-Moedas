
using Conversor_de_Moedas.UI;

namespace Conversor_de_Moedas.Validations;

public class ValidaEntradas
{
    
    public static bool ValidaMoedasDiferentes(string MoedaOrigem, string MoedaDestino)
    {
        if (MoedaOrigem == MoedaDestino)
        {
            return false;
        }
        else return true;
    }

    public static bool ValidaTamanhoMoedas(string MoedaOrigem, string MoedaDestino)
    {
        if (MoedaOrigem.Length != 3 || MoedaDestino.Length != 3)
        {
            return false;
        }
        else return true;
    }

    public static bool ValidaValorPositivo(Double? Valor)
    {
        if (Valor <  0)
        {
            return false;
        }
        else return true ;
    }
    public static bool ValidaValorNotNull(Double? Valor)
    {
        if (Valor != null)
        {
            return false;
        }
        else return true;
    }
}
