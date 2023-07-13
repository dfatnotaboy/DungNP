namespace Palletizer
{
    partial class Connect
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pnlConnect = new System.Windows.Forms.Panel();
            this.btD200 = new System.Windows.Forms.Button();
            this.tbD200 = new System.Windows.Forms.TextBox();
            this.pnlConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 50);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(135, 12);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(384, 22);
            this.tbIP.TabIndex = 2;
            this.tbIP.TabStop = false;
            this.tbIP.Text = "192.168.0.11";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(135, 40);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(384, 22);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "502";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(525, 19);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(140, 31);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Status......";
            // 
            // pnlConnect
            // 
            this.pnlConnect.Controls.Add(this.tbD200);
            this.pnlConnect.Controls.Add(this.btD200);
            this.pnlConnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConnect.Location = new System.Drawing.Point(0, 76);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Size = new System.Drawing.Size(800, 418);
            this.pnlConnect.TabIndex = 5;
            // 
            // btD200
            // 
            this.btD200.Location = new System.Drawing.Point(28, 83);
            this.btD200.Name = "btD200";
            this.btD200.Size = new System.Drawing.Size(101, 46);
            this.btD200.TabIndex = 0;
            this.btD200.Text = "D200";
            this.btD200.UseVisualStyleBackColor = true;
            this.btD200.Click += new System.EventHandler(this.btD200_Click);
            // 
            // tbD200
            // 
            this.tbD200.Location = new System.Drawing.Point(154, 95);
            this.tbD200.Name = "tbD200";
            this.tbD200.Size = new System.Drawing.Size(277, 22);
            this.tbD200.TabIndex = 1;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.pnlConnect);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.btnConnect);
            this.Name = "Connect";
            this.Text = "Connect";
            this.pnlConnect.ResumeLayout(false);
            this.pnlConnect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel pnlConnect;
        private System.Windows.Forms.TextBox tbD200;
        private System.Windows.Forms.Button btD200;
    }
}