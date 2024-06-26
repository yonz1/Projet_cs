﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
//using System.Windows.Media;
using FontAwesome.Sharp;

namespace Projet_cs
{
    public partial class Form1 : Form
    {
        private IconButton currentbtn;
        private Panel leftBoderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, Dashboard.Size.Height);
            panelMenu.Controls.Add(leftBoderBtn);
            timer1.Start();
            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        // Struct

        private struct RGBColors
        {
            public static Color color = Color.FromArgb(172, 126, 241);
            public static Color color1 = Color.FromArgb(249, 118, 176);
            public static Color color2 = Color.FromArgb(253, 138, 114);
            public static Color color3 = Color.FromArgb(95, 77, 221);
            public static Color color4 = Color.FromArgb(249, 88, 155);
            public static Color color5 = Color.FromArgb(24, 161, 251);
            public static Color color6 = Color.FromArgb(0, 74, 122);
            
        }



        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null) {
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                // Left border button
                leftBoderBtn.BackColor = color;
                leftBoderBtn.Location = new Point(0, currentbtn.Location.Y);
                leftBoderBtn.Visible = true;
                leftBoderBtn.BringToFront();
                // Icon Current Child Form
                Homebtn.IconChar = currentbtn.IconChar;
                Homebtn.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(31, 30, 68);
                currentbtn.ForeColor = Color.FromArgb(220, 220, 220);
                currentbtn.IconColor = Color.FromArgb(220, 220, 220);
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new FormDashboard());
            Homebtn.Text = "Dashboard";
        }

        private void SQLite_console_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new SQLite_console());
            Homebtn.Text = "SQLite console";
        }

        private void Imported_Scan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new ScanImported());
            Homebtn.Text = "Imported scan";
        }

        private void Memory_Scan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormMemory());
            Homebtn.Text = "Memory scan";
        }

        private void Pre_defined_Scan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormPre_defined());
            Homebtn.Text = "Pre-defined scan";
        }

        private void About_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormAbout());
            Homebtn.Text = "About";
        }
        private void Reset()
        {
            DisableButton();
            leftBoderBtn.Visible = false;
            Homebtn.IconChar = IconChar.House;
            Homebtn.IconColor = RGBColors.color;
            Homebtn.Text = "Home";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);


        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Icon_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Icon_maximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal) { 
                this.WindowState = FormWindowState.Maximized;   
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Homebtn_Click_1(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_rules_button(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Form_add_rules());
            Homebtn.Text = "Add Rules";
        }
    }
}
