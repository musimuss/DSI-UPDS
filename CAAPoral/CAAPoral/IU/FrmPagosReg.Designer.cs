namespace CAAPoral.IU
{
    partial class FrmPagosReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagosReg));
            this.lEstado = new System.Windows.Forms.Label();
            this.bSalir = new System.Windows.Forms.Button();
            this.bMarcar = new System.Windows.Forms.Button();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.Location = new System.Drawing.Point(66, 393);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(0, 33);
            this.lEstado.TabIndex = 11;
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.Color.Black;
            this.bSalir.Image = ((System.Drawing.Image)(resources.GetObject("bSalir.Image")));
            this.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalir.Location = new System.Drawing.Point(450, 12);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(60, 50);
            this.bSalir.TabIndex = 9;
            this.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bMarcar
            // 
            this.bMarcar.BackColor = System.Drawing.Color.Tomato;
            this.bMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMarcar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMarcar.ForeColor = System.Drawing.Color.White;
            this.bMarcar.Location = new System.Drawing.Point(71, 344);
            this.bMarcar.Name = "bMarcar";
            this.bMarcar.Size = new System.Drawing.Size(121, 46);
            this.bMarcar.TabIndex = 10;
            this.bMarcar.Text = "Entrar";
            this.bMarcar.UseVisualStyleBackColor = false;
            this.bMarcar.Click += new System.EventHandler(this.bMarcar_Click);
            // 
            // tbMonto
            // 
            this.tbMonto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonto.Location = new System.Drawing.Point(11, 291);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(217, 47);
            this.tbMonto.TabIndex = 8;
            this.tbMonto.UseSystemPasswordChar = true;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(12, 47);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(131, 33);
            this.lTitulo.TabIndex = 7;
            this.lTitulo.Text = "Fraterno:";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.Location = new System.Drawing.Point(25, 105);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(0, 44);
            this.lUsuario.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 169);
            this.dataGridView1.TabIndex = 14;
            // 
            // FrmPagosReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bMarcar);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.lTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagosReg";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.FrmPagosReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bMarcar;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}