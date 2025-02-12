using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GUI_server
{
    public class Item_SubList
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("pathUrl")]
        public string PathUrl { get; set; }
    }

    public class JsonManager_SubList
    {
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("Items")]
        public List<Item_SubList> Items { get; set; }
    }
}
