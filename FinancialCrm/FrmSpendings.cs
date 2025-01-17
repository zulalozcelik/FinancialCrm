using FinancialCrm.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Infrastructure;


namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmonut,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }
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
           var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmonut,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = Convert.ToDateTime(txtSpendingDate.Text);
            int categoryName = int.Parse(txtSpendingCategory.ToString());

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmonut = amount;
            spendings.SpendingDate = date;
            spendings.CategoryId = categoryName;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde sisteme eklendi!", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmonut,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde sistemden silindi!", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmonut,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = Convert.ToDateTime(txtSpendingDate.Text);
            int categoryName = int.Parse(txtCategory.ToString());


            var spendings = db.Spendings.Find(id);
            spendings.SpendingTitle = title;
            spendings.SpendingAmonut = amount;
            spendings.SpendingDate = date;
            spendings.CategoryId = categoryName;
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde sistemde güncellendi!", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmonut,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
