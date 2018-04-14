using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHotel2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void SignIn_Click(object sender, EventArgs e)
        {
            if(Username.Text == "ABC" && Password.Text == "123")
            {
                // Navigation.PushAsync(new MainView());
                //DisplayAlert("Thông báo","True","Đóng"); 
                // MainView mv = new MainView();
                //App.Current.MainPage = new NavigationPage(new SmartHotel2.Views.MainView());
                Application.Current.MainPage = new SmartHotel2.Views.MainView();
            }
        }
    }
}