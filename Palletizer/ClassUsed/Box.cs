using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace Palletizer.ClassUsed
{
    public class Box : Panel
    {
        private Button btnRotary;
        private Button btnClose;
        private Label lblbox;
        private bool isSwapped;
        private bool isDragging = false;
        private int mouseOffsetX;
        private int mouseOffsetY;
        private Point limitUpperBound;
        private Point limitLowerBound;
        private int ii = 0;
        private int iii = 0;
        private Panel pnl;
        public List<Panel> listBoxCoordinate = new List<Panel>();
        Control control=new Control();


        public Box(int Aa, int Bb, string c, Point upperBound, Point lowerBound, Panel pnlWork, int total)
       

        {
            
            this.pnl= pnlWork;
            limitUpperBound = upperBound;
            limitLowerBound = lowerBound;
            isSwapped = true;
            this.Size = new Size(Aa, Bb);
            this.BackColor = Color.FromArgb(153, 180, 209);
            this.Name = "box" + c;
            this.MouseDown += Box_MouseDown;
            this.MouseUp += Box_MouseUp;
            this.MouseMove += Box_MouseMove;
            iii = total;


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
            btnRotary.Location = new Point(0, 40);
            btnRotary.Click += new EventHandler(btnRotary_Click);
            this.Controls.Add(btnRotary);

            listBoxCoordinate.Add(this);
            foreach (Panel locatin in listBoxCoordinate)
            {

            }
        }


        private void Box_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {

                Box box1 = (Box)sender;
                // Lấy tọa độ hiện tại của chuột trên Form
                int mouseX = e.X + box1.Left - mouseOffsetX;
                int mouseY = e.Y + box1.Top - mouseOffsetY;
                mouseX = Math.Max(limitLowerBound.X, Math.Min(mouseX, limitUpperBound.X - Width));
                mouseY = Math.Max(limitLowerBound.Y, Math.Min(mouseY, limitUpperBound.Y - Height));
                box1.Left = mouseX;
                box1.Top = mouseY;
                locationMove(new Point(Left, Top));
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
            this.Location = new Point(this.Location.X, this.Location.Y);
            this.Size = new Size(this.Height, this.Width);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Control control = new Control();
            this.Parent.Controls.Remove(this);
            Box boxs = (sender as Button).Parent as Box;
            ii = boxs.TabIndex;
            control.Controls.Remove(boxs);
            UpdateBoxOrderText();

        }
        private void locationMove(Point location)
        {
            PanelMoved?.Invoke(this, location);
        }
        public event EventHandler<Point> PanelMoved;
        private void UpdateBoxOrderText()
        {
            //if (ii<iii)
           // {
            // Duyệt qua danh sách các panel con trong mainPanel.Controls
            for (int i = ii; i <= pnl.Controls.Count ; i++)
            {
                Panel panel = pnl.Controls[i] as Panel;
                if (panel != null)
                {
                    // Cập nhật lại text thứ tự cho panel con
                    int order = i - 1;
                    panel.Text = "box " + order;
                }
            }

            //}
        }

    }
}