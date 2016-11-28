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
        public List<Usuario> CopiaUsuario = new List<Usuario>();

        public ObservableCollection<Usuario> Usuarios { get; set; } = new ObservableCollection<Model.Usuario>();

        public UsuarioViewModel()
        {
            LoadUsuarios();
        }

        private async void LoadUsuarios()
        {
            CopiaUsuario = await UsuarioRepository.GetUsuariosSqlAzure();
            ExcutarFiltro();
        }

        private void ExcutarFiltro()
        {
            for (int index = 0; index < CopiaUsuario.Count; index++)
            {
                var item = CopiaUsuario[index];
                if (index + 1 > Usuarios.Count || !Usuarios[index].Equals(item))
                    Usuarios.Insert(index, item);
            }
        }
    }
}
