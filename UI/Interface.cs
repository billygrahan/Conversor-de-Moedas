
using Conversor_de_Moedas.Models;
using Conversor_de_Moedas.Utils;
using System.Globalization;

namespace Conversor_de_Moedas.UI;

public class Interface
{
    public static string ObterEntradaMoeda(string mensagem)
    {
        Console.Write(mensagem);
        return Console.ReadLine().ToUpper();
    }


    public static double? ObterEntradaValor(string mensagem)
    {
        Console.Write(mensagem);
        string entrada = Console.ReadLine().Replace(",", ".");
        try
        {
            return double.TryParse(entrada, NumberStyles.Float | NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out double valor) ? valor : (double?)null;
        }
        catch
        {
            return null;
        }
    }



    public static void ExibeErro(string erro)
    {
        Console.WriteLine($"\nErro: {Erros.MensagemdeErro(erro)}\n");
    }

    public static void ExibeConvercao(API_Response resposta)
    {
        
        Console.WriteLine($"\n{resposta.base_code} {(resposta.conversion_result / resposta.conversion_rate):F2} => {resposta.target_code} {resposta.conversion_result:F2}");
        Console.WriteLine($"Taxa: {resposta.conversion_rate:F6}\n");
        
    }
}
