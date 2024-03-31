using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMySQLConnection.Models;
using WinFormMySQLConnection.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormMySQLConnection
{
    public partial class Form1 : Form
    {

        private MySqlConnection _conn = default!;
        private AccountRepository _accountRepository = default!;


        private void btn_conn_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Account account = new Account
            {
                Email = "test123@naver.com",
                Pwd = "abcdefg",
                NickName = "또까불이",
                CellPhone = "01012342345",
            };

            _accountRepository.Insert(account);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Account account = new Account
            {
                Id = 1,
                Email = "abceEmail@naver.com",
                Pwd = "10203040",
                NickName = "어르신",
                CellPhone = "01033334444",
            };

            _accountRepository.Update(account);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            _accountRepository.Delete(4);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {

            var accounts = _accountRepository.GetAll();
            foreach (var account in accounts)
            {
                MessageBox.Show($"email : {account.Email} / pwd : {account.Pwd} / nickname : {account.NickName} / cell_phone : {account.CellPhone}");
            }

        }
        
        public Form1()
        {
            InitializeComponent();

            _accountRepository = new AccountRepository();
        }
    }
}
