using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Transacao
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public DateTime Data { get; set;}
        public int Id_Conta_Enviou{ get; set;}
        public int Id_Conta_Recebeu { get; set;}
    }
}
