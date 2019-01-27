namespace AutoRunner
{
    partial class linkAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(linkAddForm));
            this.closeBtn = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.topBarPl = new System.Windows.Forms.Panel();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.addLinkBox = new System.Windows.Forms.TextBox();
            this.listLinkBox = new System.Windows.Forms.ListBox();
            this.deleteLinkBtn = new System.Windows.Forms.Button();
            this.splitPl = new System.Windows.Forms.Panel();
            this.addLinkBtn = new System.Windows.Forms.Button();
            this.split2Pl = new System.Windows.Forms.Panel();
            this.topBarPl.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Silver;
            this.closeBtn.Location = new System.Drawing.Point(450, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // appName
            // 
            this.appName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.Silver;
            this.appName.Location = new System.Drawing.Point(3, 0);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(441, 30);
            this.appName.TabIndex = 0;
            this.appName.Text = "AutoRunner Link Editer (0 Links Found)";
            this.appName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appName_MouseDown);
            this.appName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.appName_MouseMove);
            // 
            // topBarPl
            // 
            this.topBarPl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarPl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topBarPl.Controls.Add(this.closeBtn);
            this.topBarPl.Controls.Add(this.appName);
            this.topBarPl.Location = new System.Drawing.Point(0, 0);
            this.topBarPl.Name = "topBarPl";
            this.topBarPl.Size = new System.Drawing.Size(480, 30);
            this.topBarPl.TabIndex = 1;
            this.topBarPl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBarPl_MouseDown);
            this.topBarPl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBarPl_MouseMove);
            // 
            // goBackBtn
            // 
            this.goBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackBtn.FlatAppearance.BorderSize = 0;
            this.goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goBackBtn.Location = new System.Drawing.Point(0, 306);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(480, 31);
            this.goBackBtn.TabIndex = 15;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // addLinkBox
            // 
            this.addLinkBox.BackColor = System.Drawing.Color.Silver;
            this.addLinkBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLinkBox.Location = new System.Drawing.Point(0, 248);
            this.addLinkBox.Name = "addLinkBox";
            this.addLinkBox.Size = new System.Drawing.Size(480, 23);
            this.addLinkBox.TabIndex = 2;
            // 
            // listLinkBox
            // 
            this.listLinkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLinkBox.BackColor = System.Drawing.Color.Silver;
            this.listLinkBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLinkBox.FormattingEnabled = true;
            this.listLinkBox.ItemHeight = 15;
            this.listLinkBox.Location = new System.Drawing.Point(0, 30);
            this.listLinkBox.Name = "listLinkBox";
            this.listLinkBox.Size = new System.Drawing.Size(480, 184);
            this.listLinkBox.TabIndex = 16;
            // 
            // deleteLinkBtn
            // 
            this.deleteLinkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteLinkBtn.FlatAppearance.BorderSize = 0;
            this.deleteLinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLinkBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLinkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteLinkBtn.Location = new System.Drawing.Point(0, 213);
            this.deleteLinkBtn.Name = "deleteLinkBtn";
            this.deleteLinkBtn.Size = new System.Drawing.Size(480, 31);
            this.deleteLinkBtn.TabIndex = 17;
            this.deleteLinkBtn.Text = "Delete Selected Link";
            this.deleteLinkBtn.UseVisualStyleBackColor = true;
            this.deleteLinkBtn.Click += new System.EventHandler(this.deleteLinkBtn_Click);
            // 
            // splitPl
            // 
            this.splitPl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitPl.Location = new System.Drawing.Point(0, 244);
            this.splitPl.Name = "splitPl";
            this.splitPl.Size = new System.Drawing.Size(480, 5);
            this.splitPl.TabIndex = 18;
            // 
            // addLinkBtn
            // 
            this.addLinkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLinkBtn.FlatAppearance.BorderSize = 0;
            this.addLinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLinkBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLinkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addLinkBtn.Location = new System.Drawing.Point(0, 270);
            this.addLinkBtn.Name = "addLinkBtn";
            this.addLinkBtn.Size = new System.Drawing.Size(480, 31);
            this.addLinkBtn.TabIndex = 19;
            this.addLinkBtn.Text = "Add Link (Typed Above)";
            this.addLinkBtn.UseVisualStyleBackColor = true;
            this.addLinkBtn.Click += new System.EventHandler(this.addLinkBtn_Click);
            // 
            // split2Pl
            // 
            this.split2Pl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.split2Pl.Location = new System.Drawing.Point(0, 301);
            this.split2Pl.Name = "split2Pl";
            this.split2Pl.Size = new System.Drawing.Size(480, 5);
            this.split2Pl.TabIndex = 19;
            // 
            // linkAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(480, 338);
            this.Controls.Add(this.split2Pl);
            this.Controls.Add(this.addLinkBtn);
            this.Controls.Add(this.splitPl);
            this.Controls.Add(this.deleteLinkBtn);
            this.Controls.Add(this.listLinkBox);
            this.Controls.Add(this.addLinkBox);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.topBarPl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "linkAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "linkAddForm";
            this.topBarPl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Panel topBarPl;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.TextBox addLinkBox;
        private System.Windows.Forms.ListBox listLinkBox;
        private System.Windows.Forms.Button deleteLinkBtn;
        private System.Windows.Forms.Panel splitPl;
        private System.Windows.Forms.Button addLinkBtn;
        private System.Windows.Forms.Panel split2Pl;
    }
}