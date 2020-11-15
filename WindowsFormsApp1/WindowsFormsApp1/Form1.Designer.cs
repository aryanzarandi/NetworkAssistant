namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txthostname = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.Octet1 = new System.Windows.Forms.NumericUpDown();
            this.Octet2 = new System.Windows.Forms.NumericUpDown();
            this.Octet4 = new System.Windows.Forms.NumericUpDown();
            this.Octet3 = new System.Windows.Forms.NumericUpDown();
            this.btncmd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblgateways = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblpublicip = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblprivateip = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnetworkinterfaces = new System.Windows.Forms.TextBox();
            this.btnprinters = new System.Windows.Forms.Button();
            this.btndevicemanager = new System.Windows.Forms.Button();
            this.btntaskmanager = new System.Windows.Forms.Button();
            this.btnconnections = new System.Windows.Forms.Button();
            this.btnregedit = new System.Windows.Forms.Button();
            this.btnrun = new System.Windows.Forms.Button();
            this.btncontrolpanel = new System.Windows.Forms.Button();
            this.btnrefreshtxtnetworkinterfaces = new System.Windows.Forms.Button();
            this.btntrace = new System.Windows.Forms.Button();
            this.chkhostname = new System.Windows.Forms.CheckBox();
            this.btnnslookup = new System.Windows.Forms.Button();
            this.btnservices = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Octet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Octet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Octet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Octet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Ping";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txthostname
            // 
            this.txthostname.Location = new System.Drawing.Point(32, 350);
            this.txthostname.Name = "txthostname";
            this.txthostname.Size = new System.Drawing.Size(160, 20);
            this.txthostname.TabIndex = 0;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(9, 499);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(81, 15);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Ping Result";
            // 
            // Octet1
            // 
            this.Octet1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Octet1.Location = new System.Drawing.Point(12, 375);
            this.Octet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Octet1.Name = "Octet1";
            this.Octet1.Size = new System.Drawing.Size(82, 20);
            this.Octet1.TabIndex = 2;
            this.Octet1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Octet1.Click += new System.EventHandler(this.Octet1_Click);
            this.Octet1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Octet1_KeyPress);
            // 
            // Octet2
            // 
            this.Octet2.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Octet2.Location = new System.Drawing.Point(100, 375);
            this.Octet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Octet2.Name = "Octet2";
            this.Octet2.Size = new System.Drawing.Size(82, 20);
            this.Octet2.TabIndex = 3;
            this.Octet2.Click += new System.EventHandler(this.Octet2_Click);
            // 
            // Octet4
            // 
            this.Octet4.Location = new System.Drawing.Point(276, 375);
            this.Octet4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Octet4.Name = "Octet4";
            this.Octet4.Size = new System.Drawing.Size(82, 20);
            this.Octet4.TabIndex = 5;
            this.Octet4.Click += new System.EventHandler(this.Octet4_Click);
            // 
            // Octet3
            // 
            this.Octet3.Location = new System.Drawing.Point(188, 375);
            this.Octet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Octet3.Name = "Octet3";
            this.Octet3.Size = new System.Drawing.Size(82, 20);
            this.Octet3.TabIndex = 4;
            this.Octet3.Click += new System.EventHandler(this.Octet3_Click);
            // 
            // btncmd
            // 
            this.btncmd.Location = new System.Drawing.Point(179, 473);
            this.btncmd.Name = "btncmd";
            this.btncmd.Size = new System.Drawing.Size(73, 23);
            this.btncmd.TabIndex = 11;
            this.btncmd.Text = "&CMD Remotely";
            this.btncmd.UseVisualStyleBackColor = true;
            this.btncmd.Click += new System.EventHandler(this.btncmd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 333);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblgateways);
            this.groupBox5.Location = new System.Drawing.Point(256, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 143);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // lblgateways
            // 
            this.lblgateways.AutoSize = true;
            this.lblgateways.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgateways.ForeColor = System.Drawing.Color.Red;
            this.lblgateways.Location = new System.Drawing.Point(6, 16);
            this.lblgateways.Name = "lblgateways";
            this.lblgateways.Size = new System.Drawing.Size(70, 15);
            this.lblgateways.TabIndex = 0;
            this.lblgateways.Text = "GateWays";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblpublicip);
            this.groupBox4.Location = new System.Drawing.Point(256, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 141);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // lblpublicip
            // 
            this.lblpublicip.AutoSize = true;
            this.lblpublicip.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblpublicip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpublicip.ForeColor = System.Drawing.Color.Red;
            this.lblpublicip.Location = new System.Drawing.Point(8, 16);
            this.lblpublicip.Name = "lblpublicip";
            this.lblpublicip.Size = new System.Drawing.Size(68, 15);
            this.lblpublicip.TabIndex = 1;
            this.lblpublicip.Text = " Public IP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblprivateip);
            this.groupBox3.Location = new System.Drawing.Point(10, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 260);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // lblprivateip
            // 
            this.lblprivateip.AutoSize = true;
            this.lblprivateip.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblprivateip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprivateip.ForeColor = System.Drawing.Color.Red;
            this.lblprivateip.Location = new System.Drawing.Point(0, 16);
            this.lblprivateip.Name = "lblprivateip";
            this.lblprivateip.Size = new System.Drawing.Size(72, 15);
            this.lblprivateip.TabIndex = 0;
            this.lblprivateip.Text = " Private IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnetworkinterfaces);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(491, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network Interfaces";
            // 
            // txtnetworkinterfaces
            // 
            this.txtnetworkinterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetworkinterfaces.Location = new System.Drawing.Point(6, 19);
            this.txtnetworkinterfaces.Multiline = true;
            this.txtnetworkinterfaces.Name = "txtnetworkinterfaces";
            this.txtnetworkinterfaces.ReadOnly = true;
            this.txtnetworkinterfaces.Size = new System.Drawing.Size(326, 291);
            this.txtnetworkinterfaces.TabIndex = 0;
            // 
            // btnprinters
            // 
            this.btnprinters.Location = new System.Drawing.Point(477, 459);
            this.btnprinters.Name = "btnprinters";
            this.btnprinters.Size = new System.Drawing.Size(97, 23);
            this.btnprinters.TabIndex = 16;
            this.btnprinters.Text = "&Printers";
            this.btnprinters.UseVisualStyleBackColor = true;
            this.btnprinters.Click += new System.EventHandler(this.btnprinters_Click);
            // 
            // btndevicemanager
            // 
            this.btndevicemanager.Location = new System.Drawing.Point(583, 459);
            this.btndevicemanager.Name = "btndevicemanager";
            this.btndevicemanager.Size = new System.Drawing.Size(97, 23);
            this.btndevicemanager.TabIndex = 17;
            this.btndevicemanager.Text = "&Device Manager";
            this.btndevicemanager.UseVisualStyleBackColor = true;
            this.btndevicemanager.Click += new System.EventHandler(this.btndevicemanager_Click);
            // 
            // btntaskmanager
            // 
            this.btntaskmanager.Location = new System.Drawing.Point(583, 417);
            this.btntaskmanager.Name = "btntaskmanager";
            this.btntaskmanager.Size = new System.Drawing.Size(97, 23);
            this.btntaskmanager.TabIndex = 13;
            this.btntaskmanager.Text = "&Task Manager";
            this.btntaskmanager.UseVisualStyleBackColor = true;
            this.btntaskmanager.Click += new System.EventHandler(this.btntaskmanager_Click);
            // 
            // btnconnections
            // 
            this.btnconnections.Location = new System.Drawing.Point(686, 417);
            this.btnconnections.Name = "btnconnections";
            this.btnconnections.Size = new System.Drawing.Size(97, 23);
            this.btnconnections.TabIndex = 14;
            this.btnconnections.Text = "&Connection";
            this.btnconnections.UseVisualStyleBackColor = true;
            this.btnconnections.Click += new System.EventHandler(this.btnconnections_Click);
            // 
            // btnregedit
            // 
            this.btnregedit.Location = new System.Drawing.Point(789, 417);
            this.btnregedit.Name = "btnregedit";
            this.btnregedit.Size = new System.Drawing.Size(97, 23);
            this.btnregedit.TabIndex = 15;
            this.btnregedit.Text = "&Regedit";
            this.btnregedit.UseVisualStyleBackColor = true;
            this.btnregedit.Click += new System.EventHandler(this.btnregedit_Click);
            // 
            // btnrun
            // 
            this.btnrun.Location = new System.Drawing.Point(686, 459);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(97, 23);
            this.btnrun.TabIndex = 18;
            this.btnrun.Text = "&RUN";
            this.btnrun.UseVisualStyleBackColor = true;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // btncontrolpanel
            // 
            this.btncontrolpanel.Location = new System.Drawing.Point(477, 417);
            this.btncontrolpanel.Name = "btncontrolpanel";
            this.btncontrolpanel.Size = new System.Drawing.Size(97, 23);
            this.btncontrolpanel.TabIndex = 12;
            this.btncontrolpanel.Text = "Control Panel";
            this.btncontrolpanel.UseMnemonic = false;
            this.btncontrolpanel.UseVisualStyleBackColor = true;
            this.btncontrolpanel.Click += new System.EventHandler(this.btncontrolpanel_Click);
            // 
            // btnrefreshtxtnetworkinterfaces
            // 
            this.btnrefreshtxtnetworkinterfaces.Location = new System.Drawing.Point(499, 345);
            this.btnrefreshtxtnetworkinterfaces.Name = "btnrefreshtxtnetworkinterfaces";
            this.btnrefreshtxtnetworkinterfaces.Size = new System.Drawing.Size(75, 27);
            this.btnrefreshtxtnetworkinterfaces.TabIndex = 20;
            this.btnrefreshtxtnetworkinterfaces.Text = "Refresh";
            this.btnrefreshtxtnetworkinterfaces.UseVisualStyleBackColor = true;
            this.btnrefreshtxtnetworkinterfaces.Click += new System.EventHandler(this.btnrefreshtxtnetworkinterfaces_Click);
            // 
            // btntrace
            // 
            this.btntrace.Location = new System.Drawing.Point(179, 430);
            this.btntrace.Name = "btntrace";
            this.btntrace.Size = new System.Drawing.Size(73, 23);
            this.btntrace.TabIndex = 8;
            this.btntrace.Text = "&Trace";
            this.btntrace.UseVisualStyleBackColor = true;
            this.btntrace.Click += new System.EventHandler(this.btntrace_Click);
            // 
            // chkhostname
            // 
            this.chkhostname.AutoSize = true;
            this.chkhostname.Location = new System.Drawing.Point(11, 353);
            this.chkhostname.Name = "chkhostname";
            this.chkhostname.Size = new System.Drawing.Size(15, 14);
            this.chkhostname.TabIndex = 1;
            this.chkhostname.UseVisualStyleBackColor = true;
            this.chkhostname.CheckedChanged += new System.EventHandler(this.chkhostname_CheckedChanged);
            // 
            // btnnslookup
            // 
            this.btnnslookup.Location = new System.Drawing.Point(267, 430);
            this.btnnslookup.Name = "btnnslookup";
            this.btnnslookup.Size = new System.Drawing.Size(82, 23);
            this.btnnslookup.TabIndex = 9;
            this.btnnslookup.Text = "NsLookup";
            this.btnnslookup.UseVisualStyleBackColor = true;
            this.btnnslookup.Click += new System.EventHandler(this.btnnslookup_Click);
            // 
            // btnservices
            // 
            this.btnservices.Location = new System.Drawing.Point(789, 459);
            this.btnservices.Name = "btnservices";
            this.btnservices.Size = new System.Drawing.Size(97, 23);
            this.btnservices.TabIndex = 19;
            this.btnservices.Text = "&Services";
            this.btnservices.UseVisualStyleBackColor = true;
            this.btnservices.Click += new System.EventHandler(this.btnservices_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset Remotely";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ping -t";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "In Memories Of All Rained Flower";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 557);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnrefreshtxtnetworkinterfaces);
            this.Controls.Add(this.btnservices);
            this.Controls.Add(this.btnnslookup);
            this.Controls.Add(this.chkhostname);
            this.Controls.Add(this.btntrace);
            this.Controls.Add(this.btncontrolpanel);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.btnregedit);
            this.Controls.Add(this.btnconnections);
            this.Controls.Add(this.btntaskmanager);
            this.Controls.Add(this.btndevicemanager);
            this.Controls.Add(this.btnprinters);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncmd);
            this.Controls.Add(this.Octet4);
            this.Controls.Add(this.Octet3);
            this.Controls.Add(this.Octet2);
            this.Controls.Add(this.Octet1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txthostname);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aryan Network Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Octet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Octet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Octet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Octet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txthostname;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.NumericUpDown Octet1;
        private System.Windows.Forms.NumericUpDown Octet2;
        private System.Windows.Forms.NumericUpDown Octet4;
        private System.Windows.Forms.NumericUpDown Octet3;
        private System.Windows.Forms.Button btncmd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblpublicip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnetworkinterfaces;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblgateways;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnprinters;
        private System.Windows.Forms.Button btndevicemanager;
        private System.Windows.Forms.Button btntaskmanager;
        private System.Windows.Forms.Button btnconnections;
        private System.Windows.Forms.Button btnregedit;
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.Button btncontrolpanel;
        private System.Windows.Forms.Button btnrefreshtxtnetworkinterfaces;
        private System.Windows.Forms.Label lblprivateip;
        private System.Windows.Forms.Button btntrace;
        private System.Windows.Forms.CheckBox chkhostname;
        private System.Windows.Forms.Button btnnslookup;
        private System.Windows.Forms.Button btnservices;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

