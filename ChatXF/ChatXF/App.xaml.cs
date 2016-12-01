using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ChatXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ChatXF.MainPage();
            //MainPage = new ChatXF.View.MensajesPage();
            MainPage = new NavigationPage(new ChatXF.View.MensajesPage());
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
