using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrasesMAPI.Models
{
    public class FM
    {
        public int ID { get; set; }
        public string frase { get; set; } = "";
        public string autor { get; set; } = "";
        public string sentimento { get; set; } = "";
    }
}