using MyKTV.KTVEntity;
using System.Collections.Generic;
using System.Linq;

namespace MyKTV.KTVBusiness
{
    public class OrderMTV
    {
        public static List<MyMTV> SearchMyMTV(string MTVName)
        {
            using (KTVDataBase db = new KTVDataBase())
            {
                var temp = db.MyMTV.Where(m => m.MTVName.Contains(MTVName) || m.Artist.Contains(MTVName)).OrderBy(m=>m.MTVName);
                return temp.ToList();
            }
        }
    }
}
