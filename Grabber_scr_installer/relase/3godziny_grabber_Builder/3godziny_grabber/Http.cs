using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _3godziny_grabber
{
    class Http
    {
        public static byte[] Post(string uri, NameValueCollection paris)
        {
            using (WebClient WebClient = new WebClient())
            {
                return WebClient.UploadValues(uri, paris);
            }


        }
    }
}
