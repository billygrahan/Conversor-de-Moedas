using Conversor_de_Moedas.UI;
using Conversor_de_Moedas.Utils;
using Conversor_de_Moedas.Validations;
using Newtonsoft.Json;


namespace Conversor_de_Moedas.Models;

public class Sistema
{
    private string Key;

    public Sistema()
    {
        Key = File.ReadAllText("../Conversor-de-Moedas/Utils/YOUR-API-KEY.txt");
    }

    private API_Response ResponseConsulta(string MoedaOrigem, string MoedaDestino, double? valor)
    {
        using (var httpClient = new HttpClient())
        {
            try
            {
                string strValor = valor.ToString().Replace(',', '.');
                string URLString = $"https://v6.exchangerate-api.com/v6/{Key}/pair/{MoedaOrigem}/{MoedaDestino}/{strValor}";
                HttpResponseMessage response = httpClient.GetAsync(URLString).Result;
                string jsonResponse = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<API_Response>(jsonResponse);
            }
            catch (Exception)
            {
                return new API_Response
                {
                    result = "error",
                    error_type = "Sem acesso ao sistema"
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
                Interface.ExibeErro("Caracteres Moedas");
                continue;
            }
            if (!ValidaEntradas.ValidaMoedasDiferentes(MoedaOrigem, MoedaDestino))
            {
                Interface.ExibeErro("Moedas Iguais");
                continue;
            }

            Double? Valor = Interface.ObterEntradaValor("Valor: ");

            if (ValidaEntradas.ValidaValorNotNull(Valor))
            {
                Interface.ExibeErro("Valor Nulo");
                continue;
            }
            else if(!ValidaEntradas.ValidaValorPositivo(Valor))
            {
                Interface.ExibeErro("Valor Menor que Zero");
                continue;
            }

            

            API_Response resposta = ResponseConsulta(MoedaOrigem, MoedaDestino, Valor);

            if (ValidaConsultas.ValidaConsultaSuccess(resposta))
            {
                Interface.ExibeConvercao(resposta);
                continue;
            }
            else if (!ValidaConsultas.ValidaConsultaNotNull(resposta))
            {
                Interface.ExibeErro("Sem acesso ao sistema");
                continue;
            }
            else if(ValidaConsultas.ValidaErrorConsulta(resposta))
            {
                Interface.ExibeErro(resposta.error_type);
                continue;
            }
        }
    }
}
