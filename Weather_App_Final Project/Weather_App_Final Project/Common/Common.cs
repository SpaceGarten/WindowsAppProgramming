using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App_Final_Project.Common
{
    public class Common
    {
        public static string API_LINK = "http://api.openweathermap.org/data/2.5/weather";
        public static string API_KEY = "bb1b87c57e2f69ec795aad8174127e29";

        public static string APIRequest(string lat, string lon)
        {
            StringBuilder sb = new StringBuilder(API_LINK);
            sb.AppendFormat("?lat={0}&lon={1}&appid={2}", lat, lon, API_KEY);
            return sb.ToString();
        }

        public static DateTime ConvertUnixToDateTime(double unix)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);

            dt = dt.AddSeconds(unix).ToLocalTime();
            return dt;
        }
    }
}
