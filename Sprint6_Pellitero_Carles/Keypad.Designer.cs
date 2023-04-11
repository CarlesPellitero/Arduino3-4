
namespace Sprint6_Pellitero_Carles
{
    partial class Keypad
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
            this.btnContaEnrera = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprovar = new System.Windows.Forms.Button();
            this.lbCodiValid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtemps = new System.Windows.Forms.Label();
            this.txtIntroduit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DelayTime = new System.Windows.Forms.Timer(this.components);
            this.btnScan = new System.Windows.Forms.Button();
            this.QRScanner = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContaEnrera
            // 
            this.btnContaEnrera.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaEnrera.Location = new System.Drawing.Point(115, 30);
            this.btnContaEnrera.Name = "btnContaEnrera";
            this.btnContaEnrera.Size = new System.Drawing.Size(95, 61);
            this.btnContaEnrera.TabIndex = 0;
            this.btnContaEnrera.Text = "Iniciar";
            this.btnContaEnrera.UseVisualStyleBackColor = true;
            this.btnContaEnrera.Click += new System.EventHandler(this.btnContaEnrera_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(182, 154);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(149, 24);
            this.cbPorts.TabIndex = 2;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecciona el port corresponent";
            // 
            // btnComprovar
            // 
            this.btnComprovar.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprovar.Location = new System.Drawing.Point(359, 147);
            this.btnComprovar.Name = "btnComprovar";
            this.btnComprovar.Size = new System.Drawing.Size(90, 37);
            this.btnComprovar.TabIndex = 4;
            this.btnComprovar.Text = "Connectar";
            this.btnComprovar.UseVisualStyleBackColor = true;
            this.btnComprovar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbCodiValid
            // 
            this.lbCodiValid.AutoSize = true;
            this.lbCodiValid.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodiValid.Location = new System.Drawing.Point(923, 126);
            this.lbCodiValid.Name = "lbCodiValid";
            this.lbCodiValid.Size = new System.Drawing.Size(81, 21);
            this.lbCodiValid.TabIndex = 5;
            this.lbCodiValid.Text = "Codi valid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtemps);
            this.groupBox1.Controls.Add(this.btnContaEnrera);
            this.groupBox1.Location = new System.Drawing.Point(502, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // lbtemps
            // 
            this.lbtemps.AutoSize = true;
            this.lbtemps.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtemps.Location = new System.Drawing.Point(136, 107);
            this.lbtemps.Name = "lbtemps";
            this.lbtemps.Size = new System.Drawing.Size(52, 21);
            this.lbtemps.TabIndex = 2;
            this.lbtemps.Text = "00:00";
            this.lbtemps.Visible = false;
            // 
            // txtIntroduit
            // 
            this.txtIntroduit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntroduit.Location = new System.Drawing.Point(891, 218);
            this.txtIntroduit.Multiline = true;
            this.txtIntroduit.Name = "txtIntroduit";
            this.txtIntroduit.ReadOnly = true;
            this.txtIntroduit.Size = new System.Drawing.Size(161, 48);
            this.txtIntroduit.TabIndex = 8;
            this.txtIntroduit.TextChanged += new System.EventHandler(this.txtIntroduit_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Location = new System.Drawing.Point(927, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 50);
            this.panel1.TabIndex = 9;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(1484, 291);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(134, 35);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "Scan QR";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Visible = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // QRScanner
            // 
            this.QRScanner.Location = new System.Drawing.Point(744, 362);
            this.QRScanner.Name = "QRScanner";
            this.QRScanner.Size = new System.Drawing.Size(959, 426);
            this.QRScanner.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(278, 446);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(154, 22);
            this.txtPass.TabIndex = 13;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(178, 383);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(58, 21);
            this.lbUser.TabIndex = 14;
            this.lbUser.Text = "[User]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // Keypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1733, 894);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.QRScanner);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIntroduit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCodiValid);
            this.Controls.Add(this.btnComprovar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPorts);
            this.Name = "Keypad";
            this.ShowIcon = false;
            this.Text = "Keypad&Pantalla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContaEnrera;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprovar;
        private System.Windows.Forms.Label lbCodiValid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIntroduit;
        private System.Windows.Forms.Label lbtemps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer DelayTime;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Panel QRScanner;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label3;
    }
}

