
namespace Conversor_de_Moedas.Utils;

public class Erros
{
    private static Dictionary<string, string> erros = new Dictionary<string, string>()
    {
       {"unsupported-code", "Código de moeda fornecida não suportardo pelo sistema."},
       {"invalid-key", "Sua chave de API não é válida."},
       {"inactive-account", "O endereço de e-mail não foi confirmado para utilização da chave Key."},
       {"quota-reached", "Sua conta atingiu o número de solicitações permitidas pelo seu plano. Atualize sua chave de acesso!"},
       {"Moedas Iguais", "Moedas Iguais! A converção deve ser entre moedas diferentes."},
       {"Caracteres Moedas", "As modedas devem ter apenas 3 caracteres."},
       {"Valor Menor que Zero", "O valor Não pode ser Menor do que zero."},
       {"Valor Nulo", "Valor passado de forma errada! Valor deve ser numeros como:'10' ou '10.50'"},
       {"Sem acesso ao sistema", "Sem acesso ao sistema. O sistema está fora do ar ou o cliente está sem acesso a internet"},
    };

    public static string MensagemdeErro(string erro)
    {
        if (erros.TryGetValue(erro, out string mensagem))
        {
            return mensagem;
        }
        else
        {
            return erro;
        }
    }
}
