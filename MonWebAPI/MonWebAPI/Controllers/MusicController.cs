using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace MonWebAPI.Controllers
{
    public class MusicController : ApiController
    {
        public string Get(int id)
        {
            //string urlAddress = "https://api.discogs.com/users/ausamerika/collection/folders/0/releases";
            //string urlAddress = "http://ip.taobao.com/service/getIpInfo.php?ip=203.49.243.0";
            string urlAddress = "https://api.apiopen.top/musicRankings";

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string jsonString = client.DownloadString(urlAddress);

            //TODO: JSON
            string test = "{\"Age\":28,\"Name\":\"张三\"}";

            return jsonString;
        }
    }
}
