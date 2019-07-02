namespace CAAPoral.IU
{
    partial class FrmFraterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFraterno));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbuser = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.bBorrar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ssEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(724, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.ForeColor = System.Drawing.Color.Black;
            this.lbuser.Location = new System.Drawing.Point(12, 41);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(61, 21);
            this.lbuser.TabIndex = 10;
            this.lbuser.Text = "Buscar";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(267, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 51);
            this.button3.TabIndex = 11;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Tbusuario_TextChanged);
            // 
            // tbusuario
            // 
            this.tbusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusuario.Location = new System.Drawing.Point(12, 65);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(249, 27);
            this.tbusuario.TabIndex = 12;
            this.tbusuario.TextChanged += new System.EventHandler(this.Tbusuario_TextChanged);
            // 
            // bBorrar
            // 
            this.bBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBorrar.BackColor = System.Drawing.Color.Gainsboro;
            this.bBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.ForeColor = System.Drawing.Color.Black;
            this.bBorrar.Image = ((System.Drawing.Image)(resources.GetObject("bBorrar.Image")));
            this.bBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBorrar.Location = new System.Drawing.Point(590, 41);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(70, 50);
            this.bBorrar.TabIndex = 13;
            this.bBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBorrar.UseVisualStyleBackColor = false;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(666, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 50);
            this.button4.TabIndex = 14;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ssEstado
            // 
            this.ssEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssEstado.Location = new System.Drawing.Point(0, 371);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(748, 22);
            this.ssEstado.TabIndex = 15;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "lbestado";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(514, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 50);
            this.button1.TabIndex = 16;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmFraterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 393);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFraterno";
            this.Text = "FrmFraterno";
            this.Load += new System.EventHandler(this.FrmFraterno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ssEstado.ResumeLayout(false);
            this.ssEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
    }
}