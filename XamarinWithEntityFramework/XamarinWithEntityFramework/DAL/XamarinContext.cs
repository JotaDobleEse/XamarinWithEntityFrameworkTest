using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinWithEntityFramework.Model;

namespace XamarinWithEntityFramework.DAL
{
    public class XamarinContext : DbContext
    {
        private string _databasePath;

        public string DatabasePath { get { return _databasePath; } }

        public XamarinContext()
        {
            _databasePath = DependencyService.Get<ISqliteConnection>().GetSqlitePath();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }

        public DbSet<Item> Items { get; set; }
    }
}
