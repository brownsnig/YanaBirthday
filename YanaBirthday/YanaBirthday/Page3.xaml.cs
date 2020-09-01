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
    public partial class Page3 : ContentPage
    {
        int check;
        public Page3()
        {
            check = 0; 
            InitializeComponent();
        }

        async void onMainClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        void onSleepChanged(object sender, CheckedChangedEventArgs e)
        {
            if (SleepCheck.IsChecked == false)
                check--;
            else
                check++;

            if (check == 8)
                FinalMessage.IsVisible = true;
            else
                FinalMessage.IsVisible = false; 
        }

        void onSmileChanged(object sender, CheckedChangedEventArgs e)
        {
            if (SmileCheck.IsChecked == false)
                check--;
            else
                check++;

            if (check == 8)
                FinalMessage.IsVisible = true;
            else
                FinalMessage.IsVisible = false;
        }

        void onJunkChanged(object sender, CheckedChangedEventArgs e)
        {
            if (JunkCheck.IsChecked == false)
                check--;
            else
                check++;

            if (check == 8)
                FinalMessage.IsVisible = true;
            else
                FinalMessage.IsVisible = false;
        }

        void onNetflixChanged(object sender, CheckedChangedEventArgs e)
        {
            if (NetflixCheck.IsChecked == false)
                check--;
            else
                check++;

            if (check == 8)
                FinalMessage.IsVisible = true;
            else
                FinalMessage.IsVisible = false;
        }

        void onClassChanged(object sender, CheckedChangedEventArgs e)
        {
            if (ClassCheck.IsChecked == false)
                check--;
            else
                check++;

            if (check == 8)
                FinalMessage.IsVisible = true;
            else
                FinalMessage.IsVisible = false;
        }

        void onDressChanged(object sender, CheckedChangedEventArgs e)
        {
            if (DressCheck.IsChecked == false)
                check--;
            else
                check++;

            if (check == 8)
                FinalMessage.IsVisible = true;
            else
                FinalMessage.IsVisible = false;
        }

        void onTextChanged(object sender, CheckedChangedEventArgs e)
        {
            if (TextCheck.IsChecked == false)
                check--;
            else
                check++;

            if (check == 8)
                FinalMessage.IsVisible = true;
            else
                FinalMessage.IsVisible = false;
        }

        void onHappyChanged(object sender, CheckedChangedEventArgs e)
        {
            if (HappyCheck.IsChecked == false)
                check--;
            else
                check++;

            if (check == 8)
                FinalMessage.IsVisible = true;
            else
                FinalMessage.IsVisible = false;
        }



    }
}