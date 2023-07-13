using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Palletizer
{
    public partial class MainForm : Form
    {
        public bool isExit = true;
        private Form activeForm;
        

        public MainForm()
        {

            InitializeComponent();
            AccessForm dng1access = new AccessForm();
            toolStripTBUser.Text = dng1access.user;

        }
        
       
        private void OpenMainbranchForm(Form mainBranchForm, object btnsender)
        {
            if (btnsender != null)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                activeForm = mainBranchForm;

                mainBranchForm.Dock = DockStyle.Fill;
                mainBranchForm.TopLevel = false;
                mainBranchForm.FormBorderStyle = FormBorderStyle.None;
                pnlMain.Controls.Add(mainBranchForm);
                mainBranchForm.Show();
            }
        }
        //        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (isExit)
        //    {
        //        if (MessageBox.Show("Do you want exit Palletizer ?", "Waring", MessageBoxButtons.YesNo) != DialogResult.Yes)
        //        {
        //            e.Cancel = true;
        //        }
        //    }
        //}
        //private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    if (isExit)
        //    {
        //        Application.Exit();
        //    }
        //}

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessForm dngAccses = new AccessForm();
            dngAccses.Show();
            isExit = false;
            this.Close();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMainbranchForm(new Setting(), sender);
        }

        private void connecToolStripMenuItem_Click(object sender, EventArgs e)
        {
           OpenMainbranchForm(new Connect(),  sender);

        }
        private void ControlPaneltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMainbranchForm( new Screen_Main_Form.Control(), sender);
        }

    }

}
