using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework10
{
    public partial class Form1 : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        Crawler crawler = new Crawler();
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
            dgvResultDataGridView.DataSource = resultBindingSource;
            crawler.PageDownloaded += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(Crawler obj)
        {
            Action action = () => lblInfoLabel.Text = "≈¿≥Ê“—Õ£÷π";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            crawler.StartURL = txtUrlTextBox.Text;

            Match match = Regex.Match(crawler.StartURL, Crawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = ".html?$";

            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(crawler.Start);
            thread.Start();
            lblInfoLabel.Text = "≈¿≥Ê“—∆Ù∂Ø....";
        }
    }
}