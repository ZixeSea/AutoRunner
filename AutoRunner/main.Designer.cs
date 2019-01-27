namespace AutoRunner
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.topBarPl = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.runOnBtn = new System.Windows.Forms.Button();
            this.runOffBtn = new System.Windows.Forms.Button();
            this.runOpenBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picChecked = new System.Windows.Forms.PictureBox();
            this.picUnchecked = new System.Windows.Forms.PictureBox();
            this.statusLb = new System.Windows.Forms.Label();
            this.picError = new System.Windows.Forms.PictureBox();
            this.topBarPl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnchecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();
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
            this.topBarPl.Size = new System.Drawing.Size(300, 30);
            this.topBarPl.TabIndex = 0;
            this.topBarPl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.topBarPl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Silver;
            this.closeBtn.Location = new System.Drawing.Point(270, 0);
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
            this.appName.Size = new System.Drawing.Size(133, 30);
            this.appName.TabIndex = 0;
            this.appName.Text = "AutoRunner";
            this.appName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.appName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appName_MouseDown);
            this.appName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.appName_MouseMove);
            // 
            // runOnBtn
            // 
            this.runOnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runOnBtn.FlatAppearance.BorderSize = 0;
            this.runOnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runOnBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runOnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.runOnBtn.Location = new System.Drawing.Point(0, 30);
            this.runOnBtn.Name = "runOnBtn";
            this.runOnBtn.Size = new System.Drawing.Size(162, 32);
            this.runOnBtn.TabIndex = 1;
            this.runOnBtn.Text = "Start AutoRun";
            this.runOnBtn.UseVisualStyleBackColor = true;
            this.runOnBtn.Click += new System.EventHandler(this.runOnBtn_Click);
            // 
            // runOffBtn
            // 
            this.runOffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runOffBtn.FlatAppearance.BorderSize = 0;
            this.runOffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runOffBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runOffBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.runOffBtn.Location = new System.Drawing.Point(0, 68);
            this.runOffBtn.Name = "runOffBtn";
            this.runOffBtn.Size = new System.Drawing.Size(162, 32);
            this.runOffBtn.TabIndex = 2;
            this.runOffBtn.Text = "Stop AutoRun";
            this.runOffBtn.UseVisualStyleBackColor = true;
            this.runOffBtn.Click += new System.EventHandler(this.runOffBtn_Click);
            // 
            // runOpenBtn
            // 
            this.runOpenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runOpenBtn.FlatAppearance.BorderSize = 0;
            this.runOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runOpenBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runOpenBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.runOpenBtn.Location = new System.Drawing.Point(0, 106);
            this.runOpenBtn.Name = "runOpenBtn";
            this.runOpenBtn.Size = new System.Drawing.Size(162, 32);
            this.runOpenBtn.TabIndex = 3;
            this.runOpenBtn.Text = "Open Folder";
            this.runOpenBtn.UseVisualStyleBackColor = true;
            this.runOpenBtn.Click += new System.EventHandler(this.runOpenBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(162, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 110);
            this.panel2.TabIndex = 4;
            // 
            // picChecked
            // 
            this.picChecked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picChecked.Image = ((System.Drawing.Image)(resources.GetObject("picChecked.Image")));
            this.picChecked.Location = new System.Drawing.Point(209, 37);
            this.picChecked.Name = "picChecked";
            this.picChecked.Size = new System.Drawing.Size(51, 48);
            this.picChecked.TabIndex = 5;
            this.picChecked.TabStop = false;
            this.picChecked.Visible = false;
            // 
            // picUnchecked
            // 
            this.picUnchecked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picUnchecked.Image = ((System.Drawing.Image)(resources.GetObject("picUnchecked.Image")));
            this.picUnchecked.Location = new System.Drawing.Point(209, 37);
            this.picUnchecked.Name = "picUnchecked";
            this.picUnchecked.Size = new System.Drawing.Size(51, 48);
            this.picUnchecked.TabIndex = 6;
            this.picUnchecked.TabStop = false;
            this.picUnchecked.Visible = false;
            // 
            // statusLb
            // 
            this.statusLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusLb.Location = new System.Drawing.Point(168, 100);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(130, 30);
            this.statusLb.TabIndex = 2;
            this.statusLb.Text = "No Status";
            this.statusLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picError
            // 
            this.picError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picError.Image = ((System.Drawing.Image)(resources.GetObject("picError.Image")));
            this.picError.Location = new System.Drawing.Point(209, 37);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(51, 48);
            this.picError.TabIndex = 7;
            this.picError.TabStop = false;
            this.picError.Visible = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(300, 139);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.statusLb);
            this.Controls.Add(this.picUnchecked);
            this.Controls.Add(this.picChecked);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.runOpenBtn);
            this.Controls.Add(this.runOffBtn);
            this.Controls.Add(this.runOnBtn);
            this.Controls.Add(this.topBarPl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Main Window";
            this.topBarPl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnchecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBarPl;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Button runOnBtn;
        private System.Windows.Forms.Button runOffBtn;
        private System.Windows.Forms.Button runOpenBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picChecked;
        private System.Windows.Forms.PictureBox picUnchecked;
        private System.Windows.Forms.Label statusLb;
        private System.Windows.Forms.PictureBox picError;
    }
}

