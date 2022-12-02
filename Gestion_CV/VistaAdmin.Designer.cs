namespace Gestion_CV
{
    partial class VistaAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Recuperar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.comboBox_Filtro = new System.Windows.Forms.ComboBox();
            this.radioButtonDptos = new System.Windows.Forms.RadioButton();
            this.radioButtonHabs = new System.Windows.Forms.RadioButton();
            this.radioButtonComps = new System.Windows.Forms.RadioButton();
            this.txt_otroFiltrado = new System.Windows.Forms.TextBox();
            this.btn_otroFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Recuperar
            // 
            this.btn_Recuperar.Location = new System.Drawing.Point(122, 13);
            this.btn_Recuperar.Name = "btn_Recuperar";
            this.btn_Recuperar.Size = new System.Drawing.Size(75, 23);
            this.btn_Recuperar.TabIndex = 1;
            this.btn_Recuperar.Text = "Recuperar";
            this.btn_Recuperar.UseVisualStyleBackColor = true;
            this.btn_Recuperar.Click += new System.EventHandler(this.btn_Recuperar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(632, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(713, 12);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(13, 95);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(775, 343);
            this.dataGridViewAdmin.TabIndex = 4;
            // 
            // comboBox_Filtro
            // 
            this.comboBox_Filtro.FormattingEnabled = true;
            this.comboBox_Filtro.Location = new System.Drawing.Point(390, 14);
            this.comboBox_Filtro.Name = "comboBox_Filtro";
            this.comboBox_Filtro.Size = new System.Drawing.Size(236, 21);
            this.comboBox_Filtro.TabIndex = 9;
            // 
            // radioButtonDptos
            // 
            this.radioButtonDptos.AutoSize = true;
            this.radioButtonDptos.Location = new System.Drawing.Point(346, 53);
            this.radioButtonDptos.Name = "radioButtonDptos";
            this.radioButtonDptos.Size = new System.Drawing.Size(97, 17);
            this.radioButtonDptos.TabIndex = 10;
            this.radioButtonDptos.TabStop = true;
            this.radioButtonDptos.Text = "Departamentos";
            this.radioButtonDptos.UseVisualStyleBackColor = true;
            this.radioButtonDptos.CheckedChanged += new System.EventHandler(this.radioButtonDptos_CheckedChanged);
            // 
            // radioButtonHabs
            // 
            this.radioButtonHabs.AutoSize = true;
            this.radioButtonHabs.Location = new System.Drawing.Point(459, 53);
            this.radioButtonHabs.Name = "radioButtonHabs";
            this.radioButtonHabs.Size = new System.Drawing.Size(80, 17);
            this.radioButtonHabs.TabIndex = 11;
            this.radioButtonHabs.TabStop = true;
            this.radioButtonHabs.Text = "Habilidades";
            this.radioButtonHabs.UseVisualStyleBackColor = true;
            this.radioButtonHabs.CheckedChanged += new System.EventHandler(this.radioButtonHabs_CheckedChanged);
            // 
            // radioButtonComps
            // 
            this.radioButtonComps.AutoSize = true;
            this.radioButtonComps.Location = new System.Drawing.Point(550, 53);
            this.radioButtonComps.Name = "radioButtonComps";
            this.radioButtonComps.Size = new System.Drawing.Size(92, 17);
            this.radioButtonComps.TabIndex = 12;
            this.radioButtonComps.TabStop = true;
            this.radioButtonComps.Text = "Competencias";
            this.radioButtonComps.UseVisualStyleBackColor = true;
            this.radioButtonComps.CheckedChanged += new System.EventHandler(this.radioButtonComps_CheckedChanged);
            // 
            // txt_otroFiltrado
            // 
            this.txt_otroFiltrado.Location = new System.Drawing.Point(233, 15);
            this.txt_otroFiltrado.Name = "txt_otroFiltrado";
            this.txt_otroFiltrado.Size = new System.Drawing.Size(100, 20);
            this.txt_otroFiltrado.TabIndex = 13;
            // 
            // btn_otroFiltro
            // 
            this.btn_otroFiltro.Location = new System.Drawing.Point(233, 42);
            this.btn_otroFiltro.Name = "btn_otroFiltro";
            this.btn_otroFiltro.Size = new System.Drawing.Size(75, 23);
            this.btn_otroFiltro.TabIndex = 14;
            this.btn_otroFiltro.Text = "button2";
            this.btn_otroFiltro.UseVisualStyleBackColor = true;
            this.btn_otroFiltro.Click += new System.EventHandler(this.btn_otroFiltro_Click);
            // 
            // VistaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_otroFiltro);
            this.Controls.Add(this.txt_otroFiltrado);
            this.Controls.Add(this.radioButtonComps);
            this.Controls.Add(this.radioButtonHabs);
            this.Controls.Add(this.radioButtonDptos);
            this.Controls.Add(this.comboBox_Filtro);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btn_Recuperar);
            this.Controls.Add(this.button1);
            this.Name = "VistaAdmin";
            this.Text = "VistaAdmin";
            this.Load += new System.EventHandler(this.VistaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Recuperar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btn_Limpiar;
        public System.Windows.Forms.DataGridView dataGridViewAdmin;
        public System.Windows.Forms.ComboBox comboBox_Filtro;
        private System.Windows.Forms.RadioButton radioButtonDptos;
        private System.Windows.Forms.RadioButton radioButtonHabs;
        private System.Windows.Forms.RadioButton radioButtonComps;
        private System.Windows.Forms.TextBox txt_otroFiltrado;
        private System.Windows.Forms.Button btn_otroFiltro;
    }
}