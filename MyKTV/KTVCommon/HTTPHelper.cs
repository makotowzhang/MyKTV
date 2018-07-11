using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web;

namespace MyKTV.KTVCommon
{
    public class HTTPHelper
    {
        public static bool DownLoadFile(string url, string savePath)
        {
            WebClient client = new WebClient();
            try
            {
                client.DownloadFile(url, savePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string HttpGet(string url, Encoding encoding)
        {
            WebClient client = new WebClient();
            return encoding.GetString(client.DownloadData(url));
        }

        public static string HttpPost(string url, Dictionary<string, string> param, Encoding encoding)
        {
            HttpWebRequest request =  (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded;charset=gbk";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
            string formBody = "";
            if (param != null)
            {
                foreach (var dic in param)
                {
                    formBody += HttpUtility.UrlEncode(dic.Key, encoding) +"="+ HttpUtility.UrlEncode(dic.Value, encoding) +"&";
                }
            }
            if (!string.IsNullOrWhiteSpace(formBody))
            {
                formBody = formBody.Substring(0, formBody.Length - 1);
            }
            byte[] bs = Encoding.ASCII.GetBytes(formBody);
            request.ContentLength = bs.Length;
            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
            }
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream responseStream = response.GetResponseStream();
            string htmlStr = "";
            using (StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("GB2312")))
            {
                htmlStr = reader.ReadToEnd();
            }
            responseStream.Close();
            return htmlStr;
        }
    }
}
