namespace pryCuevasCarranzaEjercicioPorResolverSP2
{
    partial class frmPrincipal
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
            lblFecha = new Label();
            lblCodigo = new Label();
            lblTipo = new Label();
            txtCodigo = new TextBox();
            rbCorta = new RadioButton();
            RbLarga = new RadioButton();
            dtpFecha = new DateTimePicker();
            gbDistancia = new GroupBox();
            cboTipoBoleto = new ComboBox();
            btnRegistrar = new Button();
            gbDistancia.SuspendLayout();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(41, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(41, 83);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(41, 122);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(107, 75);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // rbCorta
            // 
            rbCorta.AutoSize = true;
            rbCorta.Location = new Point(6, 28);
            rbCorta.Name = "rbCorta";
            rbCorta.Size = new Size(54, 19);
            rbCorta.TabIndex = 4;
            rbCorta.TabStop = true;
            rbCorta.Text = "Corta";
            rbCorta.UseVisualStyleBackColor = true;
            // 
            // RbLarga
            // 
            RbLarga.AutoSize = true;
            RbLarga.Location = new Point(6, 53);
            RbLarga.Name = "RbLarga";
            RbLarga.Size = new Size(54, 19);
            RbLarga.TabIndex = 5;
            RbLarga.TabStop = true;
            RbLarga.Text = "Larga";
            RbLarga.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(107, 35);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 6;
            // 
            // gbDistancia
            // 
            gbDistancia.Controls.Add(rbCorta);
            gbDistancia.Controls.Add(RbLarga);
            gbDistancia.Location = new Point(41, 174);
            gbDistancia.Name = "gbDistancia";
            gbDistancia.Size = new Size(200, 100);
            gbDistancia.TabIndex = 7;
            gbDistancia.TabStop = false;
            gbDistancia.Text = "Distancia";
            // 
            // cboTipoBoleto
            // 
            cboTipoBoleto.FormattingEnabled = true;
            cboTipoBoleto.Location = new Point(107, 122);
            cboTipoBoleto.Name = "cboTipoBoleto";
            cboTipoBoleto.Size = new Size(121, 23);
            cboTipoBoleto.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(232, 295);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 348);
            Controls.Add(btnRegistrar);
            Controls.Add(cboTipoBoleto);
            Controls.Add(gbDistancia);
            Controls.Add(dtpFecha);
            Controls.Add(txtCodigo);
            Controls.Add(lblTipo);
            Controls.Add(lblCodigo);
            Controls.Add(lblFecha);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta Boleteria";
            Load += frmPrincipal_Load;
            gbDistancia.ResumeLayout(false);
            gbDistancia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblCodigo;
        private Label lblTipo;
        private TextBox txtCodigo;
        private RadioButton rbCorta;
        private RadioButton RbLarga;
        private DateTimePicker dtpFecha;
        private GroupBox gbDistancia;
        private ComboBox cboTipoBoleto;
        private Button btnRegistrar;
    }
}