using Conversor_de_Moedas.UI;
using Conversor_de_Moedas.Utils;
using Conversor_de_Moedas.Validations;
using Newtonsoft.Json;


namespace Conversor_de_Moedas.Models;

public class Sistema
{
    private string Key;
    private Erros erros = new Erros();

    public Sistema()
    {
        Key = "f7061918278fce76aaafa463";
    }

    private API_Response ResponseConsulta(string MoedaOrigem, string MoedaDestino, double? valor)
    {
        string URLString = $"https://v6.exchangerate-api.com/v6/{Key}/pair/{MoedaOrigem}/{MoedaDestino}/{valor}";

        using (var httpClient = new HttpClient())
        {
            try
            {
                // Enviar solicitação e aguardar a resposta
                HttpResponseMessage response = httpClient.GetAsync(URLString).Result;
                string jsonResponse = response.Content.ReadAsStringAsync().Result;

                // Imprimir o JSON de resposta para verificar o conteúdo
                Console.WriteLine($"JSON de resposta: {jsonResponse}");

                // Se a resposta for bem-sucedida ou contiver um JSON de erro
                return JsonConvert.DeserializeObject<API_Response>(jsonResponse);
            }
            catch (Exception)
            {
                return new API_Response
                {
                    result = "error",
                    error_type = "Sistema fora do ar"
                };
            }
        }
    }



    public void run()
    {
        while (true)
        {
            string MoedaOrigem = Interface.ObterEntradaMoeda("Moeda Origem: ");

            if (MoedaOrigem == "")
            {
                Environment.Exit(0);
            }

            string MoedaDestino = Interface.ObterEntradaMoeda("Moeda Destino: ");

            if (!ValidaEntradas.ValidaTamanhoMoedas(MoedaOrigem, MoedaDestino))
            {
                Interface.ExibeErro("Caracteres Moedas", erros);
                continue;
            }
            if (!ValidaEntradas.ValidaMoedasDiferentes(MoedaOrigem, MoedaDestino))
            {
                Interface.ExibeErro("Moedas Iguais", erros);
                continue;
            }

            Double? Valor = Interface.ObterEntradaValor("Valor: ");

            if (Valor == null)
            {
                Interface.ExibeErro("Valor Nulo", erros);
                continue;
            }
            else if(Valor < 0)
            {
                Interface.ExibeErro("Valor Menor que Zero", erros);
                continue;
            }

            //Console.WriteLine($"{MoedaOrigem},{MoedaDestino},{Valor}");

            API_Response resposta = ResponseConsulta(MoedaOrigem, MoedaDestino, Valor);

            if (ValidaConsultas.ValidaConsulta(resposta))
            {
                Interface.ExibeConvercao(resposta);
            }
            else if (resposta.result == null)
            {
                Interface.ExibeErro("Sistema fora do ar", erros);
                continue;
            }
            else
            {
                
                Interface.ExibeErro(resposta.error_type, erros);
            }
        }
    }
}
