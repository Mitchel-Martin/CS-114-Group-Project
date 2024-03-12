namespace CS_114_Group_Project
{
    partial class frmHealthWellness
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCreditCardInfo = new Label();
            txtCardNumber = new TextBox();
            lblCardNumber = new Label();
            lblCCV = new Label();
            lblExpiration = new Label();
            txtCCV = new TextBox();
            cboMonth = new ComboBox();
            cboDay = new ComboBox();
            cboYear = new ComboBox();
            lblPersonalInfo = new Label();
            lblName = new Label();
            label2 = new Label();
            lblSSN = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            txtSSN = new TextBox();
            txtAddress = new TextBox();
            txtAddInfo = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            btnGetStarted = new Button();
            SuspendLayout();
            // 
            // lblCreditCardInfo
            // 
            lblCreditCardInfo.AutoSize = true;
            lblCreditCardInfo.Location = new Point(484, 55);
            lblCreditCardInfo.Name = "lblCreditCardInfo";
            lblCreditCardInfo.Size = new Size(382, 32);
            lblCreditCardInfo.TabIndex = 0;
            lblCreditCardInfo.Text = "Enter Your Credit Card Information";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(653, 133);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(375, 39);
            txtCardNumber.TabIndex = 1;
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Location = new Point(241, 140);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(339, 32);
            lblCardNumber.TabIndex = 3;
            lblCardNumber.Text = "Enter your credit card number:";
            // 
            // lblCCV
            // 
            lblCCV.AutoSize = true;
            lblCCV.Location = new Point(241, 197);
            lblCCV.Name = "lblCCV";
            lblCCV.Size = new Size(271, 32);
            lblCCV.TabIndex = 4;
            lblCCV.Text = "Enter your CCV number:";
            // 
            // lblExpiration
            // 
            lblExpiration.AutoSize = true;
            lblExpiration.Location = new Point(241, 259);
            lblExpiration.Name = "lblExpiration";
            lblExpiration.Size = new Size(282, 32);
            lblExpiration.TabIndex = 5;
            lblExpiration.Text = "Enter the Expiration date:";
            // 
            // txtCCV
            // 
            txtCCV.Location = new Point(653, 194);
            txtCCV.Name = "txtCCV";
            txtCCV.Size = new Size(129, 39);
            txtCCV.TabIndex = 6;
            // 
            // cboMonth
            // 
            cboMonth.FormattingEnabled = true;
            cboMonth.Location = new Point(810, 256);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(218, 40);
            cboMonth.TabIndex = 7;
            // 
            // cboDay
            // 
            cboDay.FormattingEnabled = true;
            cboDay.Location = new Point(1057, 256);
            cboDay.Name = "cboDay";
            cboDay.Size = new Size(125, 40);
            cboDay.TabIndex = 8;
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(653, 256);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(129, 40);
            cboYear.TabIndex = 9;
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.AutoSize = true;
            lblPersonalInfo.Location = new Point(498, 344);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(351, 32);
            lblPersonalInfo.TabIndex = 10;
            lblPersonalInfo.Text = "Enter Your Personal Information";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(241, 420);
            lblName.Name = "lblName";
            lblName.Size = new Size(295, 32);
            lblName.TabIndex = 11;
            lblName.Text = "Enter your full legal name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 562);
            label2.Name = "label2";
            label2.Size = new Size(300, 32);
            label2.TabIndex = 12;
            label2.Text = "Enter your current address:";
            // 
            // lblSSN
            // 
            lblSSN.AutoSize = true;
            lblSSN.Location = new Point(241, 487);
            lblSSN.Name = "lblSSN";
            lblSSN.Size = new Size(385, 32);
            lblSSN.TabIndex = 13;
            lblSSN.Text = "Enter your Social Security Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 630);
            label4.Name = "label4";
            label4.Size = new Size(685, 32);
            label4.TabIndex = 14;
            label4.Text = "Enter any other Personal information you are willing to donate:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(653, 417);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(529, 39);
            txtFullName.TabIndex = 15;
            // 
            // txtSSN
            // 
            txtSSN.Location = new Point(653, 484);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(529, 39);
            txtSSN.TabIndex = 16;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(653, 559);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(529, 39);
            txtAddress.TabIndex = 17;
            // 
            // txtAddInfo
            // 
            txtAddInfo.Location = new Point(241, 690);
            txtAddInfo.Name = "txtAddInfo";
            txtAddInfo.Size = new Size(941, 39);
            txtAddInfo.TabIndex = 19;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(595, 779);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(233, 97);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(949, 779);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(233, 97);
            btnExit.TabIndex = 21;
            btnExit.Text = "Save and Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnGetStarted
            // 
            btnGetStarted.Location = new Point(241, 779);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(233, 97);
            btnGetStarted.TabIndex = 22;
            btnGetStarted.Text = "Get Started";
            btnGetStarted.UseVisualStyleBackColor = true;
            btnGetStarted.Click += btnGetStarted_Click;
            // 
            // frmHealthWellness
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 1247);
            Controls.Add(btnGetStarted);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtAddInfo);
            Controls.Add(txtAddress);
            Controls.Add(txtSSN);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(lblSSN);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(lblPersonalInfo);
            Controls.Add(cboYear);
            Controls.Add(cboDay);
            Controls.Add(cboMonth);
            Controls.Add(txtCCV);
            Controls.Add(lblExpiration);
            Controls.Add(lblCCV);
            Controls.Add(lblCardNumber);
            Controls.Add(txtCardNumber);
            Controls.Add(lblCreditCardInfo);
            Name = "frmHealthWellness";
            Text = "Health and Wellness App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreditCardInfo;
        private TextBox txtCardNumber;
        private Label lblCardNumber;
        private Label lblCCV;
        private Label lblExpiration;
        private TextBox txtCCV;
        private ComboBox cboMonth;
        private ComboBox cboDay;
        private ComboBox cboYear;
        private Label lblPersonalInfo;
        private Label lblName;
        private Label label2;
        private Label lblSSN;
        private Label label4;
        private TextBox txtFullName;
        private TextBox txtSSN;
        private TextBox txtAddress;
        private TextBox txtAddInfo;
        private Button btnClear;
        private Button btnExit;
        private Button btnGetStarted;
    }
}
