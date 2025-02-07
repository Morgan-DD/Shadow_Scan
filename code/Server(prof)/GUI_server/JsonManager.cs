using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_server
{
    public class JsonManager
    {
        public List<Resource> Ressources { get; set; }

    }

    public class Resource
    {
        public string type { get; set; }
        public string pathUrl { get; set; }
    }
}
