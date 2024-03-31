using CommonLib.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMySQLConnection.Repositories
{
    public abstract class RepositoryBase
    {
        public MySqlDb GetJinyuDb()
        {
            return new MySqlDb (Properties.Settings.Default.JINYU_DB_CONN_STRING);
        }
    }
}
