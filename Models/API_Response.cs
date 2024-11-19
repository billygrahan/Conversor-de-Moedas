using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Moedas.Models;

public class API_Response
{
    public string? result { get; set; }
    public string? documentation { get; set; }
    public string? terms_of_use { get; set; }
    public string? time_last_update_unix { get; set; }
    public string? time_last_update_utc { get; set; }
    public string? time_next_update_unix { get; set; }
    public string? time_next_update_utc { get; set; }
    public string? base_code { get; set; }
    public string? target_code { get; set; }
    public double? conversion_rate { get; set; }
    public double? conversion_result { get; set; }

    // em caso de erro.
    [JsonProperty("error-type")]
    public string? error_type { get; set; }
}