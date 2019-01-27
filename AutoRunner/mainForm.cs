using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AutoRunner
{
    public partial class mainForm : Form
    {
        private Point MouseDownLocation;
        private string runMap = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        private int number;

        public mainForm()
        {
            InitializeComponent();
            if (!File.Exists("links.txt"))
            {
                using (var tw = new StreamWriter("links.txt", true))
                hideMainPl.Visible = true;
                txtCreateLb.Visible = true;
                txtInfoLb.Visible = true;
                txtOkBtn.Visible = true;
            }

            List<string> links = File.ReadAllLines("links.txt").ToList();

            if (links.Count == 0)
            {
                runOnBtn.Enabled = false;
                runOffBtn.Enabled = false;
                picError.Visible = true;
                statusLb.Text = "No Links Found";
            }
        }

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
                statusLb.Text = "ERROR 0x1";
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
                statusLb.Text = "ERROR 0x2";
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
                statusLb.Text = "ERROR 0x3";
            }
        }

        //For editing the link files.
        private void editLinksBtn_Click(object sender, EventArgs e)
        {
            linkAddForm linkForm = new linkAddForm();
            this.Hide();
            linkForm.Show();
        }

        //For closing the txt info box
        private void txtOkBtn_Click(object sender, EventArgs e)
        {
            hideMainPl.Visible = false;
            txtCreateLb.Visible = false;
            txtInfoLb.Visible = false;
            txtOkBtn.Visible = false;
        }

        //For showing credits.
        private void creditsBtn_Click(object sender, EventArgs e)
        {
            hideMainPl.Visible = true;
            myNameLb.Visible = true;
            progInfoLb.Visible = true;
            closeCreditsBtn.Visible = true;
        }

        //For closing credits.
        private void closeCreditsBtn_Click(object sender, EventArgs e)
        {
            hideMainPl.Visible = false;
            myNameLb.Visible = false;
            progInfoLb.Visible = false;
            closeCreditsBtn.Visible = false;
        }

        //For close button in de bar.
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
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
