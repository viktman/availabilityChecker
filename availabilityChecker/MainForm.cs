using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace availabilityChecker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            Product.Link = inputLink.Text;
            DoStuff();
            timer.Start();
        }

        private void productLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(productLink.Text);
            Process.Start(sInfo);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Util.TickCounter--;
            if (Util.TickCounter == 0)
            {
                Util.TickCounter = 30;
                DoStuff();
            }
            countdown.Text = string.Format("00:{0}", Util.TickCounter.ToString("D2"));
        }

        private void DoStuff()
        {
            Product.UpdateInfo();
            productName.Text = Product.Name;
            productLink.Text = Product.Link;
            productStatus.Text = Product.Status;
            lastUpdate.Text = Product.UpdateTime.ToString();
            Product.StatusEqualsNeeded();
        }
    }
}
