using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //método para llenar el datagridView
        private void listar()
        {
            try
            {
                dgvEmpleado.DataSource = NegocioEmpleado.ListarEmpleado();
                this.Formato();
                lblTotal.Text = "Total de registros: " + Convert.ToString(dgvEmpleado.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al listar los empleados. " + ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Formato()
        {
            dgvEmpleado.Columns[0].Visible = false; // check seleccionar oculta
            dgvEmpleado.Columns[1].Visible = false; // Id quedara oculta
            dgvEmpleado.Columns[2].Width = 200;
            dgvEmpleado.Columns[3].Width = 100;
            dgvEmpleado.Columns[4].Width = 100;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listar();
        }
        // metodo buscar los registro
        private void Buscar()
        {
            try
            {
                dgvEmpleado.DataSource = NegocioEmpleado.BuscarEmpleado(txtBuscar.Text);
                this.Formato();
                lblTotal.Text = "Total de registros: " + Convert.ToString(dgvEmpleado.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al listar los empleados. " + ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}