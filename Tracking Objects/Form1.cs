using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using TavlWeb.WebAPI.Authentication;
using TavlMobile.WebAPI.Authentication;
using Newtonsoft.Json;
using log4net;
using Newtonsoft.Json.Linq;
using System.Web;
using System.Reflection;
using System.Xml;

namespace Tracking_Objects
{
    public partial class Form_Map : Form
    {


        ServiceResponse _ServiceResponse;
        private readonly log4net.ILog _log = LogManager.GetLogger(typeof(Form_Map));

        DataTable RawdataTable;
        DataTable selected;
        DataView src;
        int gpID = 0;
        double longtitude = 0;
        double latitude = 0;
        DataView view;
        string path1;
        string path_play;
        string trackPath;
        string trackLon;
        string trackLat;
        int lastEventIDAdmin;
        DataSet dataSet;
        DataTable dataTable0;
        DataTable dataTable1;
        DataTable dataTable2;
        DataTable dataTable3;
        DataTable dataTable_eventHistory;
      
        DataTable dt = new DataTable();

       

        public static int notifCount = 50;
        public Form_Map()
        {

            InitializeComponent();

          
        }


        string path;
        int ClientID = 0;
        String JsonResult;




        private void Form1_Load(object sender, EventArgs e)
        {
            listViewObjectDetails.Visible = false;
            btnObjectDetails.Enabled = false;

            // img column

            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
           
          //  iconColumn.Name = "speed";
           // iconColumn.HeaderText = "Nice tree";
            dgvObjectList.Columns.Add(iconColumn);
            //





            Util2.Animate(panelPlayButtons, Util2.Effect.Slide, 150, 90);
            panelPlayButtons.SendToBack();
            slide.PerformClick();
            btnNotification.Enabled = false;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            
            try
            {
                //start
                string appFolderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

                string resourcesFolderPath = Path.Combine(Directory.GetParent(appFolderPath).Parent.FullName, @"Resources\");


                //end

                dgvObjectList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                dgvObjectList.MultiSelect = false;









                btnTrackSlide.PerformClick();
                btnDrawTrack.Enabled = false;
                btnTrackSlide.Enabled = false;



                tbSearch.Enabled = false;


                dgvObjectList.RowHeadersWidth = 25;
                dgvObjectList.RowHeadersVisible = false;
                dgvObjectList.ColumnHeadersVisible = false;
                dgvObjectList.BackgroundColor = Color.FromArgb(255, 255, 255);
                dgvLatLongList.BackgroundColor = Color.FromArgb(255, 255, 255);



                

                string startPath = Application.StartupPath + "\\teltonika_startup.html";
               
                path = Application.StartupPath + "\\teltonika.html";
                path1 = Application.StartupPath + "\\abc.html";
                path_play = Application.StartupPath + "\\track_play.html";
                designBtns();
                webBrowserTrack.Source = new Uri(startPath);
                waitTillLoad_track();


               



                #region clients information


                _ServiceResponse = (new ServiceCaller()).getClientGroupUser_1(1);
                if (_ServiceResponse.ResponseCode == 200)
                {
                    _ServiceResponse.Content = _ServiceResponse.Content.Replace("{\"clients\":", "").Replace("}]}", "}]");
                    var lst = JsonConvert.DeserializeObject<List<ClientInformation>>(_ServiceResponse.Content);


                    cmbClients.DataSource = lst;
                    cmbClients.DisplayMember = "clientName";
                    cmbClients.ValueMember = "clientId";
                    cmbClients.Text = "Please Select Clients";
                    cmbGroups.Text = "Please Select the Groups";
                }
                else
                {
                    MessageBox.Show("Clients loading failed");

                }





                #endregion



            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

        }


        public void timer_Elapsed(object sender, EventArgs e)
        {
           // GetLastEventID();
            if (InvokeRequired)
                Invoke(new MethodInvoker(getAlertAdmin));
            
           //  getAlertAdmin();
            //if (InvokeRequired)
            //    Invoke(new MethodInvoker(innerLoad));
        }






        public void designBtns()
        {




            btnSlide.TabStop = false;
            btnSlide.FlatStyle = FlatStyle.Flat;
            btnSlide.FlatAppearance.BorderSize = 0;
            btnSlide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnSlide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnSlide.TabStop = false;

            btnSlide1.TabStop = false;
            btnSlide1.FlatStyle = FlatStyle.Flat;
            btnSlide1.FlatAppearance.BorderSize = 0;
            btnSlide1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnSlide1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnSlide1.TabStop = false;

            btnTrackSlide.TabStop = false;
            btnTrackSlide.FlatStyle = FlatStyle.Flat;
            btnTrackSlide.FlatAppearance.BorderSize = 0;
            btnTrackSlide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnTrackSlide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnTrackSlide.TabStop = false;

            btnDrawTrack.TabStop = false;
            btnDrawTrack.FlatStyle = FlatStyle.Flat;
            btnDrawTrack.FlatAppearance.BorderSize = 0;
            btnDrawTrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnDrawTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnDrawTrack.TabStop = false;

            

            btnHistory.TabStop = false;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnHistory.TabStop = false;


            btnPlay.TabStop = false;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnPlay.TabStop = false;

            btnFastPlay.TabStop = false;
            btnFastPlay.FlatStyle = FlatStyle.Flat;
            btnFastPlay.FlatAppearance.BorderSize = 0;
            btnFastPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnFastPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnFastPlay.TabStop = false;

            btnSlow.TabStop = false;
            btnSlow.FlatStyle = FlatStyle.Flat;
            btnSlow.FlatAppearance.BorderSize = 0;
            btnSlow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnSlow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnSlow.TabStop = false;

            btnStop.TabStop = false;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnStop.TabStop = false;

            btnSettings.TabStop = false;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnSettings.TabStop = false;

            btnNotification.TabStop = false;
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.FlatAppearance.BorderSize = 0;
            btnNotification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnNotification.TabStop = false;



            btnObjectDetails.TabStop = false;
            btnObjectDetails.FlatStyle = FlatStyle.Flat;
            btnObjectDetails.FlatAppearance.BorderSize = 0;
            btnObjectDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnObjectDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnObjectDetails.TabStop = false;

            btnAppClose.TabStop = false;
            btnAppClose.FlatStyle = FlatStyle.Flat;
            btnAppClose.FlatAppearance.BorderSize = 0;
            btnAppClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnAppClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnAppClose.TabStop = false;
        }





        public void loadObjectListWhenAdminAndPower(int clientId, int groupId)
        {
            label2.Text = "Loading...";

            ApplicationStatics.isReverseGeocoding = "DISABLE";
            
            int state = 1;
            _ServiceResponse = (new ServiceCaller()).getObjectListWhenAdminAndPower(ClientID, groupId, state, ApplicationStatics.isReverseGeocoding);
            if (_ServiceResponse.ResponseCode == 200)
            {
                JsonResult = _ServiceResponse.Content.Replace("{\"landMarks\":", "").Replace("}]}", "}]");



                if (JsonResult.Equals("[]}"))
                {
                    MessageBox.Show("No objects found in this group");

                    label2.Text = "";
                }
                else
                {
                    try
                    {
                        var listClientAndGroups = JsonConvert.DeserializeObject(JsonResult);
                        RawdataTable = JsonConvert.DeserializeObject<DataTable>(JsonResult);


                         view = new DataView(RawdataTable);
                        selected = view.ToTable("Selected", false, "unitId","numberStr", "gpsTime","comment","speed");


                         src = new DataView(selected);

                        dgvObjectList.DataSource = src;
                        dgvObjectList.Columns[1].Visible = false;
                       // dgvObjectList.Columns[5].Visible = false;
                       
                       

                        if (dgvObjectList.Rows.Count != 0 && dgvObjectList.Rows != null)
                        {

                            label2.Text = "";
                        }


                        //2
                      


                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
            else
            {

                MessageBox.Show(_ServiceResponse.ResponseCode.ToString(), "note");

            }

        }



        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region group loading
            btnNotification.Enabled = true;
            label2.Text = "";
            try
            {

                this.cmbClients.DisplayMember = "clientName";
                this.cmbClients.ValueMember = "clientId";
                ClientID = Convert.ToInt32(cmbClients.SelectedValue);



                _ServiceResponse = (new ServiceCaller()).getGroup4AdminRole(ClientID);




                if (_ServiceResponse.ResponseCode == 200)
                {
                    string str = "[{\"groupId\":-0,\"groupName\":\"Please Select Group\",\"clientId\":0,\"clientName\":null}";
                    string str1 = ",{\"groupId\":0,\"groupName\":\"All\",\"clientId\":0,\"clientName\":null},{\"groupId\"";
                    //[{"groupId"
                    _ServiceResponse.Content = _ServiceResponse.Content.Replace("[{\"groupId\"", str + str1);
                    var lstGroups = JsonConvert.DeserializeObject<List<GroupInformation>>(_ServiceResponse.Content);


                    if (cmbClients.SelectedIndex > 0)
                    {

                        dgvObjectList.RowHeadersVisible = true;
                        dgvObjectList.ColumnHeadersVisible = true;

                        cmbGroups.DataSource = lstGroups;

                        cmbGroups.DisplayMember = "groupName";
                        cmbGroups.ValueMember = "groupId";

                        cmbGroups.SelectedIndex = 0;
                    }





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }

            #endregion
            GetLastEventID();
            if (panelPlayButtons.Visible == true)
            {
             Util2.Animate(panelPlayButtons, Util2.Effect.Slide, 150, 90);
            }
           
        }

        public void GetLastEventID()
        {
            try
            {

                _ServiceResponse = (new ServiceCaller()).getEvent_LastId(ClientID);
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
                        lastEventIDAdmin = int.Parse(dataTable_LastEvent.Rows[0].ItemArray[1].ToString());

                        glob.lastEventId = lastEventIDAdmin;
                        glob.clientId = ClientID;
                    }







                    //eventID end
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
       
        }



        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelPlayButtons.Visible == true)
            {
                Util2.Animate(panelPlayButtons, Util2.Effect.Slide, 150, 90);
            }

            label2.Text = "";


            try
            {

                if (cmbGroups.SelectedIndex > 0)
                {

                    gpID = Convert.ToInt32(cmbGroups.SelectedValue);
                    loadObjectListWhenAdminAndPower(ClientID, gpID);

                    glob.groupId = gpID;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

       
       
        private void waitTillLoad_track()
        {
            try
            {

                while (true)
                {

                    if (webBrowserTrack.IsLoading)
                    {
                        label2.Text = "Loading Map...";

                        break;
                    }

                }

                while (true)
                {

                    Application.DoEvents();

                    if (webBrowserTrack.IsLoading == false)
                    {
                        label2.Text = "";
                        break;
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void dgvObjectList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
     
        int id = int.Parse(dgvObjectList.Rows[dgvObjectList.CurrentRow.Index].Cells[1].Value.ToString());
            

        GetObjectCurrentDetails(id, "DISABLE");

        btnDrawTrack.Enabled = true;
        btnTrackSlide.Enabled = true;
        if (panelPlayButtons.Visible == true)
        {
            Util2.Animate(panelPlayButtons, Util2.Effect.Slide, 150, 90);
        }




            //if (panelPlayButtons.Visible == true)
            //{
            //    Util2.Animate(panelPlayButtons, Util2.Effect.Slide, 150, 90);
            //}
            //label2.Text = "";
           
            //string marker = "marker.png";
            //string image = "teltonika.png";
            //XmlDocument doc = new XmlDocument();

            //foreach (DataGridViewRow row in dgvObjectList.SelectedRows)
            //{

            //    latitude = double.Parse(row.Cells[3].Value.ToString());
            //    longtitude = double.Parse(row.Cells[4].Value.ToString());
            //    string devName = row.Cells[6].Value.ToString();
            //    string Time = row.Cells[2].Value.ToString();
            //    string lanmark = row.Cells[3].Value.ToString() + " , " + row.Cells[4].Value.ToString();
            //    string speed = row.Cells[5].Value.ToString();
            //    string addres = "";
                
            //    ObjectID = row.Cells[1].Value.ToString();
            //    //start 0 1 

            //    btnDrawTrack.Enabled = true;
            //    btnTrackSlide.Enabled = true;

            //    try
            //    {
            //        doc.Load("http://maps.googleapis.com/maps/api/geocode/xml?latlng=" + latitude + "," + longtitude + "&sensor=false");
            //        XmlNode element = doc.SelectSingleNode("//GeocodeResponse/status");
            //        if (element.InnerText == "ZERO_RESULTS")
            //        {
            //             MessageBox.Show("No data available for the specified location");
            //        }
            //        else
            //        {

            //            element = doc.SelectSingleNode("//GeocodeResponse/result/formatted_address");

            //            addres = element.InnerText.ToString();

            //        }
            //    }

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    //end






            //    string filename = Application.StartupPath + "\\myteltonika.html";
            //    myMap.replace(filename.ToString().Trim(), latitude.ToString().Trim(), longtitude.ToString().Trim(), marker, image, path, devName, Time, lanmark, speed, addres);
            //    webBrowserTrack.Source = new Uri(path);


            //}








        }

        private void dgvObjectList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvObjectList.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvObjectList.EnableHeadersVisualStyles = false;

            dgvObjectList.Columns[2].HeaderText = "Vehicle";
            dgvObjectList.Columns[3].HeaderText = "Time";
            dgvObjectList.Columns[4].HeaderText = "Comments";
            dgvObjectList.Columns[4].HeaderText = "speed";

            try
            {

                //start
                string appFolderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

                string resourcesFolderPath = Path.Combine(Directory.GetParent(appFolderPath).Parent.FullName, @"Resources\");


                //end


                if (dgvObjectList.Columns[e.ColumnIndex].Name == "speed")
                {
                   // dgvObjectList.Columns[0].Visible = true;
                    if (Convert.ToInt32(this.dgvObjectList.Rows[e.RowIndex].Cells[5].Value) == 0 || Convert.ToInt32(this.dgvObjectList.Rows[e.RowIndex].Cells[5].Value) == 255)
                    {


                        Image image = Image.FromFile(resourcesFolderPath + @"yellow.png");

                        dgvObjectList.Rows[e.RowIndex].Cells[0].Value = image;

                    }

                    else if (Convert.ToInt32(this.dgvObjectList.Rows[e.RowIndex].Cells[5].Value) > 3)
                    {

                        Image image = Image.FromFile(resourcesFolderPath + @"green.png");


                        dgvObjectList.Rows[e.RowIndex].Cells[0].Value = image;

                    }
                    else if (Convert.ToInt32(this.dgvObjectList.Rows[e.RowIndex].Cells[5].Value) <= 3)
                    {


                        Image image = Image.FromFile(resourcesFolderPath + @"red.png");

                        dgvObjectList.Rows[e.RowIndex].Cells[0].Value = image;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


    
        }





        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //numberStr
                string filterField = "numberStr";
                src.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbSearch.Text);


                //string filterField = "numberStr";
                //selected.Select(string.Format("[{0}] LIKE '%{1}%'", filterField, tbSearch.Text));

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {

            //  tbSearch.ForeColor = System.Drawing.Color.MediumBlue;
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            Util.Animate(groupBox1, Util.Effect.Slide, 150, 180);
        }

        private void btnSlide1_Click(object sender, EventArgs e)
        {
            btnSlide.PerformClick();
        }

        private void cmbGroups_Click(object sender, EventArgs e)
        {
            try
            {
                 string appFolderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                string resourcesFolderPath = Path.Combine(Directory.GetParent(appFolderPath).Parent.FullName, @"Resources\");
                string text = System.IO.File.ReadAllText(resourcesFolderPath + "defaultValues.txt");

                string[] def = text.Split(',');
                tbSearch.Enabled = true;
                if (def[0] == "on")
                {
                   

                    System.Timers.Timer timer = new System.Timers.Timer();
                    timer.Interval = int.Parse(def[1]);
                    timer.Elapsed += timer_Elapsed;
                    timer.Start(); 
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }


        }


        public void innerLoad()
        {
            try
            {
                string result = this.dgvObjectList.CurrentCell.Value.ToString();



                GetObjectCurrentDetails(int.Parse(result), "DISABLE");
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnTrackSlide_Click(object sender, EventArgs e)
        {
            Util1.Animate(panelTrack, Util1.Effect.Slide, 150, 180);
            //  webBrowserTrack.SendToBack();
        }

        private void btnDrawTrack_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvObjectList.Rows[dgvObjectList.CurrentRow.Index].Cells[1].Value.ToString();
                label2.Text = "Loading...";
                if (mCalTripRange.SelectionRange.Start.ToString() != DateTime.Today.ToString())
                {
                    loadtrackhistory(int.Parse(id.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.Start.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.End.ToString()));

                    string filename = Application.StartupPath + "\\myabc.html";
                    myMap.replace1(filename.ToString().Trim(), trackPath.ToString().Trim(), path1, trackLon.ToString(), trackLat.ToString());
                    webBrowserTrack.Source = new Uri(path1);
                    waitTillLoad_track();
                    label2.Text = "";
                }
                else
                {

                    MessageBox.Show("You must select a date first!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }





        public void loadtrackhistory(int unitid, DateTime datefrom, DateTime dateto)
        {
            try
            {

                _ServiceResponse = (new ServiceCaller()).gettrackhistory(unitid, datefrom.ToString(), dateto.ToString());
                if (_ServiceResponse.ResponseCode == 200)
                {

                    JsonResult = _ServiceResponse.Content.Replace("{\"messages\":", "").Replace("}]}", "}]");

                    if (JsonResult.Equals("[]}"))
                    {
                        MessageBox.Show("No data Found");
                    }
                    else
                    {

                        // var trackData = JsonConvert.DeserializeObject(JsonResult);
                        DataTable dataTable_Track = JsonConvert.DeserializeObject<DataTable>(JsonResult);

                        dgvLatLongList.DataSource = dataTable_Track;


                        trackLat = dataTable_Track.Rows[0].ItemArray[1].ToString();
                        trackLon = dataTable_Track.Rows[0].ItemArray[2].ToString();

                        string[] arr = new string[dataTable_Track.Rows.Count];


                        for (int i = 0; i < dataTable_Track.Rows.Count; i++)
                        {

                            if (i == 0)
                            {
                                arr[i] = "[{lat: " + dataTable_Track.Rows[i]["Y"].ToString() + ", lng: " + dataTable_Track.Rows[i]["X"].ToString() + "},";

                            }
                            else if (i == dataTable_Track.Rows.Count - 1)
                            {
                                arr[i] = "{lat: " + dataTable_Track.Rows[i]["Y"].ToString() + ", lng: " + dataTable_Track.Rows[i]["X"].ToString() + "}]";
                            }
                            else

                                arr[i] = "{lat: " + dataTable_Track.Rows[i]["Y"].ToString() + ", lng: " + dataTable_Track.Rows[i]["X"].ToString() + "},";

                        }

                        trackPath = string.Join("", arr);



                        // start
                        //[
                        //  {lat: 37.772, lng: -122.214},
                        //  {lat: 21.291, lng: -157.821},
                        //  {lat: -18.142, lng: 178.431},
                        //  {lat: -27.467, lng: 153.027}
                        //];  end

                    }
                }
                else
                {

                    MessageBox.Show(_ServiceResponse.ResponseCode.ToString(), "note");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       




        public void getAlertAdmin()
        {
            try
            {
                

                _ServiceResponse = (new ServiceCaller()).getLastEventAdmin(ClientID, lastEventIDAdmin);
                if (_ServiceResponse.ResponseCode == 200)
                {

                    //   string testString = "{\"table\":[{\"messageId\":921550269,\"objectId\":7203,\"altitude\":1011,\"gpsTime\":\"2016-08-22T10:15:55\",\"x\":71.8688911,\"y\":34.7709591,\"vectorAngle\":41,\"vectorSpeed\":0,\"visibleSatelites\":11},{\"messageId\":921550270,\"objectId\":7203,\"altitude\":1010,\"gpsTime\":\"2016-08-22T10:15:48\",\"x\":71.8688911,\"y\":34.7709591,\"vectorAngle\":41,\"vectorSpeed\":0,\"visibleSatelites\":10}],\"table1\":[{\"messageId\":921550270,\"eventLogId\":23662101,\"low\":9.0,\"high\":16.0,\"units\":\"V\",\"format\":\"0.0\",\"name\":\"Power Voltage\",\"value\":8.997,\"vectorSpeed\":0,\"loginId\":null,\"username\":null,\"vectorAngle\":41},{\"messageId\":921550269,\"eventLogId\":23662100,\"low\":9.0,\"high\":16.0,\"units\":\"V\",\"format\":\"0.0\",\"name\":\"Power\",\"value\":8.996,\"vectorSpeed\":0,\"loginId\":null,\"username\":null,\"vectorAngle\":41}],\"table2\":[{\"objectId\":7203,\"number\":\"LRL-7151\"}],\"table3\":[]}";
                    //  string abc = "adfdasffsd"";

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
                            dt.Columns.Add("object ID", typeof(Int64));
                            dt.Columns.Add("Message ID", typeof(Int64));
                        }


                        //  clearArrays();

                        //if (dataTable0 != null)
                        //{
                        //    dataSet.Clear();
                        //}
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
                                          messageId = (Int64)table1["messageId"],
                                          objectId = (Int64)table1["objectId"],
                                          number = (string)table3["number"],
                                          name = (string)table2["name"]
                                      };

                        int indx = 0;


                        foreach (var item in results)
                        {



                            dt.Rows.Add(item.name, item.number, item.objectId, item.messageId);
                            //   dt.Rows.Add(item.name);




                            indx += 1;



                        }


                        



                        //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        //notifyIcon1.BalloonTipText = "Alert: Click to open";
                        //notifyIcon1.BalloonTipTitle = "T A V L";
                        //notifyIcon1.ShowBalloonTip(500);



                        //start


                        //DataRow[] rows = dt.Select();
                        //for (int i = 0; i < dt.Rows.Count; i++)
                        //{
                        //    listViewNotification.Items.Add(dt.Rows[i]["Alert Name"].ToString());
                        //}


                        //end
                        if (label1.Visible == false)
                        {

                            slide.PerformClick();

                            System.Timers.Timer tmr = new System.Timers.Timer();
                            tmr.Interval = 3000;
                            tmr.Elapsed += timer_Elap_notif;
                            tmr.Start(); 



                        }



                    }


                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

        }
        public void timer_Elap_notif(object sender, EventArgs e)
        {
            if (label1.Visible == true)
            {
                if (InvokeRequired)
                    Invoke(new MethodInvoker(slide.PerformClick));



               // slide.PerformClick();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {


        }




        private void listViewNotification_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //try
            //{

            //    string curItem;

            //    curItem = listViewNotification.SelectedItem.ToString();


            //    if (curItem != "")
            //    {


            //        listViewNotificationDetails.Items.Clear();
            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {

            //            if (curItem.Trim() == dt.Rows[i]["Alert Name"].ToString())
            //            {

            //                listViewNotificationDetails.Items.Add("                            " + dt.Rows[i]["Alert Name"].ToString());
            //                listViewNotificationDetails.Items.Add("Object Name: " + dt.Rows[i]["Object Name"].ToString());
            //                listViewNotificationDetails.Items.Add("Object ID: " + dt.Rows[i]["object ID"].ToString());
            //                listViewNotificationDetails.Items.Add("Message ID: " + dt.Rows[i]["Message ID"].ToString());



            //                break;

            //            }

            //        }
            //    }







            //}
            //catch (Exception ex)
            //{
                
            //   MessageBox.Show(ex.Message);
            //}

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {


        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            GetLastEventID();
            clearArrays();
        }

        public void clearArrays()
        {
            if (dt.Rows.Count > 0)
            {

                dt.Clear();

              //  listViewNotification.Items.Clear();
              //  listViewNotificationDetails.Clear();

                //if (dataTable0 != null)
                //{
                //    dataSet.Reset();
                //}




            }


        }
        public void getlogHistory(int unitid, DateTime datefrom, DateTime dateto)
        {

            try
            {

                _ServiceResponse = (new ServiceCaller()).getEventLoghistory(unitid, datefrom.ToString(), dateto.ToString());
                if (_ServiceResponse.ResponseCode == 200)
                {

                    //   string testString = "{\"table\":[{\"messageId\":921550269,\"objectId\":7203,\"altitude\":1011,\"gpsTime\":\"2016-08-22T10:15:55\",\"x\":71.8688911,\"y\":34.7709591,\"vectorAngle\":41,\"vectorSpeed\":0,\"visibleSatelites\":11},{\"messageId\":921550270,\"objectId\":7203,\"altitude\":1010,\"gpsTime\":\"2016-08-22T10:15:48\",\"x\":71.8688911,\"y\":34.7709591,\"vectorAngle\":41,\"vectorSpeed\":0,\"visibleSatelites\":10}],\"table1\":[{\"messageId\":921550270,\"eventLogId\":23662101,\"low\":9.0,\"high\":16.0,\"units\":\"V\",\"format\":\"0.0\",\"name\":\"Power Voltage\",\"value\":8.997,\"vectorSpeed\":0,\"loginId\":null,\"username\":null,\"vectorAngle\":41},{\"messageId\":921550269,\"eventLogId\":23662100,\"low\":9.0,\"high\":16.0,\"units\":\"V\",\"format\":\"0.0\",\"name\":\"Power\",\"value\":8.996,\"vectorSpeed\":0,\"loginId\":null,\"username\":null,\"vectorAngle\":41}],\"table2\":[{\"objectId\":7203,\"number\":\"LRL-7151\"}],\"table3\":[]}";
                    //  string abc = "adfdasffsd"";

                    string JsonHistory = _ServiceResponse.Content.ToString();


                    if (JsonHistory.Equals("{\"table\":[],\"table1\":[],\"table2\":[],\"table3\":[]}"))
                    //   if (JsonHistory.Equals("{\"tatab"))
                    {
                        MessageBox.Show("No event history Found");
                    }
                    else
                    {
                        dataTable_eventHistory = JsonConvert.DeserializeObject<DataTable>(JsonHistory);
                        dataTable_eventHistory.Columns.Add("Time", typeof(String));




                        foreach (DataRow dr in dataTable_eventHistory.Rows)
                        {
                            // 
                            dr["Time"] = DateTime.Parse((dr["gpsTime"].ToString())).ToLongTimeString();
                            dr["gpsTime"] = DateTime.Parse((dr["gpsTime"].ToString())).ToShortDateString();
                        }

                        dgvLatLongList.DataSource = dataTable_eventHistory;
                        dgvLatLongList.Columns["alertName"].HeaderText = "Alert";
                        dgvLatLongList.Columns["gpsTime"].HeaderText = "Date";



                        for (int i = 0; i < dataTable_eventHistory.Columns.Count; i++)
                        {
                            dgvLatLongList.Columns[i].Visible = false;

                        }
                        dgvLatLongList.Columns["alertName"].Visible = true;
                        dgvLatLongList.Columns["gpsTime"].Visible = true;
                        dgvLatLongList.Columns["Time"].Visible = true;
                        dgvLatLongList.Columns["alertName"].DisplayIndex = 0;


                    }
                }
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            string id = dgvObjectList.Rows[dgvObjectList.CurrentRow.Index].Cells[1].Value.ToString();
            label2.Text = "";
            try
            {
                if (mCalTripRange.SelectionRange.Start.ToString() != DateTime.Today.ToString())
                {
                    getlogHistory(int.Parse(id.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.Start.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.End.ToString()));
                }
                else
                {
                    MessageBox.Show("You must select a date first!");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // trkPlayPath


            try
            {
                panelPlayButtons.BringToFront();
                Util2.Animate(panelPlayButtons, Util2.Effect.Slide, 150, 90);
                //loadtrackhistory(int.Parse(ObjectID.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.Start.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.End.ToString()));

                //string filename = Application.StartupPath + "\\track_play_MyTrack.html";
                //myMap.replacePlayPath(filename.ToString().Trim(), trackPath.ToString().Trim(), path_play);
                //webBrowserTrack.Source = new Uri(path_play);
                //waitTillLoad_track();
                //label2.Text = "Playing Track";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

     





       

       

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
            
        }

        private void slide_Click(object sender, EventArgs e)
        {
            Util2.Animate(label1, Util2.Effect.Slide, 150, 90);
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvObjectList.Rows[dgvObjectList.CurrentRow.Index].Cells[1].Value.ToString();
                int speed = 100;
                if (mCalTripRange.SelectionRange.Start.ToString() != DateTime.Today.ToString())
                {
                    loadtrackhistory(int.Parse(id.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.Start.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.End.ToString()));

                    string filename = Application.StartupPath + "\\track_play_MyTrack.html";
                    myMap.replacePlayPath(filename.ToString().Trim(), trackPath.ToString().Trim(), path_play, speed);
                    webBrowserTrack.Source = new Uri(path_play);
                    waitTillLoad_track();
                    label2.Text = "Playing Track";
                }
                else
                {
                    MessageBox.Show("You must select a date first!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string startPath = Application.StartupPath + "\\teltonika_startup.html";
            webBrowserTrack.Source = new Uri(startPath);
            waitTillLoad_track();
        }

        private void btnFastPlay_Click(object sender, EventArgs e)
        {
            try
            {//Date = {10/14/2016 12:00:00 AM}
                string id = dgvObjectList.Rows[dgvObjectList.CurrentRow.Index].Cells[1].Value.ToString();
                if (mCalTripRange.SelectionRange.Start.ToString() != DateTime.Today.ToString())
                {

                    int speed = 30;
                    loadtrackhistory(int.Parse(id.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.Start.ToString()), DateTime.Parse(mCalTripRange.SelectionRange.End.ToString()));
                    string filename = Application.StartupPath + "\\track_play_MyTrack.html";
                    myMap.replacePlayPath(filename.ToString().Trim(), trackPath.ToString().Trim(), path_play, speed);
                    webBrowserTrack.Source = new Uri(path_play);
                    waitTillLoad_track();
                    label2.Text = "Playing Track";
                }
                else
                {
                    MessageBox.Show("You must select a date first!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            Notifications n = new Notifications();
            n.Show();
        }

        public void GetObjectCurrentDetails(int objectID, string isReverseGeoCoding)
        {
            label2.Text = "Loading...";

            ApplicationStatics.isReverseGeocoding = "DISABLE";


            _ServiceResponse = (new ServiceCaller()).getObjectListDetailsWhenAdminAndPower(objectID, isReverseGeoCoding);
            if (_ServiceResponse.ResponseCode == 200)
            {
               string Result = _ServiceResponse.Content.Replace("{\"landMarks\":", "").Replace("}]}", "}]");


              
                if (Result.Equals("[]}"))
                {
                    MessageBox.Show("No Data Found");

                    
                }

                label2.Text = "";
               // var listClientAndGroups = JsonConvert.DeserializeObject(Result);
               DataTable dtable = JsonConvert.DeserializeObject<DataTable>(Result);
            //    [{"1number":0,"2unitId":7275,"3messageId":977681769,"4gpsTime":"2016-10-21T17:37:11","5landMarksValue":"71.8906936, 34.0093296",
           //     "6latitude":34.0093296,"7longitude":71.8906936,"8angle":128,"9speed":6,"10satellites":20,"11numberStr":"EA-3433","12clientName":"13Arrow Track",
           //     "14groupName":"N/A","15comment":"Momin Psh"}]


              
               listViewObjectDetails.Items.Clear();
               listViewObjectDetails.Items.Add("Vehicle Name").SubItems.AddRange(new string[] {dtable.Rows[0].ItemArray[10].ToString()});
               listViewObjectDetails.Items.Add("Comments").SubItems.AddRange(new string[] { dtable.Rows[0].ItemArray[13].ToString() });
               listViewObjectDetails.Items.Add("Client Name").SubItems.AddRange(new string[] { dtable.Rows[0].ItemArray[11].ToString() });
               listViewObjectDetails.Items.Add("Landmarks").SubItems.AddRange(new string[] { dtable.Rows[0].ItemArray[4].ToString() });
               listViewObjectDetails.Items.Add("Last Updated").SubItems.AddRange(new string[] { dtable.Rows[0].ItemArray[3].ToString() });
               listViewObjectDetails.Items.Add("Speed").SubItems.AddRange(new string[] { dtable.Rows[0].ItemArray[8].ToString() });
               listViewObjectDetails.Items.Add("Angle").SubItems.AddRange(new string[] { dtable.Rows[0].ItemArray[7].ToString() });
               listViewObjectDetails.Items.Add("Satellites").SubItems.AddRange(new string[] { dtable.Rows[0].ItemArray[9].ToString() });
              
               btnObjectDetails.Enabled = true;

               listViewObjectDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
               listViewObjectDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
               listViewObjectDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
               listViewObjectDetails.Left = (this.ClientSize.Width - listViewObjectDetails.Width) / 2;
               listViewObjectDetails.Top = (this.ClientSize.Height - listViewObjectDetails.Height) / 2;


                 string marker = "marker.png";
            string image = "teltonika.png";
                string addres = "Not Found";
            XmlDocument doc = new XmlDocument();

               foreach (DataRow row in dtable.Rows)
               {
                   string objName = row["numberStr"].ToString();
                   string gpsTime = row["gpsTime"].ToString();
                   string clientName = row["clientName"].ToString();
                   string landMarks = row["landMarksValue"].ToString();
                     string lat = row["latitude"].ToString();
                   string lon = row["longitude"].ToString();
                   string speed = row["speed"].ToString();





                    try
                {
                    doc.Load("http://maps.googleapis.com/maps/api/geocode/xml?latlng=" + lat + "," + lon + "&sensor=false");
                    XmlNode element = doc.SelectSingleNode("//GeocodeResponse/status");
                    if (element.InnerText == "ZERO_RESULTS")
                    {
                         MessageBox.Show("No data available for the specified location");
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






                string filename = Application.StartupPath + "\\myteltonika.html";
                myMap.replace(filename.ToString().Trim(), lat.ToString().Trim(), lon.ToString().Trim(), marker, image, path, objName, gpsTime, landMarks, speed, addres);
                webBrowserTrack.Source = new Uri(path);


            }







               }



        }

        private void btnObjectDetails_Click(object sender, EventArgs e)
        {
            if (listViewObjectDetails.Visible == false)
            {
                listViewObjectDetails.Show();
            }
            else
                listViewObjectDetails.Hide();
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        }

    }

//if (Convert.ToInt32(this.dgvObjectList.Rows[e.RowIndex].Cells[8].Value) >3)
//{
//    string appFolderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

//    string resourcesFolderPath = Path.Combine(
//    Directory.GetParent(appFolderPath).Parent.FullName, @"Resources\");
 // Image image = Image.FromFile(@"C:\Users\Zeeshan\Documents\Visual Studio 2013\Projects\Tracking Objects\Tracking Objects\Resources\red.png");

             //       Bitmap bmd = new Bitmap(@"C:\Users\Zeeshan\Documents\Visual Studio 2013\Projects\Tracking Objects\Tracking Objects\Resources\red.png");
            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            //img.Name = "img";
            //img.HeaderText = "Image Column";
            //img.ValuesAreIcons = true;
            //dgvObjectList.Columns.Add(img);     

//[{"number":0,"unitId":7042,"messageId":905059885,"gpsTime":"2016-08-05T15:25:49","landMarksValue":"24.9202, 67.0234333","latitude":24.9202,"longitude":67.0234333,"angle":49,"speed":10,"satellites":7,"numberStr":"JY-2532","clientName":null,"groupName":null,"altitude":25},


 //String searchValue = tbSearch.Text.Trim();
 //           int rowIndex = -1;
 //           foreach (DataGridViewRow row in dgvObjectList.Rows)
 //           {
 //               if (row.Cells["speed"].Value != null) // Need to check for null if new row is exposed
 //               {

 //                   if (row.Cells["speed"].Value.ToString().Contains(searchValue.ToString().Trim()))
 //                   {
 //                       rowIndex = row.Index;

 //                    //   row.Visible = false;
 //                       row.Height = 0;
 //                   }

 //               }
 //           }



//for (int i = 0; i < arr_name.Length; i++)
//{
//    if (txt ==  "Alert: " + arr_name[i].ToString())
//    {
//          listViewNotificationDetails.Items.Add("                      " + arr_name[i].ToString());
//        listViewNotificationDetails.Items.Add("Object Name: " + arr_number[i].ToString());
//        listViewNotificationDetails.Items.Add("Object ID: " + arr_objectID[i].ToString());
//        listViewNotificationDetails.Items.Add("Message ID: " + arr_msgID[i].ToString());


//    } 
//}

//if (arr_name != null)
//            {
//                Array.Clear(arr_msgID, arr_msgID.Length, dataTable0.Rows.Count);
//                Array.Clear(arr_objectID, arr_objectID.Length, dataTable0.Rows.Count);
//                Array.Clear(arr_number, arr_number.Length, dataTable0.Rows.Count);
//                Array.Clear(arr_name, arr_name.Length, dataTable0.Rows.Count);
//            }