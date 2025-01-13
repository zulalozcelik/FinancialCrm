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
            lblTotalBalance.Text = totalBalance.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
        }
    }
}
