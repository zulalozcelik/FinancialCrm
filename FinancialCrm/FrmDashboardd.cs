using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmDashboardd : Form
    {
        public FrmDashboardd()
        {
            InitializeComponent();
        }
       
        FinancialCrmDbEntities db= new FinancialCrmDbEntities();
        int count = 0;

       

        private void Form2_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.Balance);
            lblTotalBalance.Text = totalBalance.ToString() + "₺";

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + "₺";

            //Chart 1
            var bankdata = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.Balance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankdata)
            {
                series.Points.AddXY(item.BankTitle, item.Balance);
            }

            //Chart 2
            var Billdata = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmonut
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
            foreach (var item in Billdata)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmonut);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count %4 == 2)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmonut).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + "₺";
            }
            if (count % 4 == 2)
            {
                var dogalgazFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmonut).FirstOrDefault();
                lblBillTitle.Text = "doğalgaz faturası";
                lblBillAmount.Text = dogalgazFaturasi.ToString() + "₺";
            }
            if (count % 4 == 3)
            {
                var suFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmonut).FirstOrDefault();
                lblBillTitle.Text = "su faturası";
                lblBillAmount.Text = suFaturasi.ToString() + "₺";
            }
            if (count % 4 == 0)
            {
                var internetFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmonut).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = internetFaturasi.ToString() + "₺";
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
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
    }
}
