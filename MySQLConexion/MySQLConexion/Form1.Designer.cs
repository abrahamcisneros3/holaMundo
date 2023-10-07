namespace MySQLConexion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txthost = new TextBox();
            txtBasededatos = new TextBox();
            txtPuerto = new TextBox();
            dgvdatos = new DataGridView();
            BtnConectar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 49);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 89);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Host:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 123);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Base de datos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 163);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Puerto:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(128, 1);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(128, 46);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 6;
            // 
            // txthost
            // 
            txthost.Location = new Point(128, 89);
            txthost.Name = "txthost";
            txthost.Size = new Size(100, 23);
            txthost.TabIndex = 7;
            // 
            // txtBasededatos
            // 
            txtBasededatos.Location = new Point(128, 123);
            txtBasededatos.Name = "txtBasededatos";
            txtBasededatos.Size = new Size(100, 23);
            txtBasededatos.TabIndex = 8;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(128, 155);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(100, 23);
            txtPuerto.TabIndex = 9;
            // 
            // dgvdatos
            // 
            dgvdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatos.Location = new Point(265, 12);
            dgvdatos.Name = "dgvdatos";
            dgvdatos.RowTemplate.Height = 25;
            dgvdatos.Size = new Size(359, 220);
            dgvdatos.TabIndex = 11;
            // 
            // BtnConectar
            // 
            BtnConectar.Location = new Point(406, 270);
            BtnConectar.Name = "BtnConectar";
            BtnConectar.Size = new Size(75, 23);
            BtnConectar.TabIndex = 12;
            BtnConectar.Text = "Conectar";
            BtnConectar.UseVisualStyleBackColor = true;
            BtnConectar.Click += BtnConectar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnConectar);
            Controls.Add(dgvdatos);
            Controls.Add(txtPuerto);
            Controls.Add(txtBasededatos);
            Controls.Add(txthost);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvdatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txthost;
        private TextBox txtBasededatos;
        private TextBox txtPuerto;
        private DataGridView dgvdatos;
        private Button BtnConectar;
    }
}