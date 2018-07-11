using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using MyKTV.KTVModel;
using MyKTV.KTVEntity;

namespace MyKTV.KTVBusiness
{
    public class DownLoadMTV
    {
        public static void BeginDownload()
        {
            List<DownloadInfo> DownloadQeueu = KTVStatus.RunTimeData.DownloadQueue;
            lock (DownloadQeueu)
            {
                foreach (DownloadInfo di in DownloadQeueu.OrderBy(m => m.Sort))
                {
                    if (di.IsDownloading||di.IsCompelet)
                    {
                        continue;
                    }
                    if (di.DownloadType == KTVEnum.MTVDownloadType.Server ||
                        (di.DownloadType == KTVEnum.MTVDownloadType.Cloud && DownloadQeueu.Where(m => m.DownloadType == KTVEnum.MTVDownloadType.Cloud).All(m => m.IsDownloading == false)))
                    {
                        WebClient client = new WebClient();
                        if (di.ProcessChange != null)
                        {
                            client.DownloadProgressChanged += di.ProcessChange;
                        }
                        if (di.Complete != null)
                        {
                            client.DownloadFileCompleted += di.Complete;
                        }
                        client.DownloadFileCompleted += (sender, e) => 
                        {
                            di.IsDownloading = false;
                            di.IsCompelet = true;
                            using (var db=new KTVDataBase())
                            {
                                db.MyMTV.Add(new MyMTV()
                                {
                                    Id=di.MTV.Id.ToString(),
                                    Artist=di.MTV.Artist,
                                    CloudDiskUrl=di.MTV.CloudDiskUrl,
                                    DetailUrl= di.MTV.DetailUrl,
                                    ED2KUrl= di.MTV.ED2KUrl,
                                    FileName= di.MTV.MTVName+"-"+ di.MTV.Artist+".mkv",
                                    MTVImage= di.MTV.MTVImage,
                                    MTVName= di.MTV.MTVName,
                                    SavePath=di.SavePath,
                                    MTVSize= di.MTV.MTVSize,
                                    ServerUrl= di.MTV.ServerUrl,
                                    SouceFileName= di.MTV.SouceFileName
                                });
                                db.SaveChanges();
                            }
                            BeginDownload();
                        };
                        if (di.DownloadType == KTVEnum.MTVDownloadType.Cloud)
                        {
                            di.WebUrl = di.MTV.CloudDiskUrl;
                        }
                        if (di.DownloadType == KTVEnum.MTVDownloadType.Server)
                        {
                            di.WebUrl = di.MTV.ServerUrl;
                        }
                        di.IsDownloading = true;
                        client.DownloadFileAsync(new Uri(di.WebUrl), di.SavePath);
                    }
                }
            }
        }
    }

    
}
