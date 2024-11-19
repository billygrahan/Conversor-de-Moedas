
namespace Conversor_de_Moedas.Utils;

public class Erros
{
    private Dictionary<string, string> erros = new Dictionary<string, string>();

    public Erros()
    {
        erros.Add("unsupported-code", "não suportarmos o código de moeda fornecido.");
        erros.Add("invalid-key", "quando sua chave de API não é válida.");
        erros.Add("inactive-account", "seu endereço de e-mail não foi confirmado.");
        erros.Add("quota-reached", "sua conta atingiu o número de solicitações permitidas pelo seu plano.");
        erros.Add("Moedas Iguais", "Moedas Iguais! A converção deve ser entre moedas diferentes.");
        erros.Add("Caracteres Moedas", "As modedas devem ter apenas 3 caracteres.");
        erros.Add("Valor Menor que Zero", "O valor Não pode ser Menor do que zero.");
        erros.Add("Valor Nulo", "Valor passado de forma errada! Valor deve ser numeros como:'10' ou '10.50'");
        erros.Add("Sistema fora do ar", "O sistema está fora do ar");
    }

    public string MensagemdeErro(string erro)
    {
        // Verifica se a chave está nula ou vazia antes de procurar no dicionário
        if (string.IsNullOrEmpty(erro))
        {
            return "Erro desconhecido. A chave de erro não foi fornecida.";
        }

        // Verifica se a chave existe antes de tentar acessar
        if (erros.TryGetValue(erro, out string mensagem))
        {
            return mensagem;
        }
        else
        {
            // Se a chave não existir, retorna uma mensagem de erro genérica
            return erro;
        }
    }
}
