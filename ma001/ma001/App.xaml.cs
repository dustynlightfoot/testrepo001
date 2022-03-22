using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ma001
{
    public partial class App : Application
    {
        public App()
        {
	    //CP4
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
