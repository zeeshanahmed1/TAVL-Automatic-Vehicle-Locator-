using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Tracking_Objects
{
    class ServiceStatistics
    {

        public string GetUserGeneralInforamtionUrl(string UerNamenClientCode)
        {

    
            return string.Format("{0}WebAPI/api/Security?username={1}", ApplicationStatics.ServiceIPAddress, UerNamenClientCode);


        }


        public string GetClientGroupUserUrl_1(int LoginId, int RoleID, int version_1)
        {
            return string.Format("{0}WebAPI/api/Group?loginId={1}&roleId={2}&version_1={2}", ApplicationStatics.ServiceIPAddress, LoginId, RoleID, version_1);
        }


        public string GetAdminClientGroupsUrl(int clientId)
        {
            return string.Format("{0}WebAPI/api/Group?clientCode={1}", ApplicationStatics.ServiceIPAddress, clientId);
        }



       

        public string GetLastEventId(int clientId)
        { 

        //  WebAPI/api/Alert?clientId=%d
            return string.Format("{0}WebAPI/api/Alert?clientId={1}" , ApplicationStatics.ServiceIPAddress,clientId);
        }


        public string GetTrackhistoryUrl(int objectID, string datefrom, string dateto)
        {

            return string.Format("{0}WebAPI/api/Track?unitId={1}&dateFrom={2}&dateTo={3}", ApplicationStatics.ServiceIPAddress, objectID, datefrom, dateto);

        }

        public string getAlertAdmin(int clientID, int lastEventID)
        {
            //WebAPI/api/Alert?clientId=%d&lastEventId=%d
            return string.Format("{0}WebAPI/api/Alert?clientId={1}&lastEventId={2}", ApplicationStatics.ServiceIPAddress, clientID,lastEventID);
        }


        public string GetEventLogHisory(int objectID, string datefrom, string dateto)
        {
            // WebAPI/api/Alert?unitId=%d&dateFrom=%@&dateTo=%@
            return string.Format("{0}WebAPI/api/Alert?unitId={1}&dateFrom={2}&dateTo={3}", ApplicationStatics.ServiceIPAddress, objectID, datefrom, dateto);
        }



        public string GetEventLogListByGroup(int clientID, int groupID, string loginID, int lastEventID)
        {
         //for user
            return string.Format("{0}WebAPI/api/Alert?clientId={1}&groupId={2}&loginId={3}&lastEventId={4}", ApplicationStatics.ServiceIPAddress, clientID, groupID, loginID, lastEventID);
        }

        public string GetLandMarksUrl(int clientId, int groupId, int state, string isReverseGeocoding)
        {
            //to be edited twice (for new service)
            return

              string.Format("{0}WebAPI/api/LandMark?clientId={1}&groupId={2}&state={3}&isReverseGeocoding={4}", ApplicationStatics.ServiceIPAddress, clientId, groupId, state, isReverseGeocoding);
        }


        public string GetUnitCurrentInformation(int objectID, string isReverseGeoCoding)

        {
            return string.Format("{0}WebAPI/api/LandMark?objectId={1}&isReverseGeocoding={2}", ApplicationStatics.ServiceIPAddress, objectID, isReverseGeoCoding);
        
        }
    }
}