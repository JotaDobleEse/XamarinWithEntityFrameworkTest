using System;

using Xamarin.Forms;
using XamarinWithEntityFramework.DAL;

using XamarinWithEntityFramework.Droid.DAL;
using System.IO;

[assembly: Dependency(typeof(SqliteConnectionData))]
namespace XamarinWithEntityFramework.Droid.DAL
{
    public class SqliteConnectionData : ISqliteConnection
    {
        public string GetSqlitePath()
        {
            //return Path.Combine(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDcim).AbsolutePath, "xamarin.db");
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "xamarin.db");
        }
    }
}