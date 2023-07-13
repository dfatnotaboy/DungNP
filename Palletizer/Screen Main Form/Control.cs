using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palletizer.Screen_Main_Form
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
            string[] files = Directory.GetFiles(Application.StartupPath, "*.txt");

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                cbSelectProject.Items.Add(fileName);
            }
        }

        private void cbSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = (string)cbSelectProject.SelectedItem;
            string filePath = Path.Combine(Application.StartupPath, fileName);

            // Đọc dữ liệu từ file và hiển thị lên form
            string data = File.ReadAllText(filePath);
            string[] values = data.Split('\n');
            string a = values[0];
            txtData.Text = data+a;
        }
    }
}
