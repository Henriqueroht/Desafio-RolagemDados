

using System;

namespace DadosRolagem
{
    class Dados
    {
        public int QuantidadeDeLados { get; set; }
        public int QuantidadeDeDados { get; set; }
        public int TotalRolado { get; set; }
        public Dado[] Dado { get; set; }
    }
    class Dado
    {
        public int QuantidadeDeLados { get; set; }
        public int NumeroRolado { get; set; }

        public void RolarDado()
        {
            Random rd = new Random();
            NumeroRolado = rd.Next(1, QuantidadeDeLados + 1);
            //Teste
        }
    }
}
