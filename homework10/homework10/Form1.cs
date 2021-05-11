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
        SimpleCrawler crawler { get; set; } 
        public Form1()
        {
            InitializeComponent();
            crawler = new SimpleCrawler();//http://www.cnblogs.com/dstang2000/
            crawler.Refresh += RefreshPage;
            crawler.Finish += FinishCrawler;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshPage(Url url)
        {
            Action action = () =>
            {
                var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url };
                resultBindingSource.Add(url);
            };
            this.Invoke(action);
        }

        private void FinishCrawler()
        {
            Action action = () =>
            {
                this.crawler.f++;
                if(this.crawler.f==5)
                lblState.Text = "搜索完成";
            };
            this.Invoke(action);
        }

        private void btnStartUrl_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            Match match = Regex.Match(txtStartUrl.Text, SimpleCrawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";
            crawler.startUrl = txtStartUrl.Text;
            crawler.Initialize();
            //Task<double>[] tasks = {
            //    Task.Run(crawler.Start),
            //    Task.Run(crawler.Start),
            //    Task.Run(crawler.Start),
            //    Task.Run(crawler.Start),
            //    Task.Run(crawler.Start) };
         Parallel.Invoke(new Action[] {
             crawler.Start,
             crawler.Start,
             crawler.Start,
             crawler.Start,
             crawler.Start
           });
            /*Task.Run(crawler.Start);*/
            lblState.Text = "正在搜索";
            
        }

    }
}
