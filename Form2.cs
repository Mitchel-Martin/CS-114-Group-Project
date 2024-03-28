using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_114_Group_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] heads = { "Head...", "Eye trauma", "Brain injury", "Face immolation", "Acid burns", "Mild headache", };
            foreach (string head in heads)
            {
                cboHead.Items.Add(head);
            }
            cboHead.SelectedIndex = 0;

            string[] leftarm = { "Left Arm...", "Broken arm", "Gunshot wound", "Severe fire burns", "Missing fingers", "Wooden splinter" };
            foreach (string left in leftarm)
            {
                cboLeftArm.Items.Add(left);
            }
            cboLeftArm.SelectedIndex = 0;


            string[] rightarm = { "Right Arm...", "Broken arm", "Gunshot wound", "Severe fire burns", "Missing fingers", "butter knife injury" };
            foreach (string right in rightarm)
            {
                cboRightArm.Items.Add(right);
            }
            cboRightArm.SelectedIndex = 0;

            string[] leftleg = { "Left Leg...", "shin splint", "dog bites", "shattered kneecap", "Small child attack", "Lost foot" };
            foreach (string left in leftleg)
            {
                cboLeftLeg.Items.Add(left);
            }
            cboLeftLeg.SelectedIndex = 0;

            string[] rightleg = { "Right Leg...", "Ketchup stain", "Gangreen", "Broken femur", "Jellyfish sting", "Severed artery" };
            foreach (string right in rightleg)
            {
                cboRightLeg.Items.Add(right);
            }
            cboRightLeg.SelectedIndex = 0;

            string[] torso = { "Upper Torso...", "Gunshot wound", "Heart attack", "Collapsed lung", "Difficulty breathing", "Knife injury" };
            foreach (string uppertorso in torso)
            {
                cboUpperTorso.Items.Add(uppertorso);
            }
            cboUpperTorso.SelectedIndex = 0;


            string[] lowertorso = { "Lower Torso...", "Starvation", "Acid reflux", "Hot coffee burns", "Broken pelvis", "Shark bite" };
            foreach (string lowertoro in lowertorso)
            {
                cboLowerTorso.Items.Add(lowertoro);
            }
            cboLowerTorso.SelectedIndex = 0;

        }

        private void radBtnStandard_CheckedChanged(object sender, EventArgs e)
        {
           ////____________________ADD Data to other buttons
            
            if (radBtnStandard.Checked)
                EnableControls();
            else
                DisableControls();
        }
        private void radBtnStandardPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnStandardPremium.Checked)
                EnableControls();
            else
                DisableControls();
        }

        private void radBtnPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnPremium.Checked)
                EnableControls();
            else
                DisableControls();
        }

        private void radBtnPremiumPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnPremiumPlus.Checked)
                EnableControls();
            else
                DisableControls();
        }

        private void radBtnOmegaPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnOmegaPremium.Checked)
                EnableControls();
            else
                DisableControls();
        }

        private void radBtnUltraPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnUltraPremium.Checked)
                EnableControls();
            else
                DisableControls();
        }

        private void EnableControls() {
            radBtnStandard.Enabled = true;
            radBtnStandardPremium.Enabled = true;
            radBtnPremium.Enabled = true;
            radBtnPremiumPlus.Enabled = true;
            radBtnOmegaPremium.Enabled = true;
            radBtnUltraPremium.Enabled = true;
        }
        private void DisableControls()
        {
            radBtnStandard.Enabled = false;
            radBtnStandardPremium.Enabled = false;
            radBtnPremium.Enabled = false;
            radBtnPremiumPlus.Enabled = false;
            radBtnOmegaPremium.Enabled = false;
            radBtnUltraPremium.Enabled = false;
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            //go to final form from here
        }

        private void btnFakeClose_Click(object sender, EventArgs e)
        {
            //does nothing
        }

        private void grpBoxPackage_Enter(object sender, EventArgs e)
        {
            //GroupBox here
        }

        private void cboHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Head combo box
        }

        private void cboLeftArm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //left arm combo box
        }

        private void cboRightArm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //right arm combo box
        }

        private void cboUpperTorso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //upper torso combo box
        }

        private void cboLowerTorso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lower torso combo box
        }

        private void cboLeftLeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            //left leg combo box
        }

        private void cboRightLeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Right leg combo box
        }

    }
}
