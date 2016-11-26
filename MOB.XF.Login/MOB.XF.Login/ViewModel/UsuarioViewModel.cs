using MOB.XF.Login.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MOB.XF.Login.ViewModel
{
    public class UsuarioViewModel
    {
        public async Task<ObservableCollection<Usuario>> LoadUsuarios()
        {
            //string sURL = "http://apiauthmobdiogo.azurewebsites.net/api/Usuarios";

            //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(sURL));
            //request.ContentType = "application/json";
            //request.Method = "GET";

            //using (WebResponse response = await request.GetResponseAsync())
            //{
            //    using (Stream stream = response.GetResponseStream())
            //    {
            //        JsonValue jsonDoc = await Task.Run(() => JsonObject.Load(stream));
            //        return jsonDoc;
            //    }
            //}
        }
    }
}
