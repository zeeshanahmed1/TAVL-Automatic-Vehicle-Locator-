using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracking_Objects
{
   public class UserInformation
    {

        public UserInformation()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string id { get; set; }
        public string clientId { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        /***********************************
          -1	Administrator
           0	Power User
           1	User
           2	Disabled User
         ***********************************/

        public string roleId { get; set; }
        public string masterGroupId { get; set; }
        public string serverDateTime { get; set; }
        public string serverTimeZone { get; set; }
        public string serverFullTimeZone { get; set; }
    }
}
