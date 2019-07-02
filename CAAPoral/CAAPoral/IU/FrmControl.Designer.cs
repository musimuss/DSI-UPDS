namespace CAAPoral.IU
{
    partial class FrmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControl));
            this.lTitulo = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.bMarcar = new System.Windows.Forms.Button();
            this.lEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(30, 50);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(131, 33);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Fraterno:";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.Location = new System.Drawing.Point(28, 97);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(0, 44);
            this.lUsuario.TabIndex = 1;
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(36, 266);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(217, 47);
            this.tbId.TabIndex = 2;
            this.tbId.UseSystemPasswordChar = true;
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.Color.Black;
            this.bSalir.Image = ((System.Drawing.Image)(resources.GetObject("bSalir.Image")));
            this.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalir.Location = new System.Drawing.Point(455, 12);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(60, 50);
            this.bSalir.TabIndex = 4;
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
            this.bMarcar.Location = new System.Drawing.Point(84, 319);
            this.bMarcar.Name = "bMarcar";
            this.bMarcar.Size = new System.Drawing.Size(121, 46);
            this.bMarcar.TabIndex = 5;
            this.bMarcar.Text = "Entrar";
            this.bMarcar.UseVisualStyleBackColor = false;
            this.bMarcar.Click += new System.EventHandler(this.bMarcar_Click);
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.Location = new System.Drawing.Point(79, 368);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(0, 33);
            this.lEstado.TabIndex = 6;
            // 
            // FrmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 430);
            this.ControlBox = false;
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bMarcar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.lTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bMarcar;
        private System.Windows.Forms.Label lEstado;
    }
}