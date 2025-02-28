using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShadowScan_GUI
{
    public class Ressource_MainList
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("pathUrl")]
        public string PathUrl { get; set; }
    }

    public class JsonManager_MainList
    {
        [JsonPropertyName("Ressources")]
        public List<Ressource_MainList> Ressources { get; set; }
    }
}
