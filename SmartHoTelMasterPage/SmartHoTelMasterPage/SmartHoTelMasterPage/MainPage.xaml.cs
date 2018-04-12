using SmartHoTelMasterPage.MenuItems;
using SmartHoTelMasterPage.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHoTelMasterPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public MainPage ()
		{
			InitializeComponent ();
            menuList = new List<MasterPageItem>();
           
         
            var page1 = new MasterPageItem() { Title = "FastDelivery", Icon = "ic_local_shipping_black_24dp.png", TargetType = typeof(View1) };
            var page2 = new MasterPageItem() { Title = "Menus", Icon = "ic_restaurant_black_24dp.png", TargetType = typeof(View2) };
            var page3 = new MasterPageItem() { Title = "Free Pizza", Icon = "ic_local_pizza_black_24dp.png", TargetType = typeof(View3) };
            var page4 = new MasterPageItem() { Title = "Dining", Icon = "ic_local_dining_black_24dp.png", TargetType = typeof(View4) };
            var page5 = new MasterPageItem() { Title = "Parking", Icon = "ic_local_parking_black_24dp.png", TargetType = typeof(View1) };
            var page6 = new MasterPageItem() { Title = "LocateUs", Icon = "ic_location_on_black_24dp.png", TargetType = typeof(View2) };
         
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);


           
            navigationDrawerList.ItemsSource = menuList;
         
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ViewMain)));
            this.BindingContext = new
            {
                Header = "",
                Image = "http://www3.hilton.com/resources/media/hi/GSPSCHF/en_US/img/shared/full_page_image_gallery/main/HH_food_22_675x359_FitToBoxSmallDimension_Center.jpg",
              
                Footer = " Welcome To Hotel Plaza"
            };
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail.Title = item.Title;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}