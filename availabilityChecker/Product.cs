using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using xNet;

namespace availabilityChecker
{
    public static class Product
    {
        public static string Name { get; set; }
        public static string Link { get; set; }
        public static string Status { get; set; }

        private static string WebPage { get; set; }

        private const string ExpectedStatus = "Купить";
        private const string NeededStatus = "В наличии";

        public static void UpdateWebPage()
        {
            try
            {
                var webclient = new WebClient { Encoding = System.Text.Encoding.UTF8 };
                WebPage = webclient.DownloadString(Link);
            }
            catch (WebException e)
            {
                WebPage = e.Message;
            }

        }

        private static void UpdateName()
        {
            try
            {
                Name = WebPage.Substrings("<h1 class=\"detail-title\" itemprop=\"name\">", "</h1>", 0)[0];
            }
            catch (IndexOutOfRangeException)
            {
                Name = "Cannot get name";
            }
            Name = Util.ClearString(Name);
        }

        private static void UpdateStatus()
        {
            try
            {
                Status = WebPage.Substrings("<div class=\"detail-status\">", "</div>", 0)[0];
            }
            catch (IndexOutOfRangeException)
            {
                try
                {
                    Status = WebPage.Substrings("<button class=\"btn-link-i\" type=\"submit\">", "</button>", 0)[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Status = "Cannot get status";
                }
            }
            Status = Util.ClearString(Status);
            if (string.Equals(Status, ExpectedStatus) || string.Equals(Status, string.Empty))
            {
                Status = NeededStatus;
            }

        }


        public static void UpdateInfo()
        {
            UpdateWebPage();
            UpdateName();
            UpdateStatus();
        }

        public static void StatusEqualsNeeded()
        {
            if (string.Equals(Status, NeededStatus))
            {
                MessageBox.Show("Товар появился в наличии", "УРА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
