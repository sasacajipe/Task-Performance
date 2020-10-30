using System;
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
    public partial class NowServing : Form
    {
        public NowServing()
        {
            InitializeComponent();
        }

        private void NowServing_Load(object sender, EventArgs e)
        {
            try
            {
                if (CashierClass.CashierQueue.Count == 0)
                {
                    throw new ArgumentNullException(" No student in line");
                }
                else
                {
                    label2.Text = CashierClass.CashierQueue.Peek();
                    timer1.Start();
                }
            }
            catch (ArgumentNullException arg)
            {
                MessageBox.Show(arg.Message);
            }
        }
        private int ticker = 1;


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticker <= 3)
            {
                ticker++;
            }
            else
            {

                CashierClass.CashierQueue.Dequeue();
                timer1.Stop();
                this.Close();
            }
    }
    }
}
