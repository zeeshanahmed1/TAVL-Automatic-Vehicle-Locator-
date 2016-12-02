using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Tracking_Objects
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            
            double ms = 0.0;
            string notifSwitch = "on";
            if (tbNotifTime.Text == "")
            {
               
                ms = 15000;
            }
                else 
            {
              
                ms = double.Parse(tbNotifTime.Text.Trim()) * 1000;
            }
            if(rdbOn.Checked == false)
            {
                notifSwitch = "off";

            }
           
           



            string appFolderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            string resourcesFolderPath = Path.Combine(Directory.GetParent(appFolderPath).Parent.FullName, @"Resources\");



            string text = notifSwitch + ',' + ms;
            File.WriteAllText(resourcesFolderPath + "defaultValues.txt", string.Empty);
            File.AppendAllText(resourcesFolderPath + "defaultValues.txt", text);
           
            MessageBox.Show("Settings Saved Successfully","Settings");
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
