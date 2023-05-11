using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Conta
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public Double Saldo { get; set; }
        public Double Limite { get; set; }
        public int Id_Correntista { get; set; }

    }
}
