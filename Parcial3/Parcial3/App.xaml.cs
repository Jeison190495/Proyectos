using SQLite;
using Parcial3.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Parcial3.Data;


namespace Parcial3
{
    public partial class App : Application
    {
        public static DBase Context { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDBase();

            MainPage = new NavigationPage(new PagPrincipal());
        }
        private void InitializeDBase()
        {
            var folderapp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dbpath = System.IO.Path.Combine(folderapp, "Comentarios.db3");
            Context = new DBase(dbpath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
