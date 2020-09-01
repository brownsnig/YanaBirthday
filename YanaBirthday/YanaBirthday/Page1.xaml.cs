using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YanaBirthday
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {

            InitializeComponent();
        }

        async void onBirthdayNoteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        async void onChecklistClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        async void onImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}