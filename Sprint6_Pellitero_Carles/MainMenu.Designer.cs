
namespace Sprint6_Pellitero_Carles
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.screen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.title = new System.Windows.Forms.Label();
            this.txtinfo = new System.Windows.Forms.Label();
            this.txtTraduct = new System.Windows.Forms.Label();
            this.btnOpcion1 = new System.Windows.Forms.Panel();
            this.btnOpcion2 = new System.Windows.Forms.Panel();
            this.txtTraduct2 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.txtinfo2 = new System.Windows.Forms.Label();
            this.btnOpcion3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.title3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOpcion4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnOpcion1.SuspendLayout();
            this.btnOpcion2.SuspendLayout();
            this.btnOpcion3.SuspendLayout();
            this.btnOpcion4.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Dock = System.Windows.Forms.DockStyle.Right;
            this.screen.Location = new System.Drawing.Point(452, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(995, 825);
            this.screen.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Delay
            // 
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Death Star", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(9, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(202, 22);
            this.title.TabIndex = 6;
            this.title.Text = "GeneratorQR";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // txtinfo
            // 
            this.txtinfo.AutoSize = true;
            this.txtinfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinfo.Location = new System.Drawing.Point(10, 40);
            this.txtinfo.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(197, 68);
            this.txtinfo.TabIndex = 7;
            this.txtinfo.Text = "Un pantalla per poder registrar un nuevo QR para que el usuario deba de usar para" +
    " logearse";
            this.txtinfo.Click += new System.EventHandler(this.txtinfo_Click);
            // 
            // txtTraduct
            // 
            this.txtTraduct.AutoSize = true;
            this.txtTraduct.Font = new System.Drawing.Font("Droidobesh Depot", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraduct.Location = new System.Drawing.Point(10, 120);
            this.txtTraduct.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtTraduct.Name = "txtTraduct";
            this.txtTraduct.Size = new System.Drawing.Size(200, 40);
            this.txtTraduct.TabIndex = 8;
            this.txtTraduct.Text = "Un menú para poder registrar un nuevo QR para que el usuario deba de usar para lo" +
    "gearse";
            this.txtTraduct.Click += new System.EventHandler(this.txtTraduct_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnOpcion1.Controls.Add(this.txtTraduct);
            this.btnOpcion1.Controls.Add(this.title);
            this.btnOpcion1.Controls.Add(this.txtinfo);
            this.btnOpcion1.Location = new System.Drawing.Point(136, 36);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(230, 173);
            this.btnOpcion1.TabIndex = 9;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            this.btnOpcion1.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOpcion1_Paint);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.BackColor = System.Drawing.Color.Aquamarine;
            this.btnOpcion2.Controls.Add(this.txtTraduct2);
            this.btnOpcion2.Controls.Add(this.title2);
            this.btnOpcion2.Controls.Add(this.txtinfo2);
            this.btnOpcion2.Location = new System.Drawing.Point(136, 224);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(230, 173);
            this.btnOpcion2.TabIndex = 10;
            // 
            // txtTraduct2
            // 
            this.txtTraduct2.AutoSize = true;
            this.txtTraduct2.Font = new System.Drawing.Font("Droidobesh Depot", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraduct2.Location = new System.Drawing.Point(10, 109);
            this.txtTraduct2.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtTraduct2.Name = "txtTraduct2";
            this.txtTraduct2.Size = new System.Drawing.Size(166, 40);
            this.txtTraduct2.TabIndex = 8;
            this.txtTraduct2.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut id mauris volutpat.";
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Death Star", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(9, 9);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(202, 22);
            this.title2.TabIndex = 6;
            this.title2.Text = "TitulExemple";
            // 
            // txtinfo2
            // 
            this.txtinfo2.AutoSize = true;
            this.txtinfo2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinfo2.Location = new System.Drawing.Point(10, 43);
            this.txtinfo2.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtinfo2.Name = "txtinfo2";
            this.txtinfo2.Size = new System.Drawing.Size(199, 51);
            this.txtinfo2.TabIndex = 7;
            this.txtinfo2.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut id mauris volutpat.";
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.BackColor = System.Drawing.Color.Aquamarine;
            this.btnOpcion3.Controls.Add(this.label7);
            this.btnOpcion3.Controls.Add(this.title3);
            this.btnOpcion3.Controls.Add(this.label9);
            this.btnOpcion3.Location = new System.Drawing.Point(136, 414);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(230, 173);
            this.btnOpcion3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droidobesh Depot", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 120);
            this.label7.MaximumSize = new System.Drawing.Size(200, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 40);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut id mauris volutpat.";
            // 
            // title3
            // 
            this.title3.AutoSize = true;
            this.title3.Font = new System.Drawing.Font("Death Star", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3.Location = new System.Drawing.Point(9, 9);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(202, 22);
            this.title3.TabIndex = 6;
            this.title3.Text = "TitulExemple";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 46);
            this.label9.MaximumSize = new System.Drawing.Size(200, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 51);
            this.label9.TabIndex = 7;
            this.label9.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut id mauris volutpat.";
            // 
            // btnOpcion4
            // 
            this.btnOpcion4.BackColor = System.Drawing.Color.Aquamarine;
            this.btnOpcion4.Controls.Add(this.label10);
            this.btnOpcion4.Controls.Add(this.label11);
            this.btnOpcion4.Controls.Add(this.label12);
            this.btnOpcion4.Location = new System.Drawing.Point(136, 611);
            this.btnOpcion4.Name = "btnOpcion4";
            this.btnOpcion4.Size = new System.Drawing.Size(230, 173);
            this.btnOpcion4.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droidobesh Depot", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 109);
            this.label10.MaximumSize = new System.Drawing.Size(200, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 40);
            this.label10.TabIndex = 8;
            this.label10.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut id mauris volutpat.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Death Star", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "TitulExemple";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 40);
            this.label12.MaximumSize = new System.Drawing.Size(200, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 51);
            this.label12.TabIndex = 7;
            this.label12.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut id mauris volutpat.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "MainMenu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.MaximumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 198);
            this.label1.TabIndex = 13;
            this.label1.Text = "Aquesta pantalla es el menu principal que esta distribuides les seves funcions en" +
    " 4 botóns que es mostrara a la pantalla a la nostra dreta\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droidobesh Depot", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.MaximumSize = new System.Drawing.Size(100, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 140);
            this.label2.TabIndex = 14;
            this.label2.Text = "Aquesta pantalla es el menu principal que esta distribuides les seves funcions en" +
    " 4 botóns que es mostrara a la pantalla a la nostra dreta\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(404, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 826);
            this.panel1.TabIndex = 15;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1447, 825);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnOpcion4);
            this.Controls.Add(this.btnOpcion3);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnOpcion1.ResumeLayout(false);
            this.btnOpcion1.PerformLayout();
            this.btnOpcion2.ResumeLayout(false);
            this.btnOpcion2.PerformLayout();
            this.btnOpcion3.ResumeLayout(false);
            this.btnOpcion3.PerformLayout();
            this.btnOpcion4.ResumeLayout(false);
            this.btnOpcion4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label txtinfo;
        private System.Windows.Forms.Label txtTraduct;
        private System.Windows.Forms.Panel btnOpcion1;
        private System.Windows.Forms.Panel btnOpcion2;
        private System.Windows.Forms.Label txtTraduct2;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label txtinfo2;
        private System.Windows.Forms.Panel btnOpcion3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel btnOpcion4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}