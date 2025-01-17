using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserName.Text);
            string password = txtPassword.Text;
            var users = db.Users.Find(id);
            if (users.UserId == id && users.Password == password)
            {
                FrmDashboardd frm = new FrmDashboardd();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı ID veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
