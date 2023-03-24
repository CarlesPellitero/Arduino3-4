namespace Sprint6_Pellitero_Carles
{
    partial class CodeCard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cam = new System.Windows.Forms.PictureBox();
            this.txtQRInfo = new System.Windows.Forms.TextBox();
            this.txtBBDD = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbCamara = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.InsertForm = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cam)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(79, 65);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(121, 22);
            this.txtUser.TabIndex = 0;
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // cam
            // 
            this.cam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cam.Location = new System.Drawing.Point(0, 0);
            this.cam.Name = "cam";
            this.cam.Size = new System.Drawing.Size(1212, 489);
            this.cam.TabIndex = 1;
            this.cam.TabStop = false;
            // 
            // txtQRInfo
            // 
            this.txtQRInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtQRInfo.Location = new System.Drawing.Point(903, 0);
            this.txtQRInfo.Multiline = true;
            this.txtQRInfo.Name = "txtQRInfo";
            this.txtQRInfo.Size = new System.Drawing.Size(309, 489);
            this.txtQRInfo.TabIndex = 2;
            this.txtQRInfo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // txtBBDD
            // 
            this.txtBBDD.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBBDD.Location = new System.Drawing.Point(0, 0);
            this.txtBBDD.Multiline = true;
            this.txtBBDD.Name = "txtBBDD";
            this.txtBBDD.Size = new System.Drawing.Size(299, 489);
            this.txtBBDD.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(246, 65);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(237, 22);
            this.txtDesc.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(581, 64);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCamara
            // 
            this.cbCamara.FormattingEnabled = true;
            this.cbCamara.Location = new System.Drawing.Point(79, 21);
            this.cbCamara.Name = "cbCamara";
            this.cbCamara.Size = new System.Drawing.Size(121, 24);
            this.cbCamara.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InsertForm
            // 
            this.InsertForm.Location = new System.Drawing.Point(79, 102);
            this.InsertForm.Name = "InsertForm";
            this.InsertForm.Size = new System.Drawing.Size(1125, 492);
            this.InsertForm.TabIndex = 7;
            this.InsertForm.Visible = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtBBDD);
            this.panel.Controls.Add(this.txtQRInfo);
            this.panel.Controls.Add(this.cam);
            this.panel.Location = new System.Drawing.Point(53, 105);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1212, 489);
            this.panel.TabIndex = 8;
            // 
            // CodeCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1361, 732);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbCamara);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.InsertForm);
            this.Name = "CodeCard";
            this.ShowIcon = false;
            this.Text = "CodeCard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cam)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox cam;
        private System.Windows.Forms.TextBox txtQRInfo;
        private System.Windows.Forms.TextBox txtBBDD;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbCamara;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel InsertForm;
        private System.Windows.Forms.Panel panel;
    }
}

