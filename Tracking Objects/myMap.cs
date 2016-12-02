using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracking_Objects
{
    class myMap
    {
        public static void replace(string filename, string la, string lo, string marker, string image, string path, string devName, string gpsTime,string landmark,string speed,string address)
        {
            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);
                string readFile = reader.ReadToEnd();
                string htmlCode = "";
                htmlCode = readFile;
                htmlCode = htmlCode.Replace("[la]", la);
                htmlCode = htmlCode.Replace("[lo]", lo);
            htmlCode = htmlCode.Replace("[deviceName]", devName);
            htmlCode = htmlCode.Replace("[gpsTime]", gpsTime);
                htmlCode = htmlCode.Replace("[image]", image);
                htmlCode = htmlCode.Replace("[marker]", marker);


                htmlCode = htmlCode.Replace("[landMark]", landmark);
                htmlCode = htmlCode.Replace("[speed]", speed.ToString());
                htmlCode = htmlCode.Replace("[address]", address.ToString());


                readFile = htmlCode.ToString();
                reader.Close();
                StreamWriter writer = new StreamWriter(path);
                writer.Write(readFile);
                writer.Close();

                writer = null;
                reader = null;
            }
            else
                System.Windows.Forms.MessageBox.Show("Error");
        }






        public static void replace1(string filename, string res, string path, string lat, string lon)
        {
            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);
                string readFile = reader.ReadToEnd();
                string htmlCode = "";
                htmlCode = readFile;
                htmlCode = htmlCode.Replace("[trkRes]", res);
                htmlCode = htmlCode.Replace("[la]", lat);
                htmlCode = htmlCode.Replace("[lo]", lon);


                readFile = htmlCode.ToString();
                reader.Close();
                StreamWriter writer = new StreamWriter(path);
                writer.Write(readFile);
                writer.Close();

                writer = null;
                reader = null;
            }
            else
                System.Windows.Forms.MessageBox.Show("Error");
        }







        public static void replacePlayPath(string filename, string res, string path, int playSpeed)
        {
            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);
                string readFile = reader.ReadToEnd();
                string htmlCode = "";
                htmlCode = readFile;
                htmlCode = htmlCode.Replace("[trkPlayPath]", res);
                htmlCode = htmlCode.Replace("[speed]", playSpeed.ToString());


                readFile = htmlCode.ToString();
                reader.Close();
                StreamWriter writer = new StreamWriter(path);
                writer.Write(readFile);
                writer.Close();

                writer = null;
                reader = null;
            }
            else
                System.Windows.Forms.MessageBox.Show("Error");
        }





        public static void replaceNotif(string filename, string latLong, string marker, string image, string path, string devName, string gpsTime, string landmark, string address)
        {
            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);
                string readFile = reader.ReadToEnd();
                string htmlCode = "";
                htmlCode = readFile;
                htmlCode = htmlCode.Replace("[latlong]", latLong);
              //  htmlCode = htmlCode.Replace("[lo]", lo);
                htmlCode = htmlCode.Replace("[deviceName]", devName);
                htmlCode = htmlCode.Replace("[gpsTime]", gpsTime);
                htmlCode = htmlCode.Replace("[image]", image);
                htmlCode = htmlCode.Replace("[marker]", marker);


                htmlCode = htmlCode.Replace("[landMark]", landmark);
               // htmlCode = htmlCode.Replace("[speed]", speed.ToString());
                htmlCode = htmlCode.Replace("[address]", address.ToString());


                readFile = htmlCode.ToString();
                reader.Close();
                StreamWriter writer = new StreamWriter(path);
                writer.Write(readFile);
                writer.Close();

                writer = null;
                reader = null;
            }
            else
                System.Windows.Forms.MessageBox.Show("Error");
        }





    }
}

   