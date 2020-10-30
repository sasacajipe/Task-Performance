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

namespace Task_Performance
{
    public partial class CashierWindowQueue : Form
    {
        public void DisplayCashierQueue(IEnumerable CashierList){
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList){
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        public CashierWindowQueue()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
            NowServing nw = new NowServing();
            nw.Show();
        }

        private void CashierWindowQueue_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
