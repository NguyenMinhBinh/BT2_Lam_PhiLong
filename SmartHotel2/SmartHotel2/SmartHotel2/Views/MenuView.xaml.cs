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
	public partial class MenuView : ContentPage
	{
		public MenuView ()
		{
			InitializeComponent ();
		}
        private void onBookTap(object sender, EventArgs e)
        {
           if(Application.Current.MainPage is MainView mainView)
            {
               if( mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new BookingView());
                    mainView.IsPresented = false;
                }
            }
        }

        private void onMyRoomTap(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new MyRoom());
                    mainView.IsPresented = false;
                }
            }
        }
        private void onSuggesstionTap(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new SuggesstionView());
                    mainView.IsPresented = false;
                }
            }
        }

        private void onConciergeTap(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new ConciergeView());
                    mainView.IsPresented = false;
                }
            }
        }


        private void onLoginTap(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SmartHotel2.Views.Login();
        }
    }
}