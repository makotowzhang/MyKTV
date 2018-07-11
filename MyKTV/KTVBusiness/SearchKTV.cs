using MyKTV.KTVCommon;
using MyKTV.KTVModel;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using MyKTV.KTVEntity;
using System.Linq;
using System;

namespace MyKTV.KTVBusiness
{
    public class SearchMTV
    {
        public string MTVDomain
        {
            get
            {
                return "http://www.mtv-ktv.net";
            }
        }

        public string RootPath
        { get { return PathHelper.GetRootDirectory(); } }

        public List<MTVInfo> GetMTVList(string mtvName)
        {
          
            //using (KTVDataBase db = new KTVDataBase())
            //{
            //    if (db.SearchCache.Any(m => m.SearchName == mtvName))
            //    {
            //        var cache = db.SearchCache.FirstOrDefault(m => m.SearchName == mtvName);
            //        return JsonConvert.DeserializeObject<List<MTVInfo>>(cache.SearchContent);
            //    }
            //}
            var list = new List<MTVInfo>();
            WebClient client = new WebClient();
            string url = MTVDomain+ "/search_mtv.asp?Type=1&File=1&bSearch=MV%CB%D1%CB%F7&ktv=" + HttpUtility.UrlEncode(mtvName, Encoding.GetEncoding("GBK"));
            string html = client.DownloadString(url).Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
            html = Regex.Match(html, "<ul class=\"clearfix\" id=\"f1\">.*</ul>", RegexOptions.IgnoreCase).Value;
            int i= 0;
            foreach (Match m in Regex.Matches(html, "<li>.*?</li>", RegexOptions.IgnoreCase))
            {
                if (i++ == 9)
                {
                    break;
                }
                if (m.Value.Contains("文件大小"))
                {
                    continue;
                }
                MTVInfo model = new MTVInfo();
                //<a class='songName' href='/mv/mtv15/ktv148493.htm' title='阿生-七里香_国语_流行_NCB18664_MTVP2P.mkv'>七里香</a>
                string nameDetail = Regex.Match(m.Value, "<a class='songName' .*?</a>").Value;
                //  href='/mv/mtv15/ktv148493.htm'
                string songNameDetail =  Regex.Match(nameDetail, "href='.*?'").Value;
                model.DetailUrl = MTVDomain + songNameDetail.Replace("href=", "").Replace("'", "");
                //  title='阿生-七里香_国语_流行_NCB18664_MTVP2P.mkv'
                string songTitleDetail = Regex.Match(nameDetail, "title='.*?'").Value;
                model.SouceFileName = songTitleDetail.Replace("title=", "").Replace("'", "");
                model.MTVName = nameDetail.Replace("<a class='songName' " + songNameDetail + " " + songTitleDetail + ">", "").Replace("</a>", "");
                //<a class='singerName' href='/star/?周杰伦' title='点击进入歌手专题'>周杰伦</a>
                string singerName= Regex.Match(m.Value, "<a class='singerName' .*?</a>").Value;
                model.Artist = singerName.RemoveRegexStr("<a class='singerName' href='.*?' title='.*?'>").Replace("</a>", "");
                model.MTVSize = Regex.Match(m.Value, "<span class='albumName'>.*?</span>").Value.Replace("<span class='albumName'>","").Replace("</span>", "");
                GetMTVDownloadInfo(model);
                list.Add(model);
            }
            using (KTVDataBase db = new KTVDataBase())
            {
                if (db.SearchCache.Where(m => m.SearchName == mtvName).Count() == 0)
                {
                    db.SearchCache.Add(new SearchCache()
                    {
                        SearchName = mtvName,
                        SearchContent = JsonConvert.SerializeObject(list),
                        CreateTime = DateTime.Now
                    });
                    db.SaveChanges();
                }
            }
            return list;
        }

        public void GetMTVDownloadInfo(MTVInfo mtv)
        {
            if (string.IsNullOrWhiteSpace(mtv.DetailUrl))
            {
                return;
            }
            WebClient client = new WebClient();
            string html = client.DownloadString(mtv.DetailUrl).Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
            mtv.MTVImage = Regex.Match(html, "document.getElementById\\('bigimg'\\).src='.*?'", RegexOptions.IgnoreCase).Value.Replace("document.getElementById('bigimg').src='", "").Replace("'", "");
            mtv.ED2KUrl = Regex.Match(html, "ed2k://\\|.*?\\|/", RegexOptions.IgnoreCase).Value;
            string mobileUrl= Regex.Match(html, "<div class=\"jk_img fl\">.*?</div>", RegexOptions.IgnoreCase).Value.RemoveRegexStr("<div.*?href=\"").RemoveRegexStr("\">.*</div>");
            string mobileHtml= Encoding.UTF8.GetString(client.DownloadData(MTVDomain+mobileUrl)).Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
            mtv.ServerUrl = Regex.Match(mobileHtml, "网盘下载</a>.*?<a href=.*?class=\"btn-dl-com\">普通下载</a>").Value.RemoveRegexStr("网盘下载</a>.*?<a href=\"").RemoveRegexStr("\".*</a>");
            string cloudDiskHtml = Regex.Match(mobileHtml, "<a rel.*?class=\"btn-dl-speed\">网盘下载</a>").Value.Replace("\" class=\"btn-dl-speed\">网盘下载</a>", "").RemoveRegexStr("<a rel.*?href=\"");
            string cloudHtml = HTTPHelper.HttpGet(cloudDiskHtml,Encoding.UTF8).Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
            //https://mvxzjl.ctfile.com/get_file_url.php?uid=12871846&fid=163660028&file_chk=2d661c736a0c7c4946ecf4f853352fc9
            string uid = Regex.Match(cloudHtml, "var userid = '.*?'").Value.Replace("var userid = '", "").Replace("'","");
            //free_down('163660028', 0, '2d661c736a0c7c4946ecf4f853352fc9', 0, 0)
            string[] pt = Regex.Match(cloudHtml, "free_down\\(.*?0\\)").Value.Replace("free_down(", "").Replace(")","").Replace("'","").Replace(" ","").Split(',');
            string fid = pt[0];
            string file_chk = pt[2];
            string getDownloadUrl = $"https://mvxzjl.ctfile.com/get_file_url.php?uid={uid}&fid={fid}&file_chk={file_chk}";
            string downloadurl = client.DownloadString(getDownloadUrl).Replace("\\/","/");
            DownlaodJson json = JsonConvert.DeserializeObject<DownlaodJson>(downloadurl);
            mtv.CloudDiskUrl = json.downurl;
        }

        public void DownLoadMtvImage(MTVInfo mtv)
        {
            if (string.IsNullOrWhiteSpace(mtv.MTVImage)||!string.IsNullOrWhiteSpace(mtv.LocalImagePath))
            {
                return;
            }
            WebClient client = new WebClient();
            string dirPath = RootPath + "\\images\\";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            string imgPath = dirPath + mtv.MTVName + "-" + mtv.Artist + ".jpg";
            client.DownloadFileCompleted += (s, e) => { mtv.LocalImagePath = imgPath; };
            client.DownloadFileAsync(new System.Uri(mtv.MTVImage), imgPath);
        }

        private class DownlaodJson
        {
            public string downurl { get; set; }

            public int code { get; set; }

            public int file_size { get; set; }

            public string confirm_url { get; set; }
        }
    }

  
}
