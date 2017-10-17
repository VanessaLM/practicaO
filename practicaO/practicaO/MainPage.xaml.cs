using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace practicaO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SQLiteAsyncConnection database;
            string db;

            db = DependencyService.Get<ISQLite>().GetLocalFilePath("TeshDB.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<TeshDatos>().Wait();

            var elemento = new TeshDatos
            {
                Id = "12090256",
                Dato1 = "Vanessa",
                Dato2 = "Lopez Medina",
                Dato3 = "zenzontles",
                Dato4 = "123456789",
                Dato5 = "ISC",
                Dato6 = "Noveno",
                Dato7 = "vane.princess15@hotmail.com",
                Dato8 = "VanessaLM"
            };
            database.InsertAsync(elemento);
            
        }
    }
}
