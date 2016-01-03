using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using xNet;

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
            Product.UpdateInfo();
            productName.Text = Product.Name;
            productLink.Text = Product.Link;
            productStatus.Text = Product.Status;
            Product.StatusEqualsNeeded();
        }

        private void productLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(productLink.Text);
            Process.Start(sInfo);
        }
    }
}
