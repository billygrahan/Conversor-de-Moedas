// API Key: f7061918278fce76aaafa463
using System;
using Newtonsoft.Json;
using Conversor_de_Moedas;

try
{
    String URLString = "https://v6.exchangerate-api.com/v6/f7061918278fce76aaafa463/pair/CAD/BRL/2.0000";
    using (var webClient = new System.Net.WebClient())
    {
        var json = webClient.DownloadString(URLString);
        API_Obj Test = JsonConvert.DeserializeObject<API_Obj>(json);
        Console.WriteLine(Test.conversion_result);
    }
}
catch (Exception)
{
    Console.WriteLine("erro!");
}