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
    public partial class FrmTransactions : Form
    {
        public FrmTransactions()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnCategories_Click_1(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillings_Click(object sender, EventArgs e)
        {

            FrmBilling frm = new FrmBilling();
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

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {

            FrmDashboardd frm = new FrmDashboardd();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankaId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = txtTDescription.Text;
            DateTime date = DateTime.Parse(txtTDate.Text);
            decimal amount = decimal.Parse(txtTAmount.Text);
            int BankName = int.Parse(txtTBank.ToString());
            string type =txtTType.Text;
           

            BankProcesses BankProcess = new BankProcesses();
            BankProcess.Description = description;
            BankProcess.ProcessDate = date;
            BankProcess.ProcessType = type;
            BankProcess.Amount = amount;
            BankProcess.BankId = BankName;
            db.BankProcesses.Add(BankProcess);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sisteme eklendi!", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankaId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sistemden silindi!", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankaId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTId.Text);
            string description = txtTDescription.Text;
            DateTime date = DateTime.Parse(txtTDate.Text);
            decimal amount = decimal.Parse(txtTAmount.Text);
            int BankName = int.Parse(txtTBank.ToString());
            string type = txtTType.Text;



            var BankProcess = db.BankProcesses.Find(id);
            BankProcess.Description = description;
            BankProcess.ProcessDate = date;
            BankProcess.ProcessType = type;
            BankProcess.Amount = amount;
            BankProcess.BankId = BankName;
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sistemde güncellendi!", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankaId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
