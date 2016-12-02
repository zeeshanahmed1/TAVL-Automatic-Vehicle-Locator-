using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TavlWeb.WebAPI.Authentication;

namespace Tracking_Objects
{
    public partial class Notifications : Form
    {

        ServiceResponse _ServiceResponse;
        
        public Notifications()
        {

            InitializeComponent();
            // dgvNotifications.DataSource = dt;
          


        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            webNotifTrack.SendToBack();
            dgvNotifications.BackgroundColor = Color.FromArgb(255, 255, 255);
           // dgvNotifications.RowHeadersVisible = false;
            DesignBtns();
            //  getlogHistorybyGroup(glob.clientId, glob.groupId, glob.logId, glob.lastEventId);
            getAlertAdmin();
        
        }



        public void getAlertAdmin()
        {

            try
            {
                DataTable dt = new DataTable();
                DataSet dataSet;
                DataTable dataTable0;
                DataTable dataTable1;
                DataTable dataTable2;
                DataTable dataTable3;

                _ServiceResponse = (new ServiceCaller()).getLastEventAdmin(glob.clientId, glob.lastEventId);
                if (_ServiceResponse.ResponseCode == 200)
                {

                    //   string testString = "{\"table\":[{\"messageId\":921550269,\"objectId\":7203,\"altitude\":1011,\"gpsTime\":\"2016-08-22T10:15:55\",\"x\":71.8688911,\"y\":34.7709591,\"vectorAngle\":41,\"vectorSpeed\":0,\"visibleSatelites\":11},{\"messageId\":921550270,\"objectId\":7203,\"altitude\":1010,\"gpsTime\":\"2016-08-22T10:15:48\",\"x\":71.8688911,\"y\":34.7709591,\"vectorAngle\":41,\"vectorSpeed\":0,\"visibleSatelites\":10}],\"table1\":[{\"messageId\":921550270,\"eventLogId\":23662101,\"low\":9.0,\"high\":16.0,\"units\":\"V\",\"format\":\"0.0\",\"name\":\"Power Voltage\",\"value\":8.997,\"vectorSpeed\":0,\"loginId\":null,\"username\":null,\"vectorAngle\":41},{\"messageId\":921550269,\"eventLogId\":23662100,\"low\":9.0,\"high\":16.0,\"units\":\"V\",\"format\":\"0.0\",\"name\":\"Power\",\"value\":8.996,\"vectorSpeed\":0,\"loginId\":null,\"username\":null,\"vectorAngle\":41}],\"table2\":[{\"objectId\":7203,\"number\":\"LRL-7151\"}],\"table3\":[]}";
                   

                    string JsonLog = _ServiceResponse.Content.ToString();


                    //       if (JsonLog.Equals("{\"table\":[],\"table1\":[],\"table2\":[],\"table3\":[]}"))
                    if (JsonLog.Equals("{\"table\":[],\"table1\":[],\"table2\":[],\"table3\":[]}"))
                    {
                        //   MessageBox.Show("No alert Found");
                    }
                    else
                    {

                        if (dt.Columns.Count <= 0)
                        {
                            dt.Columns.Add("Alert Name", typeof(String));
                            dt.Columns.Add("Object Name", typeof(String));
                            dt.Columns.Add("Time", typeof(DateTime));
                            dt.Columns.Add("LatLong", typeof(String));
                            
                        }


                        
                        dataSet = JsonConvert.DeserializeObject<DataSet>(JsonLog);
                        dataTable0 = dataSet.Tables["table"];
                        dataTable1 = dataSet.Tables["table1"];
                        dataTable2 = dataSet.Tables["table2"];
                        dataTable3 = dataSet.Tables["table3"];
                       





                        var results = from table1 in dataTable0.AsEnumerable()
                                      join table2 in dataTable1.AsEnumerable() on (Int64)table1["messageId"] equals (Int64)table2["messageId"]
                                      join table3 in dataTable2.AsEnumerable() on (Int64)table1["objectId"] equals (Int64)table3["objectId"]

                                      select new
                                      {
                                          gpsTime = (DateTime)table1["gpsTime"],
                                          number = (string)table3["number"],
                                          name = (string)table2["name"],
                                          latlong = (double)table1["y"] + "," +(double)table1["x"]
                                      };


                        int indx = 0;


                        foreach (var item in results)
                        {



                            dt.Rows.Add(item.name, item.number, item.gpsTime, item.latlong);
                



                            indx += 1;



                        }
                     //   dt.Columns[3].ColumnMapping = MappingType.Hidden;
                        dgvNotifications.DataSource = dt;






                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       




        public void GetLastEventID()
        {
            try
            {

                _ServiceResponse = (new ServiceCaller()).getEvent_LastId(glob.clientId);
                if (_ServiceResponse.ResponseCode == 200)
                {


                    string res = _ServiceResponse.Content.Replace("{\"eventsData\":", "").Replace("}]}", "}]");
                    DataTable dataTable_LastEvent = JsonConvert.DeserializeObject<DataTable>(res);




                    if (res.Equals("[]}"))
                    {
                        MessageBox.Show("No Last Event ID Found");
                    }
                    else
                    {
                        int lastEventIDAdmin = int.Parse(dataTable_LastEvent.Rows[0].ItemArray[1].ToString());

                        glob.lastEventId = lastEventIDAdmin;

                    }







                    //eventID end
                }

            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void DesignBtns()
        {
           btnClearNotification.TabStop = false;
           btnClearNotification.FlatStyle = FlatStyle.Flat;
           btnClearNotification.FlatAppearance.BorderSize = 0;
           btnClearNotification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
           btnClearNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
           btnClearNotification.TabStop = false;

        }

        private void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNotifications_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           //start
            string marker = "marker.png";
            string image = "teltonika.png";
            XmlDocument doc = new XmlDocument();
            string latLong;
            string devName;
            string path;
            string gpsTime;
            string addres = "";
            foreach (DataGridViewRow row in dgvNotifications.SelectedRows)
            {

                latLong = row.Cells[3].Value.ToString();
               devName = row.Cells[1].Value.ToString();
             
                gpsTime = row.Cells[2].Value.ToString();
                

                try
                {
                    doc.Load("http://maps.googleapis.com/maps/api/geocode/xml?latlng=" +latLong+"&sensor=false");
                    XmlNode element = doc.SelectSingleNode("//GeocodeResponse/status");
                    if (element.InnerText == "ZERO_RESULTS")
                    {
                        // MessageBox.Show("No data available for the specified location");
                    }
                    else
                    {

                        element = doc.SelectSingleNode("//GeocodeResponse/result/formatted_address");

                        addres = element.InnerText.ToString();

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //end



                string startPath = Application.StartupPath + "\\teltonika_startup.html";

                path = Application.StartupPath + "\\notifTrack.html";


                string filename = Application.StartupPath + "\\myNotifTrack.html";
                myMap.replaceNotif(filename.ToString().Trim(), latLong, marker, image, path, devName, gpsTime, latLong.ToString(), addres);

                webNotifTrack.Source = new Uri(path);
                webNotifTrack.BringToFront();
                button1.BringToFront();
            }




            //end
        }

       
        private void btnClearNotification_Click_1(object sender, EventArgs e)
        {
            GetLastEventID();
            dgvNotifications.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webNotifTrack.SendToBack();
            button1.SendToBack();
        }
    }
}