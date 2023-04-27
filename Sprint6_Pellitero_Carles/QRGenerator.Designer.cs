
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxLogin
            // 
            this.tbxLogin.AcceptsReturn = true;
            this.tbxLogin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogin.Location = new System.Drawing.Point(127, 117);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(164, 28);
            this.tbxLogin.TabIndex = 0;
            this.tbxLogin.Enter += new System.EventHandler(this.tbxLogin_Enter);
            this.tbxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxLogin_KeyDown);
            // 
            // tbxUser
            // 
            this.tbxUser.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(351, 117);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.ReadOnly = true;
            this.tbxUser.Size = new System.Drawing.Size(468, 28);
            this.tbxUser.TabIndex = 1;
            this.tbxUser.TabStop = false;
            // 
            // tbxInfo
            // 
            this.tbxInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInfo.Location = new System.Drawing.Point(164, 221);
            this.tbxInfo.MaxLength = 100;
            this.tbxInfo.Multiline = true;
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Size = new System.Drawing.Size(692, 255);
            this.tbxInfo.TabIndex = 2;
            // 
            // btnGnQR
            // 
            this.btnGnQR.Location = new System.Drawing.Point(853, 111);
            this.btnGnQR.Name = "btnGnQR";
            this.btnGnQR.Size = new System.Drawing.Size(134, 35);
            this.btnGnQR.TabIndex = 3;
            this.btnGnQR.Text = "Generated QR";
            this.btnGnQR.UseVisualStyleBackColor = true;
            this.btnGnQR.Visible = false;
            this.btnGnQR.Click += new System.EventHandler(this.btnGnQR_Click);
            // 
            // ptbQR
            // 
            this.ptbQR.Location = new System.Drawing.Point(351, 524);
            this.ptbQR.Name = "ptbQR";
            this.ptbQR.Size = new System.Drawing.Size(373, 219);
            this.ptbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbQR.TabIndex = 4;
            this.ptbQR.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Death Star", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "QR Generator";
            // 
            // QRGenerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1135, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbQR);
            this.Controls.Add(this.btnGnQR);
            this.Controls.Add(this.tbxInfo);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.tbxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QRGenerator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label1;
    }
}