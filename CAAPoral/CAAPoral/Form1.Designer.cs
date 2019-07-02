namespace CAAPoral
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bControl = new System.Windows.Forms.Button();
            this.bMedidas = new System.Windows.Forms.Button();
            this.bFraternos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bPagos = new System.Windows.Forms.Button();
            this.bAsistencia = new System.Windows.Forms.Button();
            this.dtpControl = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.dtpControl);
            this.panel1.Controls.Add(this.bAsistencia);
            this.panel1.Controls.Add(this.bPagos);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.bControl);
            this.panel1.Controls.Add(this.bMedidas);
            this.panel1.Controls.Add(this.bFraternos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 542);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(169, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 429);
            this.panel4.TabIndex = 9;
            // 
            // bControl
            // 
            this.bControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bControl.BackColor = System.Drawing.Color.Tomato;
            this.bControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bControl.ForeColor = System.Drawing.Color.White;
            this.bControl.Location = new System.Drawing.Point(2, 486);
            this.bControl.Name = "bControl";
            this.bControl.Size = new System.Drawing.Size(167, 53);
            this.bControl.TabIndex = 6;
            this.bControl.Text = "Abrir Control";
            this.bControl.UseVisualStyleBackColor = false;
            this.bControl.Click += new System.EventHandler(this.bControl_Click);
            // 
            // bMedidas
            // 
            this.bMedidas.BackColor = System.Drawing.Color.Gainsboro;
            this.bMedidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMedidas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMedidas.ForeColor = System.Drawing.Color.Black;
            this.bMedidas.Image = ((System.Drawing.Image)(resources.GetObject("bMedidas.Image")));
            this.bMedidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMedidas.Location = new System.Drawing.Point(2, 94);
            this.bMedidas.Name = "bMedidas";
            this.bMedidas.Size = new System.Drawing.Size(167, 53);
            this.bMedidas.TabIndex = 8;
            this.bMedidas.Text = "Medidas";
            this.bMedidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bMedidas.UseVisualStyleBackColor = false;
            this.bMedidas.Click += new System.EventHandler(this.bMedidas_Click);
            // 
            // bFraternos
            // 
            this.bFraternos.BackColor = System.Drawing.Color.Gainsboro;
            this.bFraternos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFraternos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFraternos.ForeColor = System.Drawing.Color.Black;
            this.bFraternos.Image = ((System.Drawing.Image)(resources.GetObject("bFraternos.Image")));
            this.bFraternos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bFraternos.Location = new System.Drawing.Point(2, 42);
            this.bFraternos.Name = "bFraternos";
            this.bFraternos.Size = new System.Drawing.Size(167, 53);
            this.bFraternos.TabIndex = 7;
            this.bFraternos.Text = "Fraternos";
            this.bFraternos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bFraternos.UseVisualStyleBackColor = false;
            this.bFraternos.Click += new System.EventHandler(this.bFraternos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 5);
            this.panel3.TabIndex = 5;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(31, 9);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(100, 19);
            this.lTitulo.TabIndex = 4;
            this.lTitulo.Text = "CAAPorales";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.bLogout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbUser);
            this.panel2.Location = new System.Drawing.Point(171, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 47);
            this.panel2.TabIndex = 1;
            // 
            // bLogout
            // 
            this.bLogout.BackColor = System.Drawing.Color.Tomato;
            this.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogout.ForeColor = System.Drawing.Color.White;
            this.bLogout.Location = new System.Drawing.Point(10, 9);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(52, 33);
            this.bLogout.TabIndex = 7;
            this.bLogout.Text = "Salir";
            this.bLogout.UseVisualStyleBackColor = false;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Location = new System.Drawing.Point(478, 15);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(96, 21);
            this.lbUser.TabIndex = 7;
            this.lbUser.Text = "Juan perez";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Location = new System.Drawing.Point(171, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(640, 492);
            this.panel5.TabIndex = 2;
            // 
            // bPagos
            // 
            this.bPagos.BackColor = System.Drawing.Color.Gainsboro;
            this.bPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPagos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPagos.ForeColor = System.Drawing.Color.Black;
            this.bPagos.Image = ((System.Drawing.Image)(resources.GetObject("bPagos.Image")));
            this.bPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPagos.Location = new System.Drawing.Point(2, 146);
            this.bPagos.Name = "bPagos";
            this.bPagos.Size = new System.Drawing.Size(167, 53);
            this.bPagos.TabIndex = 10;
            this.bPagos.Text = "Pagos";
            this.bPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPagos.UseVisualStyleBackColor = false;
            this.bPagos.Click += new System.EventHandler(this.bPagos_Click);
            // 
            // bAsistencia
            // 
            this.bAsistencia.BackColor = System.Drawing.Color.Gainsboro;
            this.bAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAsistencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAsistencia.ForeColor = System.Drawing.Color.Black;
            this.bAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("bAsistencia.Image")));
            this.bAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAsistencia.Location = new System.Drawing.Point(2, 198);
            this.bAsistencia.Name = "bAsistencia";
            this.bAsistencia.Size = new System.Drawing.Size(167, 53);
            this.bAsistencia.TabIndex = 11;
            this.bAsistencia.Text = "Asistencia";
            this.bAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAsistencia.UseVisualStyleBackColor = false;
            this.bAsistencia.Click += new System.EventHandler(this.bAsistencia_Click);
            // 
            // dtpControl
            // 
            this.dtpControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpControl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpControl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpControl.Location = new System.Drawing.Point(2, 459);
            this.dtpControl.Name = "dtpControl";
            this.dtpControl.Size = new System.Drawing.Size(167, 27);
            this.dtpControl.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 540);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button bMedidas;
        private System.Windows.Forms.Button bFraternos;
        private System.Windows.Forms.Button bControl;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bPagos;
        private System.Windows.Forms.Button bAsistencia;
        private System.Windows.Forms.DateTimePicker dtpControl;
    }
}

