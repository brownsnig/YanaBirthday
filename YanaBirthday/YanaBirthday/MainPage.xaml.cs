using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace YanaBirthday
{
    public partial class MainPage : ContentPage
    {
        MainPage = new NavigationPage(new MainPage());
        
        
        async void onBirthdayNoteClicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Page1());
        }
        
       
    }
}
