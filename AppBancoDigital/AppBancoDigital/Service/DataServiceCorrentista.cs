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

            string json = await DataService.PostDataToService(json_to_send, "/correntista/entrar");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }
    }
}
