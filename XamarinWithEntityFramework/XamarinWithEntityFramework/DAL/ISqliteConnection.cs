using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinWithEntityFramework.DAL
{
    public interface ISqliteConnection
    {
        string GetSqlitePath();
    }
}
