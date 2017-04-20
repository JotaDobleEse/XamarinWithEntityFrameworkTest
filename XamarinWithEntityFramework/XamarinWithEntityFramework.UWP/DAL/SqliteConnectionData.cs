using System;

using Xamarin.Forms;
using XamarinWithEntityFramework.DAL;

using XamarinWithEntityFramework.UWP.DAL;
using System.IO;

[assembly: Dependency(typeof(SqliteConnectionData))]
namespace XamarinWithEntityFramework.UWP.DAL
{
    public class SqliteConnectionData : ISqliteConnection
    {
        public string GetSqlitePath()
        {
            return Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "xamarin.db");
        }
    }
}