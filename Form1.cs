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
        private AccountRepository _accountRepository = new AccountRepository();
        private List<Account> _accounts = default!;


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
                Id = 3,
                Email = "abceEmail@naver.com",
                Pwd = "10203040",
                NickName = "얼레리",
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

            Accounts = _accountRepository.GetAll();
            //foreach (var account in accounts)
            //{
            //    MessageBox.Show($"email : {account.Email} / pwd : {account.Pwd} / nickname : {account.NickName} / cell_phone : {account.CellPhone}");
            //}

            dataGridView1.DataSource = Accounts;

        }

        public List<Account> Accounts
        {
            get => _accounts; set
            {
                if (_accounts != value)
                {
                    _accounts = value;
                    //OnPropertyChanged();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Controls.Add(dataGridView1);
        }
    }
}
