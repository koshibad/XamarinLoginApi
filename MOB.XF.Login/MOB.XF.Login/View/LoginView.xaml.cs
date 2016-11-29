using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.Login.View
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public async void Login_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new HomeView());
        }

        public void FormSignOn_Clicked(object sender, EventArgs args)
        {

        }

        public void PasswordRecovery_Clicked(object sender, EventArgs args)
        {

        }
    }
}
