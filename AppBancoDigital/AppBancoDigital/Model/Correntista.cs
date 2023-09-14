using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using AppBancoDigital.Helpers;

namespace AppBancoDigital.Model
{
    public class Correntista
    {
        int id;
        string nome;
        string cpf;


        public int? Id { get; set; }
        public string Nome
        {
            get { return nome; }

            set
            {
                if (value == null)
                    throw new Exception("Informe o nome!");
                
                nome = value;
            }
        }
              
        public string Cpf 
        {
            get { return cpf.Replace(".", "").Replace("-", ""); }

            set
            {
                if (!Validation.CpfIsValid(value)) 
                    throw new Exception("Informe um cpf válido!");                

                cpf = value;
            }
        }
        public DateTime DataNasc { get; set;}
        public string Senha { get; set;}
        public List<Conta> rows_contas { get; set; }

    }
}
