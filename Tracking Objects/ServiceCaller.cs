using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavlWeb.WebAPI.Authentication;
using System.Web;
using System.Net;
using System.IO;

namespace Tracking_Objects
{
    class ServiceCaller
    {
        #region for User
        //Use get logedIn user Information
        public ServiceResponse getUserInforamtion(log4net.ILog LOG)
        {
            string URL =
                   (new ServiceStatistics().GetUserGeneralInforamtionUrl(ApplicationStatics.GetUserNamenClientCode(ApplicationStatics.UserName, ApplicationStatics.ClientCode)));

            return callServiceByURL(URL, LOG);

        }

        public ServiceResponse callServiceByURL(string URL, log4net.ILog LOG)
        {
           
            ServiceResponse _serviceResponse = null;
           
            try
            {
                LOG.InfoFormat("IPAddress : {0}, Service Call URL : {1} .", ApplicationStatics.ClientIPAddress, URL);
                
                _serviceResponse = (new HttpCaller()).ExecuteGetHttpWebRequest(
                   ApplicationStatics.GetUserNamenClientCode(ApplicationStatics.UserName, ApplicationStatics.ClientCode),
                   ApplicationStatics.SecretKey,
                   URL,
                   "");
            }
          
            catch (Exception e)
            {
                // TODO Auto-generated catch block
                _serviceResponse = new ServiceResponse()
                {
                    ResponseCode = -4,
                    Content = e.Message,
                    Exception = e.StackTrace
                };

            }
            /********************************************
             * Exception Code and Description 
             * Exception Code = -1, NoSuchAlgorithmException
             * Exception Code = -2, ClientProtocolException
             * Exception Code = -3, IOException
             * Exception Code = -4, Exception on ServiceCaller Class
             * Exception Code = -5, Exception on ActivityCall
            *********************************************/
            LOG.InfoFormat("IPAddress : {0}, Service Call Response :  ResponseCode : {1}, \n ResponseContent : {2}, \n ResponseExpection : {3}",
                ApplicationStatics.ClientIPAddress, _serviceResponse.ResponseCode, _serviceResponse.Content, _serviceResponse.Exception);
            return _serviceResponse;
        }

        #endregion 

        #region For Clients


        public ServiceResponse callServiceByURL(string URL)
        {
            ServiceResponse _serviceResponse = null;

            try
            {
                //LOG.InfoFormat("IPAddress : {0}, Service Call URL : {1} .", ApplicationStatics.ClientIPAddress, URL);
                _serviceResponse = (new HttpCaller()).ExecuteGetHttpWebRequest(
                   ApplicationStatics.GetUserNamenClientCode(ApplicationStatics.UserName, ApplicationStatics.ClientCode),
                   ApplicationStatics.SecretKey,
                   URL,
                   "");
            }

            catch (Exception e)
            {
                // TODO Auto-generated catch block
                _serviceResponse = new ServiceResponse()
                {
                    ResponseCode = -4,
                    Content = e.Message,
                    Exception = e.StackTrace
                };

            }



           
            /********************************************
             * Exception Code and Description 
             * Exception Code = -1, NoSuchAlgorithmException
             * Exception Code = -2, ClientProtocolException
             * Exception Code = -3, IOException
             * Exception Code = -4, Exception on ServiceCaller Class
             * Exception Code = -5, Exception on ActivityCall
            *********************************************/
            //LOG.InfoFormat("IPAddress : {0}, Service Call Response :  ResponseCode : {1}, \n ResponseContent : {2}, \n ResponseExpection : {3}",
            //ApplicationStatics.ClientIPAddress, serviceResponse.ResponseCode, serviceResponse.Content, _serviceResponse.Exception);
            return _serviceResponse;
        }




        public ServiceResponse getClientGroupUser_1(int version_1)
        {
            string URL = (new ServiceStatistics()).GetClientGroupUserUrl_1(int.Parse(ApplicationStatics._UserInforamtion.id), int.Parse(ApplicationStatics._UserInforamtion.roleId), version_1);
            return callServiceByURL(URL);

        }

        #endregion 




        #region groups load


      public ServiceResponse getGroup4AdminRole(int clientId)
      {

          string URL = (new ServiceStatistics()).GetAdminClientGroupsUrl(clientId);
          return callServiceByURL(URL);
      }
        #endregion 


      public ServiceResponse getObjectListWhenAdminAndPower(int clientId, int groupId, int state, string isReverseGeoCoding)
      {
        //  string URL = (new ServiceStatistics()).GetLandMarksUrl(int clientId, int groupId, int state, string isReverseGeocoding);
          string URL = (new ServiceStatistics()).GetLandMarksUrl(clientId, groupId, state, isReverseGeoCoding);
          return callServiceByURL(URL);
      
      }
        //start details
      public ServiceResponse getObjectListDetailsWhenAdminAndPower(int objectID,string isREverseGeoCoding)
      {
          //  string URL = (new ServiceStatistics()).GetLandMarksUrl(int clientId, int groupId, int state, string isReverseGeocoding);
          string URL = (new ServiceStatistics()).GetUnitCurrentInformation(objectID, isREverseGeoCoding);
          return callServiceByURL(URL);

      }

        //end object details

        public ServiceResponse getEvent_LastId(int clientId)
      {
          string URL = (new ServiceStatistics()).GetLastEventId(clientId);
          return callServiceByURL(URL);


      }



        public ServiceResponse gettrackhistory(int objectId, string datefrom, string dateto)
        {

            string URL = (new ServiceStatistics()).GetTrackhistoryUrl(objectId, datefrom, dateto);

            return callServiceByURL(URL);

        }

        public ServiceResponse getLastEventAdmin(int clientID, int LastEventID)
        {
            string URL = (new ServiceStatistics()).getAlertAdmin(clientID,LastEventID);

            return callServiceByURL(URL);
        
        }


        public ServiceResponse getEventLoghistory(int objectId, string datefrom, string dateto)
        {

            string URL = (new ServiceStatistics()).GetEventLogHisory(objectId, datefrom, dateto);

            return callServiceByURL(URL);

        }




        public ServiceResponse getEventLoghistoryByGroup(int clientId, int groupId, string loginId, int lastEventId)
        {

            string URL = (new ServiceStatistics()).GetEventLogListByGroup(clientId, groupId, loginId, lastEventId);

            return callServiceByURL(URL);

        }


    }
}
