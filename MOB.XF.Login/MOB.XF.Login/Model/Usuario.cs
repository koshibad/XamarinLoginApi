using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MOB.XF.Login.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nickname { get; set; }
        //[JsonProperty(PropertyName = "Senha")]
        public string Senha { get; set; }
        public bool Ativo { get; set; }
    }

    public static class UsuarioRepository
    {
        public static List<Usuario> usuarioSqlAzure;

        public static async Task<List<Usuario>> GetUsuariosSqlAzure()
        {
            if (usuarioSqlAzure != null) return usuarioSqlAzure;

            var httpRequest = new HttpClient();
            var stream = await httpRequest.GetStreamAsync(
                "http://apiauthmobdiogo.azurewebsites.net/api/Usuarios");

            var usuarioSerializer = new DataContractJsonSerializer(typeof(List<Usuario>));
            usuarioSqlAzure = (List<Usuario>)usuarioSerializer.ReadObject(stream);

            return usuarioSqlAzure;
        }
    }
}
