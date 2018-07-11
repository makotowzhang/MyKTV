using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace MyKTV.KTVCommon
{
    public static class Extensions
    {
        public static string RemoveRegexStr(this string str, string regStr)
        {
            Regex rg = new Regex(regStr);
            return rg.Replace(str, "");
        }
    }
}
