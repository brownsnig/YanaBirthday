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
    public partial class Page6 : ContentPage
    {
        int c;
        Random col;
        public Page6()
        {
            InitializeComponent();
            c = 0;
            col = new Random();
        }

        async void onMainClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        public void onStressClicked(object sender, EventArgs e)
        {
            c++;
            StressButton.BackgroundColor = Color.FromRgb(col.Next(256), col.Next(256), col.Next(256));

            if (c % 50 == 0)
                snigs.IsVisible = true;
            else if (c > 100)
            {
                stressy.Text = "GIRL, YOU'VE HIT THIS OVER 100 TIMES. TAKE A BREAK!";
                snigs.IsVisible = false;
            }
            else if (c % 9 == 0)
            {
                stressy.Text = "QUEEN YOU GOT THIS!";
                snigs.IsVisible = false;
            }

            else if (c % 8 == 0)
            {
                stressy.Text = "YES GIRL TAKE THAT STRESS OUT!";
                snigs.IsVisible = false;
            }

            else if (c % 7 == 0)
            {
                stressy.Text = "PUMP IT UP!!";
                snigs.IsVisible = false;
            }

            else if (c % 6 == 0)
            {
                stressy.Text = "YOU ARE A BEAUTIFUL ANGEL!";
                snigs.IsVisible = false;
            }

            else if (c % 5 == 0)
            {
                stressy.Text = "ALL YOUR FRIENDS LOVE YOU SO MUCH <3!";
                snigs.IsVisible = false;
            }

            else if (c % 4 == 0)
            {
                stressy.Text = "STRONG SMART BOLD YOU'RE ALL THAT AND MORE!";
                snigs.IsVisible = false;
            }

            else if (c % 3 == 0)
            {
                stressy.Text = "FEEL THAT STRESS GOING AWAY?";
                snigs.IsVisible = false;
            }

            else if (c % 2 == 0)
            {
                stressy.Text = "SMILE, SMILE, SMILE!";
                snigs.IsVisible = false;
            }
            else
            {
                stressy.Text = "QUEEN VIBES ONLY!";
                snigs.IsVisible = false;
            }

        }
    }
}