using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Correntista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set;}
        public DateTime DataNasc { get; set;}
        public string Senha { get; set;}

    }
}
