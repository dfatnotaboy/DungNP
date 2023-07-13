namespace Palletizer
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTBUser = new System.Windows.Forms.ToolStripTextBox();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlPaneltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIASToolStripMenuItem,
            this.ControlPaneltoolStripMenuItem,
            this.settingToolStripMenuItem,
            this.connecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vIASToolStripMenuItem
            // 
            this.vIASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTBUser,
            this.signOutToolStripMenuItem});
            this.vIASToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.vIASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.vIASToolStripMenuItem.Name = "vIASToolStripMenuItem";
            this.vIASToolStripMenuItem.Size = new System.Drawing.Size(57, 36);
            this.vIASToolStripMenuItem.Text = "VIAS";
          
            // 
            // toolStripTBUser
            // 
            this.toolStripTBUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTBUser.Name = "toolStripTBUser";
            this.toolStripTBUser.Size = new System.Drawing.Size(100, 27);
            this.toolStripTBUser.Text = "User ID";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.signOutToolStripMenuItem.Text = "SignOut";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // ControlPaneltoolStripMenuItem
            // 
            this.ControlPaneltoolStripMenuItem.Name = "ControlPaneltoolStripMenuItem";
            this.ControlPaneltoolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.ControlPaneltoolStripMenuItem.Text = "Control Panel";
            this.ControlPaneltoolStripMenuItem.Click += new System.EventHandler(this.ControlPaneltoolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(70, 36);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // connecToolStripMenuItem
            // 
            this.connecToolStripMenuItem.Name = "connecToolStripMenuItem";
            this.connecToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.connecToolStripMenuItem.Text = "Connect";
            this.connecToolStripMenuItem.Click += new System.EventHandler(this.connecToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMain.BackgroundImage = global::Palletizer.Properties.Resources.screenshot_1689127909;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(781, 513);
            this.pnlMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Palletizer-Main";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connecToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTBUser;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem ControlPaneltoolStripMenuItem;
    }
}