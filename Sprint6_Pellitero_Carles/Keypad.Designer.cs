
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
            this.btnContaEnrera = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprovar = new System.Windows.Forms.Button();
            this.lbCodiValid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtemps = new System.Windows.Forms.Label();
            this.txtIntroduit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContaEnrera
            // 
            this.btnContaEnrera.Location = new System.Drawing.Point(91, 21);
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
            this.cbPorts.Location = new System.Drawing.Point(22, 87);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 24);
            this.cbPorts.TabIndex = 2;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecciona el port corresponent";
            // 
            // btnComprovar
            // 
            this.btnComprovar.Location = new System.Drawing.Point(162, 80);
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
            this.lbCodiValid.Location = new System.Drawing.Point(671, 53);
            this.lbCodiValid.Name = "lbCodiValid";
            this.lbCodiValid.Size = new System.Drawing.Size(69, 17);
            this.lbCodiValid.TabIndex = 5;
            this.lbCodiValid.Text = "Codi valid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtemps);
            this.groupBox1.Controls.Add(this.btnContaEnrera);
            this.groupBox1.Location = new System.Drawing.Point(310, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 151);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // lbtemps
            // 
            this.lbtemps.AutoSize = true;
            this.lbtemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtemps.Location = new System.Drawing.Point(119, 98);
            this.lbtemps.Name = "lbtemps";
            this.lbtemps.Size = new System.Drawing.Size(44, 17);
            this.lbtemps.TabIndex = 2;
            this.lbtemps.Text = "00:00";
            this.lbtemps.Visible = false;
            // 
            // txtIntroduit
            // 
            this.txtIntroduit.Location = new System.Drawing.Point(624, 148);
            this.txtIntroduit.Multiline = true;
            this.txtIntroduit.Name = "txtIntroduit";
            this.txtIntroduit.ReadOnly = true;
            this.txtIntroduit.Size = new System.Drawing.Size(161, 48);
            this.txtIntroduit.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Location = new System.Drawing.Point(660, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 52);
            this.panel1.TabIndex = 9;
            // 
            // Keypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIntroduit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCodiValid);
            this.Controls.Add(this.btnComprovar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPorts);
            this.Name = "Keypad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keypad&Pantalla";
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
    }
}

