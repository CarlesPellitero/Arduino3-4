﻿
namespace Sprint6_Pellitero_Carles
{
    partial class Form1
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
            this.lbtemps = new System.Windows.Forms.Label();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprovar = new System.Windows.Forms.Button();
            this.turnback = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContaEnrera
            // 
            this.btnContaEnrera.Location = new System.Drawing.Point(85, 21);
            this.btnContaEnrera.Name = "btnContaEnrera";
            this.btnContaEnrera.Size = new System.Drawing.Size(95, 61);
            this.btnContaEnrera.TabIndex = 0;
            this.btnContaEnrera.Text = "Iniciar";
            this.btnContaEnrera.UseVisualStyleBackColor = true;
            this.btnContaEnrera.Visible = false;
            this.btnContaEnrera.Click += new System.EventHandler(this.btnContaEnrera_Click);
            // 
            // lbtemps
            // 
            this.lbtemps.AutoSize = true;
            this.lbtemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtemps.Location = new System.Drawing.Point(68, 95);
            this.lbtemps.Name = "lbtemps";
            this.lbtemps.Size = new System.Drawing.Size(137, 17);
            this.lbtemps.TabIndex = 1;
            this.lbtemps.Text = "cuanta atras (00:00)";
            this.lbtemps.Visible = false;
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
            // turnback
            // 
            this.turnback.Interval = 1000;
            this.turnback.Tick += new System.EventHandler(this.turnback_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "codi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContaEnrera);
            this.groupBox1.Controls.Add(this.lbtemps);
            this.groupBox1.Location = new System.Drawing.Point(296, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 49);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 360);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprovar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPorts);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Keypad&Pantalla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContaEnrera;
        private System.Windows.Forms.Label lbtemps;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprovar;
        private System.Windows.Forms.Timer turnback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

