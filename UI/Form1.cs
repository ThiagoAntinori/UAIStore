using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AplicacionBusiness AplicacionBusiness = new AplicacionBusiness();
        private CategoriaBusiness CategoriaBusiness = new CategoriaBusiness();
        private List<AplicacionEntity> listaBorrador = new List<AplicacionEntity>();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                actualizarVista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiarCampos()
        {
            txtTitulo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDesarrolladora.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtIdModificar.Text = string.Empty;
            txtIdEliminar.Text = string.Empty;
            txtNuevoTitulo.Text = string.Empty;
            txtNuevaDescripcion.Text = string.Empty;
            txtNuevaDesarrolladora.Text = string.Empty;
            txtNuevoPrecio.Text = string.Empty;
            cmbCategoria.SelectedValue = -1;
            cmbCategoria.Text = string.Empty;
        }

        private void actualizarDgv()
        {
            try
            {
                dgvAplicaciones.DataSource = null;
                dgvAplicaciones.DataSource = AplicacionBusiness.GetAll();
                dgvAplicaciones.Columns["Categoria"].Visible = false;
                dgvAplicaciones.Columns["DescripcionCategoria"].HeaderText = "Categoria";
                dgvAplicaciones.Columns["IdAplicacion"].HeaderText = "ID";
                dgvAplicaciones.Columns["Precio"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void cargarComboCategoria()
        {
            try
            {
                cmbCategoria.DataSource = null;
                cmbCategoria.DataSource = CategoriaBusiness.GetAll();
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.DisplayMember = "Descripcion";
                cmbCategoria.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void actualizarVista()
        {
            try
            {
                limpiarCampos();
                actualizarDgv();
                cargarComboCategoria();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnCargarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                AplicacionEntity aplicacionBorrador = new AplicacionEntity
                {
                    Titulo = txtTitulo.Text,
                    Desarrolladora = txtDesarrolladora.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = Convert.ToDouble(txtPrecio.Text),
                    Categoria = CategoriaBusiness.GetById((int)cmbCategoria.SelectedValue!)
                };
                listaBorrador.Add(aplicacionBorrador);
                actualizarVista();
                MessageBox.Show($"Se agregó al borrador. Cantidad en espera: {listaBorrador.Count}");
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ingrese el precio en su formato correcto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaBorrador.Count <= 0)
                {
                    throw new Exception("No hay aplicaciones en espera");
                }
                AplicacionBusiness.crearMultiplesAplicaciones(listaBorrador);
                actualizarVista();
                MessageBox.Show("Se cargaron correctamente");
            }
            catch (Exception ex)
            {
                listaBorrador.Clear();
                MessageBox.Show(ex.Message + ". Se descartaron el resto de las aplicaciones del borrador.");
            }
        }

        private void btnConfirmarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                AplicacionEntity aplicacionModificada = new AplicacionEntity
                {
                    IdAplicacion = Convert.ToInt32(txtIdModificar.Text),
                    Titulo = txtNuevoTitulo.Text,
                    Descripcion = txtNuevaDescripcion.Text,
                    Desarrolladora = txtNuevaDesarrolladora.Text,
                    Precio = Convert.ToDouble(txtNuevoPrecio.Text)
                };
                AplicacionBusiness.modificarAplicacion(aplicacionModificada);
                actualizarVista();
                MessageBox.Show("Se modificó la aplicación correctamente");
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ingrese el nuevo precio en su formato correcto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                AplicacionBusiness.eliminarAplicacion(Convert.ToInt32(txtIdEliminar.Text));
                actualizarVista();
                MessageBox.Show("Se eliminó la aplicación correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearUnica_Click(object sender, EventArgs e)
        {
            try
            {
                AplicacionEntity nuevaAplicacion = new AplicacionEntity
                {
                    Titulo = txtTitulo.Text,
                    Desarrolladora = txtDesarrolladora.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = Convert.ToDouble(txtPrecio.Text),
                    Categoria = CategoriaBusiness.GetById((int)cmbCategoria.SelectedValue!)
                };
                AplicacionBusiness.crearAplicacion(nuevaAplicacion);
                actualizarVista();
                MessageBox.Show("Se creó correctamente la aplicación");
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ingrese el nuevo precio en su formato correcto.");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
