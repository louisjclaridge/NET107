namespace TrafficLight
{
    partial class FormTrafficLight
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxLightIP = new System.Windows.Forms.TextBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.listBoxOutput = new System.Windows.Forms.ListBox();
			this.labelRed = new System.Windows.Forms.Label();
			this.labelGreen = new System.Windows.Forms.Label();
			this.labelAmber = new System.Windows.Forms.Label();
			this.buttonCarArrived = new System.Windows.Forms.Button();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.txtServerAddress = new System.Windows.Forms.TextBox();
			this.lblLog = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 145);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "IP number of server";
			// 
			// textBoxLightIP
			// 
			this.textBoxLightIP.Location = new System.Drawing.Point(199, 141);
			this.textBoxLightIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxLightIP.Name = "textBoxLightIP";
			this.textBoxLightIP.Size = new System.Drawing.Size(130, 26);
			this.textBoxLightIP.TabIndex = 10;
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatus.Location = new System.Drawing.Point(456, 46);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(74, 26);
			this.labelStatus.TabIndex = 9;
			this.labelStatus.Text = "Status";
			// 
			// listBoxOutput
			// 
			this.listBoxOutput.FormattingEnabled = true;
			this.listBoxOutput.ItemHeight = 20;
			this.listBoxOutput.Location = new System.Drawing.Point(52, 389);
			this.listBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listBoxOutput.Name = "listBoxOutput";
			this.listBoxOutput.Size = new System.Drawing.Size(471, 244);
			this.listBoxOutput.TabIndex = 8;
			// 
			// labelRed
			// 
			this.labelRed.AutoSize = true;
			this.labelRed.BackColor = System.Drawing.Color.Red;
			this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRed.Location = new System.Drawing.Point(460, 135);
			this.labelRed.Name = "labelRed";
			this.labelRed.Size = new System.Drawing.Size(59, 55);
			this.labelRed.TabIndex = 12;
			this.labelRed.Text = "R";
			this.labelRed.Visible = false;
			// 
			// labelGreen
			// 
			this.labelGreen.AutoSize = true;
			this.labelGreen.BackColor = System.Drawing.Color.Lime;
			this.labelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGreen.Location = new System.Drawing.Point(460, 274);
			this.labelGreen.Name = "labelGreen";
			this.labelGreen.Size = new System.Drawing.Size(61, 55);
			this.labelGreen.TabIndex = 13;
			this.labelGreen.Text = "G";
			this.labelGreen.Visible = false;
			// 
			// labelAmber
			// 
			this.labelAmber.AutoSize = true;
			this.labelAmber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.labelAmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAmber.Location = new System.Drawing.Point(460, 205);
			this.labelAmber.Name = "labelAmber";
			this.labelAmber.Size = new System.Drawing.Size(56, 55);
			this.labelAmber.TabIndex = 14;
			this.labelAmber.Text = "A";
			this.labelAmber.Visible = false;
			// 
			// buttonCarArrived
			// 
			this.buttonCarArrived.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonCarArrived.Enabled = false;
			this.buttonCarArrived.Location = new System.Drawing.Point(52, 221);
			this.buttonCarArrived.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonCarArrived.Name = "buttonCarArrived";
			this.buttonCarArrived.Size = new System.Drawing.Size(158, 29);
			this.buttonCarArrived.TabIndex = 15;
			this.buttonCarArrived.Text = "Car Arrived";
			this.buttonCarArrived.UseVisualStyleBackColor = true;
			this.buttonCarArrived.Click += new System.EventHandler(this.buttonCarArrived_Click);
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(262, 39);
			this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(187, 48);
			this.buttonConnect.TabIndex = 7;
			this.buttonConnect.Text = "Connect to sort of proxy";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// txtServerAddress
			// 
			this.txtServerAddress.Location = new System.Drawing.Point(42, 49);
			this.txtServerAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtServerAddress.Name = "txtServerAddress";
			this.txtServerAddress.Size = new System.Drawing.Size(213, 26);
			this.txtServerAddress.TabIndex = 16;
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLog.Location = new System.Drawing.Point(241, 335);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(77, 40);
			this.lblLog.TabIndex = 17;
			this.lblLog.Text = "Log";
			// 
			// FormTrafficLight
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 676);
			this.Controls.Add(this.lblLog);
			this.Controls.Add(this.txtServerAddress);
			this.Controls.Add(this.buttonCarArrived);
			this.Controls.Add(this.labelAmber);
			this.Controls.Add(this.labelGreen);
			this.Controls.Add(this.labelRed);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxLightIP);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.listBoxOutput);
			this.Controls.Add(this.buttonConnect);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormTrafficLight";
			this.Text = "Traffic light";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrafficLight_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLightIP;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelAmber;
        private System.Windows.Forms.Button buttonCarArrived;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox txtServerAddress;
		private System.Windows.Forms.Label lblLog;
	}
}

