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
        string datanasc;
        string senha;


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
            get { return cpf; }

            set
            {
                if (!Validation.CpfIsValid(value)) 
                    throw new Exception("Informe o cpf!");                

                cpf = value;
            }
        }
        public DateTime DataNasc { get; set;}
        public string Senha { get; set;}

    }
}
