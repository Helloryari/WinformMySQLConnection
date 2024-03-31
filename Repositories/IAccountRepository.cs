using System.Collections.Generic;
using WinFormMySQLConnection.Models;

namespace WinFormMySQLConnection.Repositories
{
    public interface IAccountRepository
    {
        void Delete(int id);
        List<Account> GetAll();
        long Insert(Account account);
        void Update(Account account);
    }
}