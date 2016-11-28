using MOB.XF.Login.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.Login.View
{
    public partial class HomeView : ContentPage
    {
        UsuarioViewModel usuarioVM;

        public HomeView()
        {
            usuarioVM = new UsuarioViewModel();
            BindingContext = usuarioVM;
            //this.rootLayout.BindingContext = usuarioVM;

            InitializeComponent();
        }
    }
}
