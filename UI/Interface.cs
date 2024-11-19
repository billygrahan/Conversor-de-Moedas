
using Conversor_de_Moedas.Models;
using Conversor_de_Moedas.Utils;

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

        try
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        catch
        {
            return null;
        }
    }

    public static void ExibeErro(string erro, Erros erros)
    {
        Console.WriteLine($"\nErro: {erros.MensagemdeErro(erro)}\n");
    }

    public static void ExibeConvercao(API_Response resposta)
    {
        
        Console.WriteLine($"\n{resposta.base_code} {resposta.conversion_result / resposta.conversion_rate} => {resposta.target_code} {resposta.conversion_result}");
        Console.WriteLine($"Taxa: {resposta.conversion_rate}\n");
        
    }
}
