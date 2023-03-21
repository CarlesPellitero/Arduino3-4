
namespace Sprint6_Pellitero_Carles
{
    partial class QRGenerator
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
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.btnGnQR = new System.Windows.Forms.Button();
            this.ptbQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxLogin
            // 
            this.tbxLogin.AcceptsReturn = true;
            this.tbxLogin.Location = new System.Drawing.Point(107, 51);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(133, 22);
            this.tbxLogin.TabIndex = 0;
            this.tbxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxLogin_KeyDown);
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(270, 51);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.ReadOnly = true;
            this.tbxUser.Size = new System.Drawing.Size(374, 22);
            this.tbxUser.TabIndex = 1;
            this.tbxUser.TabStop = false;
            // 
            // tbxInfo
            // 
            this.tbxInfo.Location = new System.Drawing.Point(107, 117);
            this.tbxInfo.MaxLength = 100;
            this.tbxInfo.Multiline = true;
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Size = new System.Drawing.Size(537, 230);
            this.tbxInfo.TabIndex = 2;
            // 
            // btnGnQR
            // 
            this.btnGnQR.Location = new System.Drawing.Point(676, 45);
            this.btnGnQR.Name = "btnGnQR";
            this.btnGnQR.Size = new System.Drawing.Size(134, 35);
            this.btnGnQR.TabIndex = 3;
            this.btnGnQR.Text = "Generar QR";
            this.btnGnQR.UseVisualStyleBackColor = true;
            this.btnGnQR.Visible = false;
            this.btnGnQR.Click += new System.EventHandler(this.btnGnQR_Click);
            // 
            // ptbQR
            // 
            this.ptbQR.Location = new System.Drawing.Point(107, 368);
            this.ptbQR.Name = "ptbQR";
            this.ptbQR.Size = new System.Drawing.Size(537, 225);
            this.ptbQR.TabIndex = 4;
            this.ptbQR.TabStop = false;
            // 
            // QRGenerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1013, 616);
            this.Controls.Add(this.ptbQR);
            this.Controls.Add(this.btnGnQR);
            this.Controls.Add(this.tbxInfo);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.tbxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QRGenerator";
            this.Text = "QRGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxInfo;
        private System.Windows.Forms.Button btnGnQR;
        private System.Windows.Forms.PictureBox ptbQR;
    }
}