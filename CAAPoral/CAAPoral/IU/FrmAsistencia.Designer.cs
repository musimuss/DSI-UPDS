namespace CAAPoral.IU
{
    partial class FrmAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistencia));
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.ssEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // ssEstado
            // 
            this.ssEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssEstado.Location = new System.Drawing.Point(0, 345);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(800, 22);
            this.ssEstado.TabIndex = 35;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "lbestado";
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.ForeColor = System.Drawing.Color.Black;
            this.lbBuscar.Location = new System.Drawing.Point(12, 41);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(61, 21);
            this.lbBuscar.TabIndex = 32;
            this.lbBuscar.Text = "Buscar";
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.ForeColor = System.Drawing.Color.Black;
            this.bBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bBuscar.Image")));
            this.bBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBuscar.Location = new System.Drawing.Point(266, 41);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(70, 51);
            this.bBuscar.TabIndex = 33;
            this.bBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 98);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(776, 244);
            this.dgvDatos.TabIndex = 31;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(12, 65);
            this.dtpFecha.MaxDate = new System.DateTime(2019, 7, 1, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(248, 27);
            this.dtpFecha.TabIndex = 37;
            this.dtpFecha.Value = new System.DateTime(2019, 7, 1, 0, 0, 0, 0);
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.ControlBox = false;
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsistencia";
            this.Text = "FrmAsistencia";
            this.ssEstado.ResumeLayout(false);
            this.ssEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}