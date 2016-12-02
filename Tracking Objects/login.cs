using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using System.IO;

namespace Tracking_Objects
{
    public partial class login : Form
    {
     //   public string login;
        private readonly log4net.ILog _log = LogManager.GetLogger(typeof(Form_Map));
        public login()
        {
            InitializeComponent();

           
        }

        private void login_Load(object sender, EventArgs e)
        {

            pictureBox1.BorderStyle = BorderStyle.None;

            btnLogin.TabStop = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnLogin.TabStop = false;


          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            glob.logId = tbUserName.Text.Trim();
            ApplicationStatics.UserName = tbUserName.Text.Trim();
            ApplicationStatics.SecretKey = (new HttpCaller()).GetUserSecret(tbPassword.Text.Trim());
            ApplicationStatics.ServiceIPAddress = "http://" + tbServiceIP.Text.Trim()+ "/";
            ApplicationStatics.ClientCode = tbClientCode.Text.Trim();



            #region user login



             
             ServiceResponse _ServiceResponse = (new ServiceCaller()).getUserInforamtion(_log);
            if (_ServiceResponse.ResponseCode == 200)
            {

                ApplicationStatics._UserInforamtion = JsonConvert.DeserializeObject<UserInformation>(_ServiceResponse.Content);
    
                Form_Map fm = new Form_Map();
                this.Hide();
                AutoClosingMessageBox.Show("Welcome to TAVL Desktop App", "TAVL", 800);
                fm.Show();


              
               
               
            }
            else
            {
                MessageBox.Show("login failed");
        
            }

            #endregion
        
        
        
        
        
        }
    }

    
}
