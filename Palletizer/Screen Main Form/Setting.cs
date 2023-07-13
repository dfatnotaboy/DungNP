using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Palletizer
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            string[] files = Directory.GetFiles(Application.StartupPath, "*.txt");
            ListBoxProducts.Items.AddRange(files);
        }
       
        private void CheckTextBox(object btnsender, KeyPressEventArgs e)
        {
            if (btnsender != null)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            string name = tbNameProject.Text;
            float xBox = Convert.ToSingle(tbXBox.Text);
            float yBox = Convert.ToSingle(tbYBox.Text);
            float zBox = Convert.ToSingle(tbZBox.Text);
            float xPallet = Convert.ToSingle(tbXPallet.Text);
            float yPallet = Convert.ToSingle(tbYPallet.Text);
            float zPallet = Convert.ToSingle(tbZPallet.Text);

            string fileName = name + ".txt";
            string filePath = Path.Combine(Application.StartupPath, fileName);

            string[] lines = { name, Convert.ToString(xBox), Convert.ToString(yBox), Convert.ToString(zBox), Convert.ToString(xBox), Convert.ToString(xPallet), Convert.ToString(yPallet), Convert.ToString(zPallet) };

            File.WriteAllText(filePath, string.Join(Environment.NewLine, lines));

            MessageBox.Show("Save Done: " + fileName);


        }

        private void tbXBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckTextBox(sender, e);
        }

        private void tbYBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckTextBox(sender, e);
        }

        private void tbZBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckTextBox(sender, e);
        }

        private void tbXPallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckTextBox(sender, e);
        }

        private void tbYPallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckTextBox(sender, e);
        }

        private void tbZPallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckTextBox(sender, e);
        }
    }
}
