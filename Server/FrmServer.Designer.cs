namespace Server
{
    partial class FrmServer
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
            btnStart = new Button();
            btnStop = new Button();
            lblServerStatus = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(133, 180);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(375, 180);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lblServerStatus
            // 
            lblServerStatus.AutoSize = true;
            lblServerStatus.Font = new Font("Segoe UI", 12F);
            lblServerStatus.Location = new Point(243, 134);
            lblServerStatus.Name = "lblServerStatus";
            lblServerStatus.Size = new Size(194, 28);
            lblServerStatus.TabIndex = 2;
            lblServerStatus.Text = "Server je zaustavljen!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(241, 36, 71);
            label1.Location = new Point(168, 134);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 3;
            label1.Text = "Status:";
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 340);
            Controls.Add(label1);
            Controls.Add(lblServerStatus);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "FrmServer";
            Text = "Serverska Forma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblServerStatus;
        private Label label1;
    }
}