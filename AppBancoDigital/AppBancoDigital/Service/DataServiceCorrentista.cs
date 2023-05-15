using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using AppBancoDigital.Model; 

namespace AppBancoDigital.Service
{
    class DataServiceCorrentista : DataService
    {
        public static async Task<Model.Correntista> Cadastrar(Model.Correntista c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_to_send, "/correntista/save");

            Correntista correntista = JsonConvert.DeserializeObject<Correntista>(json);

            return correntista;
        }

        public static async Task<Correntista> Entrar(Correntista c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            string json = await DataService.GetDataFromService(String.Format("/correntista/entrar?cpf={0}&senha={1}", c.Cpf, c.Senha));

            Correntista correntista = new Correntista();
            if (json != "false")
            {
                correntista = JsonConvert.DeserializeObject<Correntista>(json);
            }


            return correntista;
        }
    }
}
