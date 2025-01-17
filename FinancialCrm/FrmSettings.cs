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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
        }

        private void btnCategoriess_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }
        private void btnBillings_Click_1(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }
        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            FrmTransactions frm = new FrmTransactions();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboardd frm = new FrmDashboardd();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            string username = txtUserName.Text;
            string password = txtPassword.Text;
              
            var users = db.Users.Find(id);
                if (users.UserId == id && users.Username == username)
                {
                    users.Password = password;
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı bilgileri başarılı bir şekilde güncellendi!", "Kullanıcı Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya ID hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
