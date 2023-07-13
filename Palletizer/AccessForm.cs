using EasyModbus;
using Palletizer.ClassUsed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
namespace Palletizer
{

    public partial class AccessForm : Form
    {
        List<AccountsClass> Accounts = ListAccountClass.Instance.ListAccounts;
        public string user; 
       
        public AccessForm()
        {
            InitializeComponent();
            user=tbAccount.Text;
       
        }
        private void CheckSignIn(object btnsender)
        {
            if (btnsender != null)
            {
                if (tbAccount.Text == "" && tbPassword.Text == "")
                {
                    MessageBox.Show("Please enter your Account", "Warning!!");
                }
                else
                {

                    SignUpForm signUpForm = new SignUpForm();
                    AccountsClass[] signUpAccount = new AccountsClass[50];
                    signUpAccount = signUpForm.SignUpAcc;
                    int c = signUpForm.count;
                    bool found = false;
                    for (int i = 0; i < Accounts.Count; i++)
                    {
                        if (Accounts[i].UserNameClass == tbAccount.Text && Accounts[i].PassWordClass == tbPassword.Text)
                        {

                            found = true;
                            break;
                        }
                    }
                    for (int i = 0; i < c; i++)
                    {
                        if (signUpAccount[i].UserNameClass == tbAccount.Text && signUpAccount[i].PassWordClass == tbPassword.Text)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        MainForm DngMainForm = new MainForm();
                        this.Hide();
                        DngMainForm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your account is wrong, please re-enter", "Warning!!");
                        tbAccount.Text = "";
                        tbPassword.Text = "";
                        tbAccount.Focus();
                    }
                }

            }

        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            CheckSignIn(sender);
            user=tbAccount.Text;
            tbPassword.Text = "";
        }
        private void btnToSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm DngSignUp = new SignUpForm();
            this.Hide();
            DngSignUp.ShowDialog();
            this.Show();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccessForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Do you want exit Palletizer ?", "Waring", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
