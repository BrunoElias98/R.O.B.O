using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Robo
    {
        public string Name { get; set; }

        public int CabecaInclinacao { get; set; }

        public int CabecaRotacao { get; set; }

        public int BracoEsquerdoCotovelo { get; set; }

        public int BracoEsquerdoPulso { get; set; }

        public int BracoDireitoCotovelo { get; set; }

        public int BracoDireitoPulso { get; set; }
    }
}