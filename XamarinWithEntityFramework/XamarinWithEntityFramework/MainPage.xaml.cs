using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinWithEntityFramework.DAL;
using XamarinWithEntityFramework.Model;

namespace XamarinWithEntityFramework
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            using (var db = new XamarinContext())
            {
                Directorio.Text = $"DbPath: {db.DatabasePath}";
                Contador.Text = $"Items: {db.Items.Count()}";
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            using (var db = new XamarinContext())
            {
                db.Items.Add(new Item() { No = "1" });
                db.SaveChanges();
                Contador.Text = $"Items: {db.Items.Count()}";
            }
        }
    }
}
