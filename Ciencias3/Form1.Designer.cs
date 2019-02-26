namespace Ciencias3
{
    partial class login
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
            this.sqldato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.usuariosT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosT)).BeginInit();
            this.SuspendLayout();
            // 
            // sqldato
            // 
            this.sqldato.Location = new System.Drawing.Point(46, 66);
            this.sqldato.Name = "sqldato";
            this.sqldato.Size = new System.Drawing.Size(287, 20);
            this.sqldato.TabIndex = 1;
            this.sqldato.TextChanged += new System.EventHandler(this.sqldato_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SQL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(12, 109);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(321, 23);
            this.loginB.TabIndex = 5;
            this.loginB.Text = "Consultar";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuarios de la Plataforma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // usuariosT
            // 
            this.usuariosT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosT.Location = new System.Drawing.Point(351, 12);
            this.usuariosT.Name = "usuariosT";
            this.usuariosT.Size = new System.Drawing.Size(451, 283);
            this.usuariosT.TabIndex = 7;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 307);
            this.Controls.Add(this.usuariosT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sqldato);
            this.Name = "login";
            this.Text = "Ciencias III";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sqldato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView usuariosT;
    }
}

