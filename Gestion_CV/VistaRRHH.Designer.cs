namespace Gestion_CV
{
    partial class VistaRRHH
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
            this.dataGridViewRRHH = new System.Windows.Forms.DataGridView();
            this.btn_accesoAdmin = new System.Windows.Forms.Button();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRRHH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRRHH
            // 
            this.dataGridViewRRHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRRHH.Location = new System.Drawing.Point(13, 58);
            this.dataGridViewRRHH.Name = "dataGridViewRRHH";
            this.dataGridViewRRHH.Size = new System.Drawing.Size(775, 380);
            this.dataGridViewRRHH.TabIndex = 9;
            // 
            // btn_accesoAdmin
            // 
            this.btn_accesoAdmin.Location = new System.Drawing.Point(694, 12);
            this.btn_accesoAdmin.Name = "btn_accesoAdmin";
            this.btn_accesoAdmin.Size = new System.Drawing.Size(94, 23);
            this.btn_accesoAdmin.TabIndex = 8;
            this.btn_accesoAdmin.Text = "SOLO ADMIN";
            this.btn_accesoAdmin.UseVisualStyleBackColor = true;
            this.btn_accesoAdmin.Click += new System.EventHandler(this.btn_accesoAdmin_Click);
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.Location = new System.Drawing.Point(280, 12);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(75, 23);
            this.btn_Refrescar.TabIndex = 7;
            this.btn_Refrescar.Text = "Actualizar";
            this.btn_Refrescar.UseVisualStyleBackColor = true;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(122, 13);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 6;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Location = new System.Drawing.Point(203, 12);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Visualizar.TabIndex = 10;
            this.btn_Visualizar.Text = "Visualizar Registro";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // VistaRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Visualizar);
            this.Controls.Add(this.dataGridViewRRHH);
            this.Controls.Add(this.btn_accesoAdmin);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.button1);
            this.Name = "VistaRRHH";
            this.Text = "VistaRRHH";
            this.Load += new System.EventHandler(this.VistaRRHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRRHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewRRHH;
        private System.Windows.Forms.Button btn_accesoAdmin;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Visualizar;
    }
}