using Palletizer.ClassUsed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Palletizer
{

    public partial class SignUpForm : Form
    {
        public bool issExit = true;
        public int count;
        public AccountsClass[] SignUpAcc = new AccountsClass[50];
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void SignUptoList(object btnsender)
        {
            if (btnsender != null)
            {
                if (tbPassWord.Text == "" && tbUserName.Text == "")
                {
                    MessageBox.Show("Account or password empty, please enter", "Warning!!");
                    tbUserName.Text = string.Empty;
                    tbPassWord.Text = string.Empty;
                    tbUserName.Focus();
                }
                else
                {
                    if (tbCode.Text == "1108")
                    {
                        string username = tbUserName.Text;
                        string password = tbPassWord.Text;
                        AccountsClass accountsClass = new AccountsClass(username, password);
                        accountsClass.UserNameClass = username;
                        accountsClass.PassWordClass = password;
                        SignUpAcc[count] = accountsClass;
                        count++;
                        MessageBox.Show("Sign up completed !");
                        issExit = false;                        
                    }
                    else
                    {
                        MessageBox.Show("Software code empty, please enter", "Warning!!");
                        tbCode.Focus();
                    }
                }
            }

        }
        //private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (issExit)
        //    {
        //        if (MessageBox.Show("Do you want exit Palletizer ?", "Waring", MessageBoxButtons.YesNo) != DialogResult.Yes)
        //        {
        //            e.Cancel = true;

        //        }
        //    }
        //}
        private void btnBackAccess_Click(object sender, EventArgs e)
        {
            AccessForm DngAccessForm = new AccessForm();
            DngAccessForm.Show();
            issExit = false;
            this.Close();
        }

        //private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    if (issExit)
        //    {
        //        Application.Exit();

        //    }
        //}

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUptoList(sender);
        }
    }
}

