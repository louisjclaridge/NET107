namespace TrafficLightServer
{
    partial class FormServer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
			this.buttonConnect = new System.Windows.Forms.Button();
			this.listBoxOutput = new System.Windows.Forms.ListBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.textBoxLightIP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabLightStatus = new System.Windows.Forms.TabControl();
			this.tabLightStatusPage = new System.Windows.Forms.TabPage();
			this.tabLightLayoutPage = new System.Windows.Forms.TabPage();
			this.lblLightFourLabel = new System.Windows.Forms.Label();
			this.lblLightFourAmber = new System.Windows.Forms.Label();
			this.lblLightFourGreen = new System.Windows.Forms.Label();
			this.lblLightFourRed = new System.Windows.Forms.Label();
			this.lblLightThreeLabel = new System.Windows.Forms.Label();
			this.lblLightThreeAmber = new System.Windows.Forms.Label();
			this.lblLightThreeGreen = new System.Windows.Forms.Label();
			this.lblLightThreeRed = new System.Windows.Forms.Label();
			this.lblLightTwoLabel = new System.Windows.Forms.Label();
			this.lblLightTwoAmber = new System.Windows.Forms.Label();
			this.lblLightTwoGreen = new System.Windows.Forms.Label();
			this.lblLightTwoRed = new System.Windows.Forms.Label();
			this.lblLightOneLabel = new System.Windows.Forms.Label();
			this.lblLightOneAmber = new System.Windows.Forms.Label();
			this.lblLightOneGreen = new System.Windows.Forms.Label();
			this.lblLightOneRed = new System.Windows.Forms.Label();
			this.picLayout = new System.Windows.Forms.PictureBox();
			this.lblLight1Amber = new System.Windows.Forms.Label();
			this.lblLight1Green = new System.Windows.Forms.Label();
			this.lblLight1Red = new System.Windows.Forms.Label();
			this.lblLight3Amber = new System.Windows.Forms.Label();
			this.lblLight3Green = new System.Windows.Forms.Label();
			this.lblLight3Red = new System.Windows.Forms.Label();
			this.lblLight4Amber = new System.Windows.Forms.Label();
			this.lblLight4Green = new System.Windows.Forms.Label();
			this.lblLight4Red = new System.Windows.Forms.Label();
			this.lblLight2Amber = new System.Windows.Forms.Label();
			this.lblLight2Green = new System.Windows.Forms.Label();
			this.lblLight2Red = new System.Windows.Forms.Label();
			this.lblLight3Cars = new System.Windows.Forms.Label();
			this.lblLight1Cars = new System.Windows.Forms.Label();
			this.lblLight2Cars = new System.Windows.Forms.Label();
			this.lblLight4Cars = new System.Windows.Forms.Label();
			this.lblLightInfo = new System.Windows.Forms.Label();
			this.lblLog = new System.Windows.Forms.Label();
			this.lblLightOneConnected = new System.Windows.Forms.Label();
			this.lblLightTwoConnected = new System.Windows.Forms.Label();
			this.lblLightThreeConnected = new System.Windows.Forms.Label();
			this.lblLightFourConnected = new System.Windows.Forms.Label();
			this.tabLightStatus.SuspendLayout();
			this.tabLightStatusPage.SuspendLayout();
			this.tabLightLayoutPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLayout)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(53, 39);
			this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(264, 48);
			this.buttonConnect.TabIndex = 0;
			this.buttonConnect.Text = "Connect to sort of proxy";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// listBoxOutput
			// 
			this.listBoxOutput.FormattingEnabled = true;
			this.listBoxOutput.ItemHeight = 20;
			this.listBoxOutput.Location = new System.Drawing.Point(53, 269);
			this.listBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listBoxOutput.Name = "listBoxOutput";
			this.listBoxOutput.Size = new System.Drawing.Size(471, 384);
			this.listBoxOutput.TabIndex = 1;
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatus.Location = new System.Drawing.Point(48, 9);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(74, 26);
			this.labelStatus.TabIndex = 2;
			this.labelStatus.Text = "Status";
			// 
			// textBoxLightIP
			// 
			this.textBoxLightIP.Location = new System.Drawing.Point(187, 138);
			this.textBoxLightIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxLightIP.Name = "textBoxLightIP";
			this.textBoxLightIP.Size = new System.Drawing.Size(130, 26);
			this.textBoxLightIP.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "IP number of light";
			// 
			// tabLightStatus
			// 
			this.tabLightStatus.Controls.Add(this.tabLightStatusPage);
			this.tabLightStatus.Controls.Add(this.tabLightLayoutPage);
			this.tabLightStatus.Location = new System.Drawing.Point(681, 76);
			this.tabLightStatus.Name = "tabLightStatus";
			this.tabLightStatus.SelectedIndex = 0;
			this.tabLightStatus.Size = new System.Drawing.Size(639, 554);
			this.tabLightStatus.TabIndex = 7;
			// 
			// tabLightStatusPage
			// 
			this.tabLightStatusPage.Controls.Add(this.lblLightFourConnected);
			this.tabLightStatusPage.Controls.Add(this.lblLightThreeConnected);
			this.tabLightStatusPage.Controls.Add(this.lblLightTwoConnected);
			this.tabLightStatusPage.Controls.Add(this.lblLightOneConnected);
			this.tabLightStatusPage.Controls.Add(this.lblLightFourLabel);
			this.tabLightStatusPage.Controls.Add(this.lblLightFourAmber);
			this.tabLightStatusPage.Controls.Add(this.lblLightFourGreen);
			this.tabLightStatusPage.Controls.Add(this.lblLightFourRed);
			this.tabLightStatusPage.Controls.Add(this.lblLightThreeLabel);
			this.tabLightStatusPage.Controls.Add(this.lblLightThreeAmber);
			this.tabLightStatusPage.Controls.Add(this.lblLightThreeGreen);
			this.tabLightStatusPage.Controls.Add(this.lblLightThreeRed);
			this.tabLightStatusPage.Controls.Add(this.lblLightTwoLabel);
			this.tabLightStatusPage.Controls.Add(this.lblLightTwoAmber);
			this.tabLightStatusPage.Controls.Add(this.lblLightTwoGreen);
			this.tabLightStatusPage.Controls.Add(this.lblLightTwoRed);
			this.tabLightStatusPage.Controls.Add(this.lblLightOneLabel);
			this.tabLightStatusPage.Controls.Add(this.lblLightOneAmber);
			this.tabLightStatusPage.Controls.Add(this.lblLightOneGreen);
			this.tabLightStatusPage.Controls.Add(this.lblLightOneRed);
			this.tabLightStatusPage.Location = new System.Drawing.Point(4, 29);
			this.tabLightStatusPage.Name = "tabLightStatusPage";
			this.tabLightStatusPage.Padding = new System.Windows.Forms.Padding(3);
			this.tabLightStatusPage.Size = new System.Drawing.Size(631, 521);
			this.tabLightStatusPage.TabIndex = 0;
			this.tabLightStatusPage.Text = "Light Status";
			this.tabLightStatusPage.UseVisualStyleBackColor = true;
			// 
			// tabLightLayoutPage
			// 
			this.tabLightLayoutPage.Controls.Add(this.lblLight4Cars);
			this.tabLightLayoutPage.Controls.Add(this.lblLight2Cars);
			this.tabLightLayoutPage.Controls.Add(this.lblLight1Cars);
			this.tabLightLayoutPage.Controls.Add(this.lblLight3Cars);
			this.tabLightLayoutPage.Controls.Add(this.lblLight2Amber);
			this.tabLightLayoutPage.Controls.Add(this.lblLight2Green);
			this.tabLightLayoutPage.Controls.Add(this.lblLight2Red);
			this.tabLightLayoutPage.Controls.Add(this.lblLight4Amber);
			this.tabLightLayoutPage.Controls.Add(this.lblLight4Green);
			this.tabLightLayoutPage.Controls.Add(this.lblLight4Red);
			this.tabLightLayoutPage.Controls.Add(this.lblLight3Amber);
			this.tabLightLayoutPage.Controls.Add(this.lblLight3Green);
			this.tabLightLayoutPage.Controls.Add(this.lblLight3Red);
			this.tabLightLayoutPage.Controls.Add(this.lblLight1Amber);
			this.tabLightLayoutPage.Controls.Add(this.lblLight1Green);
			this.tabLightLayoutPage.Controls.Add(this.lblLight1Red);
			this.tabLightLayoutPage.Controls.Add(this.picLayout);
			this.tabLightLayoutPage.Location = new System.Drawing.Point(4, 29);
			this.tabLightLayoutPage.Name = "tabLightLayoutPage";
			this.tabLightLayoutPage.Padding = new System.Windows.Forms.Padding(3);
			this.tabLightLayoutPage.Size = new System.Drawing.Size(631, 521);
			this.tabLightLayoutPage.TabIndex = 1;
			this.tabLightLayoutPage.Text = "Light Layout";
			this.tabLightLayoutPage.UseVisualStyleBackColor = true;
			// 
			// lblLightFourLabel
			// 
			this.lblLightFourLabel.AutoSize = true;
			this.lblLightFourLabel.Location = new System.Drawing.Point(224, 401);
			this.lblLightFourLabel.Name = "lblLightFourLabel";
			this.lblLightFourLabel.Size = new System.Drawing.Size(116, 20);
			this.lblLightFourLabel.TabIndex = 62;
			this.lblLightFourLabel.Text = "Light 4 Status: ";
			// 
			// lblLightFourAmber
			// 
			this.lblLightFourAmber.AutoSize = true;
			this.lblLightFourAmber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblLightFourAmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightFourAmber.Location = new System.Drawing.Point(292, 424);
			this.lblLightFourAmber.Name = "lblLightFourAmber";
			this.lblLightFourAmber.Size = new System.Drawing.Size(56, 55);
			this.lblLightFourAmber.TabIndex = 61;
			this.lblLightFourAmber.Text = "A";
			this.lblLightFourAmber.Visible = false;
			// 
			// lblLightFourGreen
			// 
			this.lblLightFourGreen.AutoSize = true;
			this.lblLightFourGreen.BackColor = System.Drawing.Color.Lime;
			this.lblLightFourGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightFourGreen.Location = new System.Drawing.Point(354, 424);
			this.lblLightFourGreen.Name = "lblLightFourGreen";
			this.lblLightFourGreen.Size = new System.Drawing.Size(61, 55);
			this.lblLightFourGreen.TabIndex = 60;
			this.lblLightFourGreen.Text = "G";
			this.lblLightFourGreen.Visible = false;
			// 
			// lblLightFourRed
			// 
			this.lblLightFourRed.AutoSize = true;
			this.lblLightFourRed.BackColor = System.Drawing.Color.Red;
			this.lblLightFourRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightFourRed.Location = new System.Drawing.Point(227, 424);
			this.lblLightFourRed.Name = "lblLightFourRed";
			this.lblLightFourRed.Size = new System.Drawing.Size(59, 55);
			this.lblLightFourRed.TabIndex = 59;
			this.lblLightFourRed.Text = "R";
			this.lblLightFourRed.Visible = false;
			// 
			// lblLightThreeLabel
			// 
			this.lblLightThreeLabel.AutoSize = true;
			this.lblLightThreeLabel.Location = new System.Drawing.Point(224, 266);
			this.lblLightThreeLabel.Name = "lblLightThreeLabel";
			this.lblLightThreeLabel.Size = new System.Drawing.Size(116, 20);
			this.lblLightThreeLabel.TabIndex = 58;
			this.lblLightThreeLabel.Text = "Light 3 Status: ";
			// 
			// lblLightThreeAmber
			// 
			this.lblLightThreeAmber.AutoSize = true;
			this.lblLightThreeAmber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblLightThreeAmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightThreeAmber.Location = new System.Drawing.Point(292, 289);
			this.lblLightThreeAmber.Name = "lblLightThreeAmber";
			this.lblLightThreeAmber.Size = new System.Drawing.Size(56, 55);
			this.lblLightThreeAmber.TabIndex = 57;
			this.lblLightThreeAmber.Text = "A";
			this.lblLightThreeAmber.Visible = false;
			// 
			// lblLightThreeGreen
			// 
			this.lblLightThreeGreen.AutoSize = true;
			this.lblLightThreeGreen.BackColor = System.Drawing.Color.Lime;
			this.lblLightThreeGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightThreeGreen.Location = new System.Drawing.Point(354, 289);
			this.lblLightThreeGreen.Name = "lblLightThreeGreen";
			this.lblLightThreeGreen.Size = new System.Drawing.Size(61, 55);
			this.lblLightThreeGreen.TabIndex = 56;
			this.lblLightThreeGreen.Text = "G";
			this.lblLightThreeGreen.Visible = false;
			// 
			// lblLightThreeRed
			// 
			this.lblLightThreeRed.AutoSize = true;
			this.lblLightThreeRed.BackColor = System.Drawing.Color.Red;
			this.lblLightThreeRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightThreeRed.Location = new System.Drawing.Point(227, 289);
			this.lblLightThreeRed.Name = "lblLightThreeRed";
			this.lblLightThreeRed.Size = new System.Drawing.Size(59, 55);
			this.lblLightThreeRed.TabIndex = 55;
			this.lblLightThreeRed.Text = "R";
			this.lblLightThreeRed.Visible = false;
			// 
			// lblLightTwoLabel
			// 
			this.lblLightTwoLabel.AutoSize = true;
			this.lblLightTwoLabel.Location = new System.Drawing.Point(221, 141);
			this.lblLightTwoLabel.Name = "lblLightTwoLabel";
			this.lblLightTwoLabel.Size = new System.Drawing.Size(116, 20);
			this.lblLightTwoLabel.TabIndex = 54;
			this.lblLightTwoLabel.Text = "Light 2 Status: ";
			// 
			// lblLightTwoAmber
			// 
			this.lblLightTwoAmber.AutoSize = true;
			this.lblLightTwoAmber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblLightTwoAmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightTwoAmber.Location = new System.Drawing.Point(289, 164);
			this.lblLightTwoAmber.Name = "lblLightTwoAmber";
			this.lblLightTwoAmber.Size = new System.Drawing.Size(56, 55);
			this.lblLightTwoAmber.TabIndex = 53;
			this.lblLightTwoAmber.Text = "A";
			this.lblLightTwoAmber.Visible = false;
			// 
			// lblLightTwoGreen
			// 
			this.lblLightTwoGreen.AutoSize = true;
			this.lblLightTwoGreen.BackColor = System.Drawing.Color.Lime;
			this.lblLightTwoGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightTwoGreen.Location = new System.Drawing.Point(351, 164);
			this.lblLightTwoGreen.Name = "lblLightTwoGreen";
			this.lblLightTwoGreen.Size = new System.Drawing.Size(61, 55);
			this.lblLightTwoGreen.TabIndex = 52;
			this.lblLightTwoGreen.Text = "G";
			this.lblLightTwoGreen.Visible = false;
			// 
			// lblLightTwoRed
			// 
			this.lblLightTwoRed.AutoSize = true;
			this.lblLightTwoRed.BackColor = System.Drawing.Color.Red;
			this.lblLightTwoRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightTwoRed.Location = new System.Drawing.Point(224, 164);
			this.lblLightTwoRed.Name = "lblLightTwoRed";
			this.lblLightTwoRed.Size = new System.Drawing.Size(59, 55);
			this.lblLightTwoRed.TabIndex = 51;
			this.lblLightTwoRed.Text = "R";
			this.lblLightTwoRed.Visible = false;
			// 
			// lblLightOneLabel
			// 
			this.lblLightOneLabel.AutoSize = true;
			this.lblLightOneLabel.Location = new System.Drawing.Point(224, 21);
			this.lblLightOneLabel.Name = "lblLightOneLabel";
			this.lblLightOneLabel.Size = new System.Drawing.Size(116, 20);
			this.lblLightOneLabel.TabIndex = 50;
			this.lblLightOneLabel.Text = "Light 1 Status: ";
			// 
			// lblLightOneAmber
			// 
			this.lblLightOneAmber.AutoSize = true;
			this.lblLightOneAmber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblLightOneAmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightOneAmber.Location = new System.Drawing.Point(292, 44);
			this.lblLightOneAmber.Name = "lblLightOneAmber";
			this.lblLightOneAmber.Size = new System.Drawing.Size(56, 55);
			this.lblLightOneAmber.TabIndex = 49;
			this.lblLightOneAmber.Text = "A";
			this.lblLightOneAmber.Visible = false;
			// 
			// lblLightOneGreen
			// 
			this.lblLightOneGreen.AutoSize = true;
			this.lblLightOneGreen.BackColor = System.Drawing.Color.Lime;
			this.lblLightOneGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightOneGreen.Location = new System.Drawing.Point(354, 44);
			this.lblLightOneGreen.Name = "lblLightOneGreen";
			this.lblLightOneGreen.Size = new System.Drawing.Size(61, 55);
			this.lblLightOneGreen.TabIndex = 48;
			this.lblLightOneGreen.Text = "G";
			this.lblLightOneGreen.Visible = false;
			// 
			// lblLightOneRed
			// 
			this.lblLightOneRed.AutoSize = true;
			this.lblLightOneRed.BackColor = System.Drawing.Color.Red;
			this.lblLightOneRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightOneRed.Location = new System.Drawing.Point(227, 44);
			this.lblLightOneRed.Name = "lblLightOneRed";
			this.lblLightOneRed.Size = new System.Drawing.Size(59, 55);
			this.lblLightOneRed.TabIndex = 47;
			this.lblLightOneRed.Text = "R";
			this.lblLightOneRed.Visible = false;
			// 
			// picLayout
			// 
			this.picLayout.Image = ((System.Drawing.Image)(resources.GetObject("picLayout.Image")));
			this.picLayout.Location = new System.Drawing.Point(-4, 0);
			this.picLayout.Name = "picLayout";
			this.picLayout.Size = new System.Drawing.Size(635, 521);
			this.picLayout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLayout.TabIndex = 0;
			this.picLayout.TabStop = false;
			// 
			// lblLight1Amber
			// 
			this.lblLight1Amber.AutoSize = true;
			this.lblLight1Amber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblLight1Amber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight1Amber.Location = new System.Drawing.Point(288, 463);
			this.lblLight1Amber.Name = "lblLight1Amber";
			this.lblLight1Amber.Size = new System.Drawing.Size(56, 55);
			this.lblLight1Amber.TabIndex = 52;
			this.lblLight1Amber.Text = "A";
			this.lblLight1Amber.Visible = false;
			// 
			// lblLight1Green
			// 
			this.lblLight1Green.AutoSize = true;
			this.lblLight1Green.BackColor = System.Drawing.Color.Lime;
			this.lblLight1Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight1Green.Location = new System.Drawing.Point(350, 463);
			this.lblLight1Green.Name = "lblLight1Green";
			this.lblLight1Green.Size = new System.Drawing.Size(61, 55);
			this.lblLight1Green.TabIndex = 51;
			this.lblLight1Green.Text = "G";
			this.lblLight1Green.Visible = false;
			// 
			// lblLight1Red
			// 
			this.lblLight1Red.AutoSize = true;
			this.lblLight1Red.BackColor = System.Drawing.Color.Red;
			this.lblLight1Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight1Red.Location = new System.Drawing.Point(223, 463);
			this.lblLight1Red.Name = "lblLight1Red";
			this.lblLight1Red.Size = new System.Drawing.Size(59, 55);
			this.lblLight1Red.TabIndex = 50;
			this.lblLight1Red.Text = "R";
			this.lblLight1Red.Visible = false;
			// 
			// lblLight3Amber
			// 
			this.lblLight3Amber.AutoSize = true;
			this.lblLight3Amber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblLight3Amber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight3Amber.Location = new System.Drawing.Point(278, 3);
			this.lblLight3Amber.Name = "lblLight3Amber";
			this.lblLight3Amber.Size = new System.Drawing.Size(56, 55);
			this.lblLight3Amber.TabIndex = 55;
			this.lblLight3Amber.Text = "A";
			this.lblLight3Amber.Visible = false;
			// 
			// lblLight3Green
			// 
			this.lblLight3Green.AutoSize = true;
			this.lblLight3Green.BackColor = System.Drawing.Color.Lime;
			this.lblLight3Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight3Green.Location = new System.Drawing.Point(340, 3);
			this.lblLight3Green.Name = "lblLight3Green";
			this.lblLight3Green.Size = new System.Drawing.Size(61, 55);
			this.lblLight3Green.TabIndex = 54;
			this.lblLight3Green.Text = "G";
			this.lblLight3Green.Visible = false;
			// 
			// lblLight3Red
			// 
			this.lblLight3Red.AutoSize = true;
			this.lblLight3Red.BackColor = System.Drawing.Color.Red;
			this.lblLight3Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight3Red.Location = new System.Drawing.Point(213, 3);
			this.lblLight3Red.Name = "lblLight3Red";
			this.lblLight3Red.Size = new System.Drawing.Size(59, 55);
			this.lblLight3Red.TabIndex = 53;
			this.lblLight3Red.Text = "R";
			this.lblLight3Red.Visible = false;
			// 
			// lblLight4Amber
			// 
			this.lblLight4Amber.AutoSize = true;
			this.lblLight4Amber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblLight4Amber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight4Amber.Location = new System.Drawing.Point(64, 226);
			this.lblLight4Amber.Name = "lblLight4Amber";
			this.lblLight4Amber.Size = new System.Drawing.Size(56, 55);
			this.lblLight4Amber.TabIndex = 58;
			this.lblLight4Amber.Text = "A";
			this.lblLight4Amber.Visible = false;
			// 
			// lblLight4Green
			// 
			this.lblLight4Green.AutoSize = true;
			this.lblLight4Green.BackColor = System.Drawing.Color.Lime;
			this.lblLight4Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight4Green.Location = new System.Drawing.Point(126, 226);
			this.lblLight4Green.Name = "lblLight4Green";
			this.lblLight4Green.Size = new System.Drawing.Size(61, 55);
			this.lblLight4Green.TabIndex = 57;
			this.lblLight4Green.Text = "G";
			this.lblLight4Green.Visible = false;
			// 
			// lblLight4Red
			// 
			this.lblLight4Red.AutoSize = true;
			this.lblLight4Red.BackColor = System.Drawing.Color.Red;
			this.lblLight4Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight4Red.Location = new System.Drawing.Point(-1, 226);
			this.lblLight4Red.Name = "lblLight4Red";
			this.lblLight4Red.Size = new System.Drawing.Size(59, 55);
			this.lblLight4Red.TabIndex = 56;
			this.lblLight4Red.Text = "R";
			this.lblLight4Red.Visible = false;
			// 
			// lblLight2Amber
			// 
			this.lblLight2Amber.AutoSize = true;
			this.lblLight2Amber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lblLight2Amber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight2Amber.Location = new System.Drawing.Point(503, 226);
			this.lblLight2Amber.Name = "lblLight2Amber";
			this.lblLight2Amber.Size = new System.Drawing.Size(56, 55);
			this.lblLight2Amber.TabIndex = 61;
			this.lblLight2Amber.Text = "A";
			this.lblLight2Amber.Visible = false;
			// 
			// lblLight2Green
			// 
			this.lblLight2Green.AutoSize = true;
			this.lblLight2Green.BackColor = System.Drawing.Color.Lime;
			this.lblLight2Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight2Green.Location = new System.Drawing.Point(565, 226);
			this.lblLight2Green.Name = "lblLight2Green";
			this.lblLight2Green.Size = new System.Drawing.Size(61, 55);
			this.lblLight2Green.TabIndex = 60;
			this.lblLight2Green.Text = "G";
			this.lblLight2Green.Visible = false;
			// 
			// lblLight2Red
			// 
			this.lblLight2Red.AutoSize = true;
			this.lblLight2Red.BackColor = System.Drawing.Color.Red;
			this.lblLight2Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLight2Red.Location = new System.Drawing.Point(438, 226);
			this.lblLight2Red.Name = "lblLight2Red";
			this.lblLight2Red.Size = new System.Drawing.Size(59, 55);
			this.lblLight2Red.TabIndex = 59;
			this.lblLight2Red.Text = "R";
			this.lblLight2Red.Visible = false;
			// 
			// lblLight3Cars
			// 
			this.lblLight3Cars.AutoSize = true;
			this.lblLight3Cars.Location = new System.Drawing.Point(283, 67);
			this.lblLight3Cars.Name = "lblLight3Cars";
			this.lblLight3Cars.Size = new System.Drawing.Size(0, 20);
			this.lblLight3Cars.TabIndex = 62;
			// 
			// lblLight1Cars
			// 
			this.lblLight1Cars.AutoSize = true;
			this.lblLight1Cars.Location = new System.Drawing.Point(284, 432);
			this.lblLight1Cars.Name = "lblLight1Cars";
			this.lblLight1Cars.Size = new System.Drawing.Size(0, 20);
			this.lblLight1Cars.TabIndex = 63;
			// 
			// lblLight2Cars
			// 
			this.lblLight2Cars.AutoSize = true;
			this.lblLight2Cars.Location = new System.Drawing.Point(499, 290);
			this.lblLight2Cars.Name = "lblLight2Cars";
			this.lblLight2Cars.Size = new System.Drawing.Size(0, 20);
			this.lblLight2Cars.TabIndex = 64;
			// 
			// lblLight4Cars
			// 
			this.lblLight4Cars.AutoSize = true;
			this.lblLight4Cars.Location = new System.Drawing.Point(60, 290);
			this.lblLight4Cars.Name = "lblLight4Cars";
			this.lblLight4Cars.Size = new System.Drawing.Size(0, 20);
			this.lblLight4Cars.TabIndex = 65;
			// 
			// lblLightInfo
			// 
			this.lblLightInfo.AutoSize = true;
			this.lblLightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLightInfo.Location = new System.Drawing.Point(912, 23);
			this.lblLightInfo.Name = "lblLightInfo";
			this.lblLightInfo.Size = new System.Drawing.Size(164, 40);
			this.lblLightInfo.TabIndex = 8;
			this.lblLightInfo.Text = "Light Info";
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLog.Location = new System.Drawing.Point(240, 210);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(77, 40);
			this.lblLog.TabIndex = 9;
			this.lblLog.Text = "Log";
			// 
			// lblLightOneConnected
			// 
			this.lblLightOneConnected.AutoSize = true;
			this.lblLightOneConnected.Location = new System.Drawing.Point(340, 21);
			this.lblLightOneConnected.Name = "lblLightOneConnected";
			this.lblLightOneConnected.Size = new System.Drawing.Size(107, 20);
			this.lblLightOneConnected.TabIndex = 63;
			this.lblLightOneConnected.Text = "Disconnected";
			// 
			// lblLightTwoConnected
			// 
			this.lblLightTwoConnected.AutoSize = true;
			this.lblLightTwoConnected.Location = new System.Drawing.Point(330, 141);
			this.lblLightTwoConnected.Name = "lblLightTwoConnected";
			this.lblLightTwoConnected.Size = new System.Drawing.Size(107, 20);
			this.lblLightTwoConnected.TabIndex = 64;
			this.lblLightTwoConnected.Text = "Disconnected";
			// 
			// lblLightThreeConnected
			// 
			this.lblLightThreeConnected.AutoSize = true;
			this.lblLightThreeConnected.Location = new System.Drawing.Point(330, 266);
			this.lblLightThreeConnected.Name = "lblLightThreeConnected";
			this.lblLightThreeConnected.Size = new System.Drawing.Size(107, 20);
			this.lblLightThreeConnected.TabIndex = 65;
			this.lblLightThreeConnected.Text = "Disconnected";
			// 
			// lblLightFourConnected
			// 
			this.lblLightFourConnected.AutoSize = true;
			this.lblLightFourConnected.Location = new System.Drawing.Point(330, 401);
			this.lblLightFourConnected.Name = "lblLightFourConnected";
			this.lblLightFourConnected.Size = new System.Drawing.Size(107, 20);
			this.lblLightFourConnected.TabIndex = 66;
			this.lblLightFourConnected.Text = "Disconnected";
			// 
			// FormServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1360, 680);
			this.Controls.Add(this.lblLog);
			this.Controls.Add(this.lblLightInfo);
			this.Controls.Add(this.tabLightStatus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxLightIP);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.listBoxOutput);
			this.Controls.Add(this.buttonConnect);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormServer";
			this.Text = "Server (sort of)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabLightStatus.ResumeLayout(false);
			this.tabLightStatusPage.ResumeLayout(false);
			this.tabLightStatusPage.PerformLayout();
			this.tabLightLayoutPage.ResumeLayout(false);
			this.tabLightLayoutPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLayout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxLightIP;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabLightStatus;
		private System.Windows.Forms.TabPage tabLightStatusPage;
		private System.Windows.Forms.Label lblLightFourLabel;
		private System.Windows.Forms.Label lblLightFourAmber;
		private System.Windows.Forms.Label lblLightFourGreen;
		private System.Windows.Forms.Label lblLightFourRed;
		private System.Windows.Forms.Label lblLightThreeLabel;
		private System.Windows.Forms.Label lblLightThreeAmber;
		private System.Windows.Forms.Label lblLightThreeGreen;
		private System.Windows.Forms.Label lblLightThreeRed;
		private System.Windows.Forms.Label lblLightTwoLabel;
		private System.Windows.Forms.Label lblLightTwoAmber;
		private System.Windows.Forms.Label lblLightTwoGreen;
		private System.Windows.Forms.Label lblLightTwoRed;
		private System.Windows.Forms.Label lblLightOneLabel;
		private System.Windows.Forms.Label lblLightOneAmber;
		private System.Windows.Forms.Label lblLightOneGreen;
		private System.Windows.Forms.Label lblLightOneRed;
		private System.Windows.Forms.TabPage tabLightLayoutPage;
		private System.Windows.Forms.Label lblLight4Cars;
		private System.Windows.Forms.Label lblLight2Cars;
		private System.Windows.Forms.Label lblLight1Cars;
		private System.Windows.Forms.Label lblLight3Cars;
		private System.Windows.Forms.Label lblLight2Amber;
		private System.Windows.Forms.Label lblLight2Green;
		private System.Windows.Forms.Label lblLight2Red;
		private System.Windows.Forms.Label lblLight4Amber;
		private System.Windows.Forms.Label lblLight4Green;
		private System.Windows.Forms.Label lblLight4Red;
		private System.Windows.Forms.Label lblLight3Amber;
		private System.Windows.Forms.Label lblLight3Green;
		private System.Windows.Forms.Label lblLight3Red;
		private System.Windows.Forms.Label lblLight1Amber;
		private System.Windows.Forms.Label lblLight1Green;
		private System.Windows.Forms.Label lblLight1Red;
		private System.Windows.Forms.PictureBox picLayout;
		private System.Windows.Forms.Label lblLightInfo;
		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.Label lblLightFourConnected;
		private System.Windows.Forms.Label lblLightThreeConnected;
		private System.Windows.Forms.Label lblLightTwoConnected;
		private System.Windows.Forms.Label lblLightOneConnected;
	}
}

