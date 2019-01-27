using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AutoRunner
{
    public partial class linkAddForm : Form
    {
        private Point MouseDownLocation;
        private int amountLinks;

        public linkAddForm()
        {
            InitializeComponent();

            List<string> links = File.ReadAllLines("links.txt").ToList();

            foreach (string link in links)
            {
                listLinkBox.Items.Add(link);
                amountLinks++;
            }

            appName.Text = "AutoRunner Link Editer (" + amountLinks + " Links Found)";
        }

        //For adding a link.
        private void addLinkBtn_Click(object sender, EventArgs e)
        {
            if (addLinkBox.Text != "")
            {
                try
                {
                    List<string> linesList = File.ReadAllLines("links.txt").ToList();
                    linesList.Add(addLinkBox.Text);
                    File.WriteAllLines("links.txt", linesList.ToArray());

                    listLinkBox.Items.Add(addLinkBox.Text);
                    addLinkBox.Text = "";
                    amountLinks++;
                    appName.Text = "AutoRunner Link Editer (" + amountLinks + " Links Found)";
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR 1x1, While adding the data. Text: " + addLinkBox.Text);
                }
            }
        }

        //For deleting a selected item.
        private void deleteLinkBtn_Click(object sender, EventArgs e)
        {
            if (listLinkBox.SelectedItem != null)
            {
                try
                {
                    List<string> linesList = File.ReadAllLines("links.txt").ToList();
                    linesList.RemoveAt(listLinkBox.SelectedIndex);
                    File.WriteAllLines("links.txt", linesList.ToArray());

                    listLinkBox.Items.Remove(listLinkBox.SelectedItem);
                    amountLinks--;
                    appName.Text = "AutoRunner Link Editer (" + amountLinks + " Links Found)";
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR 1x2, While editing the data. @" + listLinkBox.SelectedIndex);
                }
            }
        }

        //For going back to de main window.
        private void goBackBtn_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm();
            mainForm.Show();
            this.Close();
        }

        //For close button in de bar.
        private void closeBtn_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm();
            mainForm.Show();
            this.Close();
        }

        //For moving the window with the top bar en label.
        private void topBarPl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void topBarPl_MouseMove(object sender, MouseEventArgs e)
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