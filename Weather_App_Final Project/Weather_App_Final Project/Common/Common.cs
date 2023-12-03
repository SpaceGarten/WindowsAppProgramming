using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App_Final_Project.Common
{
    public class Common
    {
        public static string API_LINK = "https://api.openweathermap.org/data/3.0/onecall";
        public static string API_KEY = "bb1b87c57e2f69ec795aad8174127e29";

        public static string APIRequest(string lat, string lon)
        {
            StringBuilder sb = new StringBuilder(API_LINK);
            sb.AppendFormat("?lat={0}&lon={1}&appid={2}", lat, lon, API_KEY);
            return sb.ToString();
        }
    }
}
