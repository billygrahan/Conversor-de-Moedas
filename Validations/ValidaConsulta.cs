using Conversor_de_Moedas.Models;

namespace Conversor_de_Moedas.Validations;

public class ValidaConsultas
{
    public static bool ValidaConsulta(API_Response resposta)
    {
        if (resposta.result == "error")
        {
            return false;
        }
        else return true;
    }
}
