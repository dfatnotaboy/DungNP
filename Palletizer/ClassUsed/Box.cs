using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Palletizer.ClassUsed
{
    public class Box : Panel
    {
        private int a;
        public int A { get => a; set => a = value; }

        private int b;
        public int B { get => b; set => b = value; }

        private Button btnRotary;
        private Button btnClose;
        private Label lblbox;
        private bool isSwapped;
        int aaa;
        int bbb;
        public int ccc;
        public int ddd;
        Control control=new Control();
        private bool isDragging = false;
        private int mouseOffsetX;
        private int mouseOffsetY;
        public List<Box> listBoxs = new List<Box>();
        
        public Box(int Aa, int Bb, string c)
        {

            isSwapped = true;
            this.A = aaa = Aa;
            this.B = bbb = Bb;

            this.Size = new Size(Aa, Bb);
            this.BackColor = Color.FromArgb(153, 180, 209);
            this.Name = "box" + c;
            this.MouseDown += Box_MouseDown;
            this.MouseUp += Box_MouseUp;
            this.MouseMove += Box_MouseMove;

            lblbox = new Label();
            lblbox.Text = "box" + c;
            lblbox.Location = new Point(0, 0);
            this.Controls.Add(lblbox);

            btnClose = new Button();
            btnClose.Text = "X";
            btnClose.BackColor = Color.Red;
            btnClose.Size = new Size(30, 20);
            btnClose.Location = new Point(0, 20);
            btnClose.Click += new EventHandler(btnClose_Click);
            this.Controls.Add(btnClose);

            btnRotary = new Button();
            btnRotary.Text = "R";
            btnRotary.Size = new System.Drawing.Size(30, 20);
            btnRotary.Location = new Point(0,40);
            btnRotary.Click += new EventHandler(btnRotary_Click);
            this.Controls.Add(btnRotary);


        }

        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                
                Box box1 = (Box)sender;
                // Lấy tọa độ hiện tại của chuột trên Form
                int mouseX = e.X + box1.Left - mouseOffsetX;
                int mouseY = e.Y + box1.Top - mouseOffsetY;

                if (mouseX<0)
                {
                    mouseX = 0;
                }
                
                if (mouseY<0)
                {
                    mouseY = 0;
                }
                
                // Di chuyển Label tới vị trí mới
                box1.Left = mouseX;
                box1.Top = mouseY;
                ccc = mouseX;
                ddd= mouseY;
            }
        }

        private void Box_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;

                mouseOffsetX = e.X;
                mouseOffsetY = e.Y;
            }
        }

        private void btnRotary_Click(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.Y, this.ClientSize.Width - this.Width - this.Location.X);
            this.Size = new Size(this.Height, this.Width);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Control control = new Control();
            this.Parent.Controls.Remove(this);
            Box boxs = (sender as Button).Parent as Box;
            control.Controls.Remove(boxs);
            listBoxs.Remove(boxs);

          
        }

    }
}
