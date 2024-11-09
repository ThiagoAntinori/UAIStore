namespace UI
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
            groupBox1 = new GroupBox();
            btnCargarBorrador = new Button();
            btnGuardarCambios = new Button();
            label1 = new Label();
            cmbCategoria = new ComboBox();
            txtPrecio = new TextBox();
            txtDesarrolladora = new TextBox();
            txtDescripcion = new TextBox();
            txtTitulo = new TextBox();
            groupBox2 = new GroupBox();
            txtIdModificar = new TextBox();
            btnConfirmarModificar = new Button();
            txtNuevoPrecio = new TextBox();
            txtNuevaDesarrolladora = new TextBox();
            txtNuevaDescripcion = new TextBox();
            txtNuevoTitulo = new TextBox();
            groupBox3 = new GroupBox();
            btnConfirmarEliminar = new Button();
            txtIdEliminar = new TextBox();
            dgvAplicaciones = new DataGridView();
            btnCrearUnica = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAplicaciones).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearUnica);
            groupBox1.Controls.Add(btnCargarBorrador);
            groupBox1.Controls.Add(btnGuardarCambios);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtDesarrolladora);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Location = new Point(21, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CREAR APLICACIÓN";
            // 
            // btnCargarBorrador
            // 
            btnCargarBorrador.Location = new Point(34, 193);
            btnCargarBorrador.Name = "btnCargarBorrador";
            btnCargarBorrador.Size = new Size(141, 25);
            btnCargarBorrador.TabIndex = 6;
            btnCargarBorrador.Text = "CARGAR A BORRADOR";
            btnCargarBorrador.UseVisualStyleBackColor = true;
            btnCargarBorrador.Click += btnCargarBorrador_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(34, 224);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(141, 25);
            btnGuardarCambios.TabIndex = 0;
            btnGuardarCambios.Text = "GUARDAR CAMBIOS";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 158);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 5;
            label1.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(113, 155);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(202, 23);
            cmbCategoria.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(34, 126);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "PRECIO";
            txtPrecio.Size = new Size(281, 23);
            txtPrecio.TabIndex = 4;
            // 
            // txtDesarrolladora
            // 
            txtDesarrolladora.Location = new Point(34, 97);
            txtDesarrolladora.Name = "txtDesarrolladora";
            txtDesarrolladora.PlaceholderText = "DESARROLLADORA";
            txtDesarrolladora.Size = new Size(281, 23);
            txtDesarrolladora.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(34, 68);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "DESCRIPCION";
            txtDescripcion.Size = new Size(281, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(34, 39);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "TITULO";
            txtTitulo.Size = new Size(281, 23);
            txtTitulo.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIdModificar);
            groupBox2.Controls.Add(btnConfirmarModificar);
            groupBox2.Controls.Add(txtNuevoPrecio);
            groupBox2.Controls.Add(txtNuevaDesarrolladora);
            groupBox2.Controls.Add(txtNuevaDescripcion);
            groupBox2.Controls.Add(txtNuevoTitulo);
            groupBox2.Location = new Point(21, 300);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 239);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "MODIFICAR APLICACIÓN";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(34, 39);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.PlaceholderText = "ID APLICACIÓN";
            txtIdModificar.Size = new Size(281, 23);
            txtIdModificar.TabIndex = 5;
            // 
            // btnConfirmarModificar
            // 
            btnConfirmarModificar.Location = new Point(182, 184);
            btnConfirmarModificar.Name = "btnConfirmarModificar";
            btnConfirmarModificar.Size = new Size(133, 34);
            btnConfirmarModificar.TabIndex = 0;
            btnConfirmarModificar.Text = "CONFIRMAR";
            btnConfirmarModificar.UseVisualStyleBackColor = true;
            btnConfirmarModificar.Click += btnConfirmarModificar_Click;
            // 
            // txtNuevoPrecio
            // 
            txtNuevoPrecio.Location = new Point(34, 155);
            txtNuevoPrecio.Name = "txtNuevoPrecio";
            txtNuevoPrecio.PlaceholderText = "PRECIO";
            txtNuevoPrecio.Size = new Size(281, 23);
            txtNuevoPrecio.TabIndex = 4;
            // 
            // txtNuevaDesarrolladora
            // 
            txtNuevaDesarrolladora.Location = new Point(34, 126);
            txtNuevaDesarrolladora.Name = "txtNuevaDesarrolladora";
            txtNuevaDesarrolladora.PlaceholderText = "DESARROLLADORA";
            txtNuevaDesarrolladora.Size = new Size(281, 23);
            txtNuevaDesarrolladora.TabIndex = 3;
            // 
            // txtNuevaDescripcion
            // 
            txtNuevaDescripcion.Location = new Point(34, 97);
            txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            txtNuevaDescripcion.PlaceholderText = "DESCRIPCION";
            txtNuevaDescripcion.Size = new Size(281, 23);
            txtNuevaDescripcion.TabIndex = 2;
            // 
            // txtNuevoTitulo
            // 
            txtNuevoTitulo.Location = new Point(34, 68);
            txtNuevoTitulo.Name = "txtNuevoTitulo";
            txtNuevoTitulo.PlaceholderText = "TITULO";
            txtNuevoTitulo.Size = new Size(281, 23);
            txtNuevoTitulo.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnConfirmarEliminar);
            groupBox3.Controls.Add(txtIdEliminar);
            groupBox3.Location = new Point(21, 562);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 127);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "ELIMINAR APLICACIÓN";
            // 
            // btnConfirmarEliminar
            // 
            btnConfirmarEliminar.Location = new Point(153, 75);
            btnConfirmarEliminar.Name = "btnConfirmarEliminar";
            btnConfirmarEliminar.Size = new Size(133, 34);
            btnConfirmarEliminar.TabIndex = 6;
            btnConfirmarEliminar.Text = "CONFIRMAR";
            btnConfirmarEliminar.UseVisualStyleBackColor = true;
            btnConfirmarEliminar.Click += btnConfirmarEliminar_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(34, 34);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.PlaceholderText = "ID APLICACIÓN";
            txtIdEliminar.Size = new Size(252, 23);
            txtIdEliminar.TabIndex = 0;
            // 
            // dgvAplicaciones
            // 
            dgvAplicaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAplicaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAplicaciones.Location = new Point(400, 23);
            dgvAplicaciones.Name = "dgvAplicaciones";
            dgvAplicaciones.Size = new Size(641, 649);
            dgvAplicaciones.TabIndex = 8;
            // 
            // btnCrearUnica
            // 
            btnCrearUnica.Location = new Point(182, 193);
            btnCrearUnica.Name = "btnCrearUnica";
            btnCrearUnica.Size = new Size(133, 56);
            btnCrearUnica.TabIndex = 7;
            btnCrearUnica.Text = "CREAR UNICA APLICACION";
            btnCrearUnica.UseVisualStyleBackColor = true;
            btnCrearUnica.Click += btnCrearUnica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 747);
            Controls.Add(dgvAplicaciones);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAplicaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTitulo;
        private TextBox txtDescripcion;
        private TextBox txtDesarrolladora;
        private Button btnGuardarCambios;
        private Label label1;
        private ComboBox cmbCategoria;
        private TextBox txtPrecio;
        private GroupBox groupBox2;
        private TextBox txtIdModificar;
        private Button btnConfirmarModificar;
        private TextBox txtNuevoPrecio;
        private TextBox txtNuevaDesarrolladora;
        private TextBox txtNuevaDescripcion;
        private TextBox txtNuevoTitulo;
        private GroupBox groupBox3;
        private Button btnConfirmarEliminar;
        private TextBox txtIdEliminar;
        private DataGridView dgvAplicaciones;
        private Button btnCargarBorrador;
        private Button btnCrearUnica;
    }
}
