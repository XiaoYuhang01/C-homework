using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace homework10
{
    public class Url
    {
        public Url(int num,string url,string state)
        {
            this.num = num;
            this.url = url;
            this.state = state;
        }
        public override bool Equals(object obj)
        {
            Url url = obj as Url;
            return this.url == url.url;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public int num { get; set; }
        public string url { get; set; }
        public string state { get; set; }
    }
    public class SimpleCrawler
    {
        private int MaxPage { get; set; }
        private Encoding HtmlEncoding { get; set; }
        public string HostFilter { get; set; }
        public string FileFilter { get; set; }
        public string startUrl { get; set; }
        public event Action<Url> Refresh;
        public event Action Finish;
        public int f = 0;
        private static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        public ConcurrentQueue<Url> list = new ConcurrentQueue<Url>();
        private ConcurrentQueue<string> pending = new ConcurrentQueue<string>();


        public SimpleCrawler()
        {
            MaxPage = 1000;
            HtmlEncoding = Encoding.UTF8;
        }
        public void Initialize()
        {
            while(list.Count!=0)
            {
                list.TryDequeue(out Url url);
            }
            while (pending.Count != 0)
            {
                pending.TryDequeue(out string url);
            }
            pending.Enqueue(startUrl);
        }
        public void Start()
        {
            while (true)
            {
                if (pending.Count == 0||list.Count == MaxPage)
                {
                    Finish();
                    return;
                }
                Thread.Sleep(1000);
                string url;
                while (!pending.TryDequeue(out url))
                {
                    continue;
                }
                try
                {
                    string html = DownLoad(url); // 下载
                    lock (list)
                    {
                        list.Enqueue(new Url(list.Count, url, "success"));
                        Refresh(new Url(list.Count, url, "success"));
                    }
                    Parse(html, url);
                }
                catch (Exception e)
                {
                    lock (list)
                    {
                        list.Enqueue(new Url(list.Count, url, "error:" + e.Message));
                        Refresh(new Url(list.Count, url, "error:" + e.Message));
                    }
                }

            }
        }
        private string DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = list.Count.ToString();
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }
        private void Parse(string html, string pageUrl)
        {
            var matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;

                linkUrl = FixUrl(linkUrl, pageUrl);//转绝对路径
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !list.Contains(new Url(0,linkUrl,"success")))
                {
                    pending.Enqueue(linkUrl);
                }
            }
        }
        static private string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { //完整路径
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
        
    }
}
