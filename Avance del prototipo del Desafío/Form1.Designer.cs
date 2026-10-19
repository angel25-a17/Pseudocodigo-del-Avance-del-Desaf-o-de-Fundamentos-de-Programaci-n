namespace Avance_del_prototipo_del_Desafío
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
            lblUsuario = new Label();
            lblDocumento = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblTipo = new Label();
            lblAsunto = new Label();
            label8 = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtTelefono = new TextBox();
            txtAsunto = new TextBox();
            txtFecha = new TextBox();
            cmbTipo = new ComboBox();
            btnRegistrar = new Button();
            btnOrdenar = new Button();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            cmbEstado = new ComboBox();
            btnBuscar = new Button();
            btnActualizar = new Button();
            dgvDocumentos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDNI = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colAsunto = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblUsuario.Location = new Point(89, 24);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(167, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Datos del usuario";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblDocumento.Location = new Point(468, 24);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(203, 25);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Datos del documento";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 12F);
            lblDNI.Location = new Point(55, 101);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(44, 21);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(28, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(28, 133);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 21);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F);
            lblTipo.Location = new Point(468, 75);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 21);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo:";
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Font = new Font("Segoe UI", 12F);
            lblAsunto.Location = new Point(449, 101);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new Size(62, 21);
            lblAsunto.TabIndex = 6;
            lblAsunto.Text = "Asunto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(458, 133);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 7;
            label8.Text = "Fecha:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(105, 103);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(165, 23);
            txtDNI.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(105, 135);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(165, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new Point(517, 101);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(165, 23);
            txtAsunto.TabIndex = 12;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(517, 135);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(165, 23);
            txtFecha.TabIndex = 13;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Solicitud", "Reclamo", "Consulta", "Otro" });
            cmbTipo.Location = new Point(517, 72);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(160, 23);
            cmbTipo.TabIndex = 14;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 184);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(128, 39);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(12, 229);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(128, 39);
            btnOrdenar.TabIndex = 16;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F);
            lblCodigo.Location = new Point(163, 191);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(63, 21);
            lblCodigo.TabIndex = 17;
            lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(232, 189);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(105, 23);
            txtCodigo.TabIndex = 18;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "en Proceso", "Atendido" });
            cmbEstado.Location = new Point(486, 193);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(147, 23);
            cmbEstado.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(343, 184);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 39);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(651, 184);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(128, 39);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvDocumentos
            // 
            dgvDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colDNI, colTelefono, colTipo, colAsunto, colFecha, colEstado });
            dgvDocumentos.Location = new Point(4, 277);
            dgvDocumentos.Name = "dgvDocumentos";
            dgvDocumentos.Size = new Size(796, 161);
            dgvDocumentos.TabIndex = 23;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Codigo";
            colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colDNI
            // 
            colDNI.HeaderText = "DNI";
            colDNI.Name = "colDNI";
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Telefono";
            colTelefono.Name = "colTelefono";
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            // 
            // colAsunto
            // 
            colAsunto.HeaderText = "Asunto";
            colAsunto.Name = "colAsunto";
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDocumentos);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(cmbEstado);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnOrdenar);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbTipo);
            Controls.Add(txtFecha);
            Controls.Add(txtAsunto);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(label8);
            Controls.Add(lblAsunto);
            Controls.Add(lblTipo);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblDocumento);
            Controls.Add(lblUsuario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblDocumento;
        private Label lblDNI;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblTipo;
        private Label lblAsunto;
        private Label label8;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtTelefono;
        private TextBox txtAsunto;
        private TextBox txtFecha;
        private ComboBox cmbTipo;
        private Button btnRegistrar;
        private Button btnOrdenar;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private ComboBox cmbEstado;
        private Button btnBuscar;
        private Button btnActualizar;
        private DataGridView dgvDocumentos;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colAsunto;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colEstado;
    }
}
