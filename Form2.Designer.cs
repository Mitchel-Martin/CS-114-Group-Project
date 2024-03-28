namespace CS_114_Group_Project
{
    partial class Form2
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
            txtSelectInstruction = new TextBox();
            grpBoxPackage = new GroupBox();
            radBtnUltraPremium = new RadioButton();
            radBtnOmegaPremium = new RadioButton();
            radBtnPremiumPlus = new RadioButton();
            radBtnPremium = new RadioButton();
            radBtnStandardPremium = new RadioButton();
            radBtnStandard = new RadioButton();
            btnFakeClose = new Button();
            btnResults = new Button();
            cboHead = new ComboBox();
            cboLeftArm = new ComboBox();
            cboRightArm = new ComboBox();
            cboUpperTorso = new ComboBox();
            cboLeftLeg = new ComboBox();
            cboLowerTorso = new ComboBox();
            cboRightLeg = new ComboBox();
            grpBoxPackage.SuspendLayout();
            SuspendLayout();
            // 
            // txtSelectInstruction
            // 
            txtSelectInstruction.Location = new Point(102, 100);
            txtSelectInstruction.Multiline = true;
            txtSelectInstruction.Name = "txtSelectInstruction";
            txtSelectInstruction.ReadOnly = true;
            txtSelectInstruction.Size = new Size(438, 118);
            txtSelectInstruction.TabIndex = 0;
            txtSelectInstruction.Text = "Select from the drop-down lists for your current ailment.";
            // 
            // grpBoxPackage
            // 
            grpBoxPackage.Controls.Add(radBtnUltraPremium);
            grpBoxPackage.Controls.Add(radBtnOmegaPremium);
            grpBoxPackage.Controls.Add(radBtnPremiumPlus);
            grpBoxPackage.Controls.Add(radBtnPremium);
            grpBoxPackage.Controls.Add(radBtnStandardPremium);
            grpBoxPackage.Controls.Add(radBtnStandard);
            grpBoxPackage.Location = new Point(102, 224);
            grpBoxPackage.Name = "grpBoxPackage";
            grpBoxPackage.Size = new Size(417, 514);
            grpBoxPackage.TabIndex = 1;
            grpBoxPackage.TabStop = false;
            grpBoxPackage.Text = "Health Care Package Type:";
            grpBoxPackage.Enter += grpBoxPackage_Enter;
            // 
            // radBtnUltraPremium
            // 
            radBtnUltraPremium.AutoSize = true;
            radBtnUltraPremium.Location = new Point(55, 398);
            radBtnUltraPremium.Name = "radBtnUltraPremium";
            radBtnUltraPremium.Size = new Size(354, 36);
            radBtnUltraPremium.TabIndex = 5;
            radBtnUltraPremium.TabStop = true;
            radBtnUltraPremium.Text = "Ultra-Supreme Premium Plus";
            radBtnUltraPremium.UseVisualStyleBackColor = true;
            radBtnUltraPremium.CheckedChanged += radBtnUltraPremium_CheckedChanged;
            // 
            // radBtnOmegaPremium
            // 
            radBtnOmegaPremium.AutoSize = true;
            radBtnOmegaPremium.Location = new Point(55, 333);
            radBtnOmegaPremium.Name = "radBtnOmegaPremium";
            radBtnOmegaPremium.Size = new Size(226, 36);
            radBtnOmegaPremium.TabIndex = 4;
            radBtnOmegaPremium.TabStop = true;
            radBtnOmegaPremium.Text = "Omega Premium";
            radBtnOmegaPremium.UseVisualStyleBackColor = true;
            radBtnOmegaPremium.CheckedChanged += radBtnOmegaPremium_CheckedChanged;
            // 
            // radBtnPremiumPlus
            // 
            radBtnPremiumPlus.AutoSize = true;
            radBtnPremiumPlus.Location = new Point(55, 268);
            radBtnPremiumPlus.Name = "radBtnPremiumPlus";
            radBtnPremiumPlus.Size = new Size(191, 36);
            radBtnPremiumPlus.TabIndex = 3;
            radBtnPremiumPlus.TabStop = true;
            radBtnPremiumPlus.Text = "Premium Plus";
            radBtnPremiumPlus.UseVisualStyleBackColor = true;
            radBtnPremiumPlus.CheckedChanged += radBtnPremiumPlus_CheckedChanged;
            // 
            // radBtnPremium
            // 
            radBtnPremium.AutoSize = true;
            radBtnPremium.Location = new Point(55, 203);
            radBtnPremium.Name = "radBtnPremium";
            radBtnPremium.Size = new Size(141, 36);
            radBtnPremium.TabIndex = 2;
            radBtnPremium.TabStop = true;
            radBtnPremium.Text = "Premium";
            radBtnPremium.UseVisualStyleBackColor = true;
            radBtnPremium.CheckedChanged += radBtnPremium_CheckedChanged;
            // 
            // radBtnStandardPremium
            // 
            radBtnStandardPremium.AutoSize = true;
            radBtnStandardPremium.Location = new Point(55, 138);
            radBtnStandardPremium.Name = "radBtnStandardPremium";
            radBtnStandardPremium.Size = new Size(242, 36);
            radBtnStandardPremium.TabIndex = 1;
            radBtnStandardPremium.TabStop = true;
            radBtnStandardPremium.Text = "Standard Premium";
            radBtnStandardPremium.UseVisualStyleBackColor = true;
            radBtnStandardPremium.CheckedChanged += radBtnStandardPremium_CheckedChanged;
            // 
            // radBtnStandard
            // 
            radBtnStandard.AutoSize = true;
            radBtnStandard.Location = new Point(55, 73);
            radBtnStandard.Name = "radBtnStandard";
            radBtnStandard.Size = new Size(139, 36);
            radBtnStandard.TabIndex = 0;
            radBtnStandard.TabStop = true;
            radBtnStandard.Text = "Standard";
            radBtnStandard.UseVisualStyleBackColor = true;
            radBtnStandard.CheckedChanged += radBtnStandard_CheckedChanged;
            // 
            // btnFakeClose
            // 
            btnFakeClose.Location = new Point(179, 828);
            btnFakeClose.Name = "btnFakeClose";
            btnFakeClose.Size = new Size(340, 101);
            btnFakeClose.TabIndex = 2;
            btnFakeClose.Text = "Close";
            btnFakeClose.UseVisualStyleBackColor = true;
            btnFakeClose.Click += btnFakeClose_Click;
            // 
            // btnResults
            // 
            btnResults.Location = new Point(990, 828);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(340, 101);
            btnResults.TabIndex = 3;
            btnResults.Text = "Your Results";
            btnResults.UseVisualStyleBackColor = true;
            btnResults.Click += btnResults_Click;
            // 
            // cboHead
            // 
            cboHead.FormattingEnabled = true;
            cboHead.Location = new Point(910, 150);
            cboHead.Name = "cboHead";
            cboHead.Size = new Size(212, 40);
            cboHead.TabIndex = 4;
            cboHead.SelectedIndexChanged += cboHead_SelectedIndexChanged;
            // 
            // cboLeftArm
            // 
            cboLeftArm.FormattingEnabled = true;
            cboLeftArm.Location = new Point(702, 250);
            cboLeftArm.Name = "cboLeftArm";
            cboLeftArm.Size = new Size(212, 40);
            cboLeftArm.TabIndex = 5;
            cboLeftArm.SelectedIndexChanged += cboLeftArm_SelectedIndexChanged;
            // 
            // cboRightArm
            // 
            cboRightArm.FormattingEnabled = true;
            cboRightArm.Location = new Point(1118, 250);
            cboRightArm.Name = "cboRightArm";
            cboRightArm.Size = new Size(212, 40);
            cboRightArm.TabIndex = 6;
            cboRightArm.SelectedIndexChanged += cboRightArm_SelectedIndexChanged;
            // 
            // cboUpperTorso
            // 
            cboUpperTorso.FormattingEnabled = true;
            cboUpperTorso.Location = new Point(910, 335);
            cboUpperTorso.Name = "cboUpperTorso";
            cboUpperTorso.Size = new Size(212, 40);
            cboUpperTorso.TabIndex = 7;
            cboUpperTorso.SelectedIndexChanged += cboUpperTorso_SelectedIndexChanged;
            // 
            // cboLeftLeg
            // 
            cboLeftLeg.FormattingEnabled = true;
            cboLeftLeg.Location = new Point(702, 593);
            cboLeftLeg.Name = "cboLeftLeg";
            cboLeftLeg.Size = new Size(212, 40);
            cboLeftLeg.TabIndex = 8;
            cboLeftLeg.SelectedIndexChanged += cboLeftLeg_SelectedIndexChanged;
            // 
            // cboLowerTorso
            // 
            cboLowerTorso.FormattingEnabled = true;
            cboLowerTorso.Location = new Point(910, 444);
            cboLowerTorso.Name = "cboLowerTorso";
            cboLowerTorso.Size = new Size(212, 40);
            cboLowerTorso.TabIndex = 8;
            cboLowerTorso.SelectedIndexChanged += cboLowerTorso_SelectedIndexChanged;
            // 
            // cboRightLeg
            // 
            cboRightLeg.FormattingEnabled = true;
            cboRightLeg.Location = new Point(1118, 593);
            cboRightLeg.Name = "cboRightLeg";
            cboRightLeg.Size = new Size(212, 40);
            cboRightLeg.TabIndex = 9;
            cboRightLeg.SelectedIndexChanged += cboRightLeg_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 1095);
            Controls.Add(cboRightLeg);
            Controls.Add(cboLowerTorso);
            Controls.Add(cboLeftLeg);
            Controls.Add(cboUpperTorso);
            Controls.Add(cboRightArm);
            Controls.Add(cboLeftArm);
            Controls.Add(btnFakeClose);
            Controls.Add(cboHead);
            Controls.Add(btnResults);
            Controls.Add(grpBoxPackage);
            Controls.Add(txtSelectInstruction);
            Name = "Form2";
            Text = "Ailment Form";
            Load += Form2_Load;
            grpBoxPackage.ResumeLayout(false);
            grpBoxPackage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSelectInstruction;
        private GroupBox grpBoxPackage;
        private RadioButton radBtnUltraPremium;
        private RadioButton radBtnOmegaPremium;
        private RadioButton radBtnPremiumPlus;
        private RadioButton radBtnPremium;
        private RadioButton radBtnStandardPremium;
        private RadioButton radBtnStandard;
        private Button btnFakeClose;
        private Button btnResults;
        private ComboBox cboHead;
        private ComboBox cboLeftArm;
        private ComboBox cboRightArm;
        private ComboBox cboUpperTorso;
        private ComboBox cboLeftLeg;
        private ComboBox cboLowerTorso;
        private ComboBox cboRightLeg;
    }
}