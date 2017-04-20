using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinWithEntityFramework.DAL;

namespace XamarinWithEntityFramework
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            using (var db = new XamarinContext())
            {
                // Ensure database is created
                db.Database.EnsureCreated();
            }
            MainPage = new XamarinWithEntityFramework.MainPage();
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
