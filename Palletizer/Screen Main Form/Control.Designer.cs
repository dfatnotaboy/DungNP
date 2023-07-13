namespace Palletizer.Screen_Main_Form
{
    partial class Control
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
            this.pnlWork = new System.Windows.Forms.Panel();
            this.tbLocationX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLocationY = new System.Windows.Forms.TextBox();
            this.cbSelectProject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pnlFloor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.pnlWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWork
            // 
            this.pnlWork.Controls.Add(this.txtData);
            this.pnlWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWork.Location = new System.Drawing.Point(0, 0);
            this.pnlWork.Name = "pnlWork";
            this.pnlWork.Size = new System.Drawing.Size(509, 450);
            this.pnlWork.TabIndex = 5;
            // 
            // tbLocationX
            // 
            this.tbLocationX.Location = new System.Drawing.Point(121, 190);
            this.tbLocationX.Name = "tbLocationX";
            this.tbLocationX.Size = new System.Drawing.Size(137, 22);
            this.tbLocationX.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "X (Location)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y (Location)";
            // 
            // tbLocationY
            // 
            this.tbLocationY.Location = new System.Drawing.Point(121, 218);
            this.tbLocationY.Name = "tbLocationY";
            this.tbLocationY.Size = new System.Drawing.Size(137, 22);
            this.tbLocationY.TabIndex = 8;
            // 
            // cbSelectProject
            // 
            this.cbSelectProject.FormattingEnabled = true;
            this.cbSelectProject.Location = new System.Drawing.Point(121, 10);
            this.cbSelectProject.Name = "cbSelectProject";
            this.cbSelectProject.Size = new System.Drawing.Size(137, 24);
            this.cbSelectProject.TabIndex = 10;
            this.cbSelectProject.SelectedIndexChanged += new System.EventHandler(this.cbSelectProject_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Project";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Palletizer.Properties.Resources.icons8_pallet_100;
            this.pictureBox1.Location = new System.Drawing.Point(21, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.AutoSize = true;
            this.btnDown.Image = global::Palletizer.Properties.Resources.icons8_down_60;
            this.btnDown.Location = new System.Drawing.Point(116, 342);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 66);
            this.btnDown.TabIndex = 4;
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.AutoSize = true;
            this.btnRight.Image = global::Palletizer.Properties.Resources.icons8_right_60;
            this.btnRight.Location = new System.Drawing.Point(197, 342);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 66);
            this.btnRight.TabIndex = 3;
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSize = true;
            this.btnLeft.Image = global::Palletizer.Properties.Resources.icons8_left_60;
            this.btnLeft.Location = new System.Drawing.Point(35, 342);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 66);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.AutoSize = true;
            this.btnUp.Image = global::Palletizer.Properties.Resources.icons8_up_60;
            this.btnUp.Location = new System.Drawing.Point(116, 267);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 68);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // pnlFloor
            // 
            this.pnlFloor.Location = new System.Drawing.Point(158, 99);
            this.pnlFloor.Name = "pnlFloor";
            this.pnlFloor.Size = new System.Drawing.Size(100, 22);
            this.pnlFloor.TabIndex = 13;
            this.pnlFloor.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Floor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Next Floor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnlFloor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSelectProject);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbLocationY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbLocationX);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(509, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 450);
            this.panel1.TabIndex = 16;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(109, 81);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(206, 216);
            this.txtData.TabIndex = 0;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlWork);
            this.Controls.Add(this.panel1);
            this.Name = "Control";
            this.Text = "Control";
            this.pnlWork.ResumeLayout(false);
            this.pnlWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Panel pnlWork;
        private System.Windows.Forms.TextBox tbLocationX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLocationY;
        private System.Windows.Forms.ComboBox cbSelectProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pnlFloor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtData;
    }
}