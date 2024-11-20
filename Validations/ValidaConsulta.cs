using Conversor_de_Moedas.Models;

namespace Conversor_de_Moedas.Validations;

public class ValidaConsultas
{
    public static bool ValidaConsultaSuccess(API_Response resposta)
    {
        if (resposta.result == "error")
        {
            return false;
        }
        else return true;
    }
    public static bool ValidaConsultaNotNull(API_Response resposta)
    {
        if (resposta.result == null)
        {
            return false;
        }
        else return true;
    }
    public static bool ValidaErrorConsulta(API_Response resposta)
    {
        if (resposta.result == "error")
        {
            return true;
        }
        else return false;
    }
}
