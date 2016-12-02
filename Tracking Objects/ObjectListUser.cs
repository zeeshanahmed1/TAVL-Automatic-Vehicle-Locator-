using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracking_Objects
{
    public class ObjectListUser
    {
        public ObjectListUser()
        {

        }

        //{"":0.0,"":0,"":0,"":0,"":"5646","":"SWAT ACCOUNT","":"Multiple Groups"}

        public string gpsSortableTime { get; set; }
        public string number { get; set; }
        public string unitId { get; set; }
        public string gpsTime { get; set; }
        public string landMarksValue { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string angle { get; set; }
        public string speed { get; set; }
        public string satellites { get; set; }
        public string numberStr { get; set; }
        public string clientName { get; set; }
        public string groupName { get; set; }
        public string gpsFormattedTime { get; set; }

        public string messageId { get; set; }
        public string date { get; set; }
        public string time { get; set; }
    }
}
