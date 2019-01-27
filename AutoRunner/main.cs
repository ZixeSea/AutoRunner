using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AutoRunner
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private Point MouseDownLocation;
        private string runMap = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        private int number;

        //For turning on the run.
        private void runOnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                number = 1;
                List<string> links = File.ReadAllLines("links.txt").ToList();

                foreach (string link in links)
                {
                    using (StreamWriter writer = new StreamWriter(runMap + "\\AutoRunLink" + number + ".url"))
                    {
                        writer.WriteLine("[InternetShortcut]");
                        writer.WriteLine("URL=" + link);
                        writer.Flush();
                    }
                    number++;
                }

                picUnchecked.Visible = false;
                picError.Visible = false;
                picChecked.Visible = true;
                statusLb.Text = "Run Created";
            }
            catch (Exception)
            {
                picUnchecked.Visible = false;
                picChecked.Visible = false;
                picError.Visible = true;
                statusLb.Text = "ERROR";
            }
        }

        //For turning off the run.
        private void runOffBtn_Click(object sender, EventArgs e)
        {
            try
            {
                number = 1;
                while (File.Exists(runMap + "\\AutoRunLink" + number + ".url"))
                {
                    File.Delete(runMap + "\\AutoRunLink" + number + ".url");
                    number++;
                }

                picChecked.Visible = false;
                picError.Visible = false;
                picUnchecked.Visible = true;
                statusLb.Text = "Run Deleted";
            }
            catch (Exception)
            {
                picUnchecked.Visible = false;
                picChecked.Visible = false;
                picError.Visible = true;
                statusLb.Text = "ERROR";
            }
        }

        //For opening the run map.
        private void runOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(runMap);
            }
            catch (Exception)
            {
                picUnchecked.Visible = false;
                picChecked.Visible = false;
                picError.Visible = true;
                statusLb.Text = "ERROR";
            }
        }

        //For close button in de bar.
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //For moving the window with the top bar en label.
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void appName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void appName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }
    }
}
