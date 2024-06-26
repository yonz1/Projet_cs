﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices.WindowsRuntime;



namespace Projet_cs
{
    public partial class SQLite_console : Form
    {
        public SQLite_console()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string query_e = textbox_entry.Text;
            textbox_entry.Clear();
            readdb(query_e);

        }
        public void run_cmd(object command)
        {
            System.Diagnostics.ProcessStartInfo procstatinfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + command);
            procstatinfo.UseShellExecute = false;
            procstatinfo.CreateNoWindow = true;
            procstatinfo.RedirectStandardOutput = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procstatinfo;
            proc.Start();
            proc.WaitForExit();
        }
        private void readdb(string query_i)
        {
            string conSource = "Data Source=..\\..\\result2.db";
            var connection = new SQLiteConnection(conSource);
            connection.Open();
            string query = query_i;
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            string rtot = null;
            while (reader.Read())
            {
                //listbox_display.Items.Add(reader.FieldCount);
                rtot = null;
                for (int y = 0; y < reader.FieldCount; y++)
                {
                    string myread = reader.GetString(y);
                    rtot = rtot + "|" + myread + "\n";
                }
                listbox_display.Items.Add(rtot);
            }
            connection.Close();
        }

        private void SQLite_console_Load(object sender, EventArgs e)
        {

        }
    }

}
