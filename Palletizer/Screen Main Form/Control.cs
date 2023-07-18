using Palletizer.ClassUsed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palletizer.Screen_Main_Form
{
    public partial class Control : Form
    {
        int xBox;
        int yBox;
        int xPallet;
        int yPallet;
        int i = 0;
        Panel panel = new Panel();
        public Control()

        {
            InitializeComponent();
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingArea.Width, workingArea.Height);
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
            xBox = (Convert.ToInt32(values[1])/2);
            yBox = (Convert.ToInt32(values[2])/2);
            xPallet = (Convert.ToInt32(values[4]) / 2);
            yPallet = (Convert.ToInt32(values[5]) / 2);
            pnlWork.Size=new Size(xPallet,yPallet);
        }

        private void btnAddBox_Click(object sender, EventArgs e)
        {
            if (cbSelectProject.Text != "")
            {
                i++;
                Box box = new Box(xBox, yBox, i.ToString());
                box.Location = new Point((xPallet/2),(yPallet/2));
                box.BringToFront();
                box.listBoxs.Add(box);
                foreach (Box boxs  in box.listBoxs)
                {
                pnlWork.Controls.Add(boxs);
                }
            }
            else
            {
                MessageBox.Show("Please choose project !! ");
            }
       
        }
    }
}
