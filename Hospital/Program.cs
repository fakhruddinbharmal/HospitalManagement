using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Win32;
using Hospital.Object;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connStr = ConfigurationManager.ConnectionStrings["AppDBConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            int period = 60; // trial period//60
            //string keyName = "HospitalRegistry";
            string keyName = "HospitalRegistryNew";
            long ticks = DateTime.Today.Ticks;

            RegistryKey rootKey = Registry.CurrentUser;
            RegistryKey regKey = rootKey.OpenSubKey(keyName);
            if (regKey == null) // first time app has been used
            {
                regKey = rootKey.CreateSubKey(keyName);
                long expiry = DateTime.Today.AddDays(period).Ticks;
                regKey.SetValue("expiry", expiry, RegistryValueKind.QWord);
                regKey.Close();
            }
            //else
            //{
            //    long expiry = (long)regKey.GetValue("expiry");
            //    regKey.Close();
            //    //long expiry = DateTime.Today.AddDays(60).Ticks; my
            //    long today = DateTime.Today.Ticks;
            //    if (today > expiry)
            //    {
            //        SqlCommand cmd = new SqlCommand("Update tblApplicationStatus set AppStatus=0", con);
            //        con.Open();
            //        cmd.ExecuteReader();
            //        con.Close();
            //        MessageBox.Show("Your free trial has expired.");
            //        return;
            //    }
            //}
            SqlCommand cmd2 = new SqlCommand("SELECT AppStatus FROM tblApplicationStatus", con);
            con.Open();
            var status = cmd2.ExecuteScalar();
            con.Close();
            if (string.Equals(status.ToString(),"true",StringComparison.InvariantCultureIgnoreCase))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new MainForm());
            }
            //else
            //{
            //    MessageBox.Show("Your free trial has expired.");
            //    return;
            //}
           
        }
    }
}
