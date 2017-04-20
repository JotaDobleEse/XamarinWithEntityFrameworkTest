using System;

using Xamarin.Forms;
using XamarinWithEntityFramework.DAL;

using XamarinWithEntityFramework.iOS.DAL;
using System.IO;

[assembly: Dependency(typeof(SqliteConnectionData))]
namespace XamarinWithEntityFramework.iOS.DAL
{
    public class SqliteConnectionData : ISqliteConnection
    {
        public string GetSqlitePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "xamarin.db");
        }
    }
}