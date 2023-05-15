﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppBancoDigital.Model
{
    public class Correntista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set;}
        public DatePicker DataNasc { get; set;}
        public string Senha { get; set;}

    }
}
