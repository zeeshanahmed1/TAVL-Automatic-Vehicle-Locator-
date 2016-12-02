using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavlWeb.WebAPI.Authentication;
using System.Web;

namespace Tracking_Objects
{
    class ApplicationStatics
    {

        public static string UserName { get; set; }
        public static string ClientCode { get; set; }

        public static string ClientID { get; set; }
        public static string ClientName { get; set; }
        public static string SecretKey { get; set; }
        public static string ServiceIPAddress { get; set; }

        public static UserInformation _UserInforamtion { get; set; }

        

       

        /*public static List<ClientsLOV> _ClientsLOVList { get; set; }

        public static List<ClientsLOV> _GroupLOVList { get; set; }*/


        public static string GetUserNamenClientCode(string _UserName, string _ClientCode)
        {
            if (string.IsNullOrEmpty(_ClientCode))
            {
                return string.Format("{0}@", _UserName);
            }
            else
            {
                return string.Format("{0}@{1}", _UserName, _ClientCode);
            }
        }



       

        public static string isReverseGeocoding { get; set; }

        public static string ClientIPAddress { get; set; }

        public static long LastMaxEventInfoMessageId { get; set; }
        public static long LastMaxWarningInfoMessageId { get; set; }

        public static string serverInputDateFormat = "yyyy-MM-dd HH:mm:ss";

       
    }
}
