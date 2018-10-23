using SegundoParcial.BLL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial.UI
{
    public partial class RVendedorSegundoP : Form
    {
        RepositorioBase<Vendedor> repositorio;
        public List<VendedorDetalle> Detalle { get; set; }
        public RVendedorSegundoP()
        {
            InitializeComponent();
            this.Detalle = new List<VendedorDetalle>();
            LlenarComboBox();
         
        }
        public void LlenarComboBox()
        {
            RepositorioBase<VendedorDetalle> repositorio = new RepositorioBase<VendedorDetalle>();
            MetascomboBox.DataSource = repositorio.GetList(x => true);
            MetascomboBox.ValueMember = "Metas";
            MetascomboBox.DisplayMember = "Descripcion";
            MetascomboBox.ValueMember = "Cuota";
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            SueldonumericUpDown.Value = 0;
            RetencionnumericUpDown.Value = 0;
            TotalnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            this.Detalle = new List<VendedorDetalle>();
            CargarGrid();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Vendedor LlenarClase()
        {
            Vendedor vendedor = new Vendedor();
            vendedor.VendedorID = Convert.ToInt32(IDnumericUpDown.Value);
            vendedor.Nombre = NombretextBox.Text;
            vendedor.Sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            vendedor.Restencion = Convert.ToDecimal(RetencionnumericUpDown.Value);
            vendedor.Restencion = Convert.ToDecimal(TotalnumericUpDown.Value);
            vendedor.FechaVendedor = FechadateTimePicker.Value;
            vendedor.Metas = this.Detalle;
            return vendedor;
        }
        private void LlenarCampo(Vendedor vendedor)
        {
            IDnumericUpDown.Value = vendedor.VendedorID;
            NombretextBox.Text = vendedor.Nombre;
            SueldonumericUpDown.Value = vendedor.Sueldo;
            RetencionnumericUpDown.Value = vendedor.Restencion;
            TotalnumericUpDown.Value = vendedor.Total;
            FechadateTimePicker.Value = vendedor.FechaVendedor;
            this.Detalle = vendedor.Metas;
            CargarGrid();
        }

        private void CargarGrid()
        {
            MetasdataGridView.DataSource = null;
            MetasdataGridView.DataSource = this.Detalle;
        }
        private bool Validar()
        {
            errorProvider.Clear();
            bool paso = true;

            if (TotalnumericUpDown.Value <= 0)
            {
                errorProvider.SetError(TotalnumericUpDown, "Ingre Porciento retencion");
                paso = false;
            }

            if (RetencionnumericUpDown.Value <= 0)
            {
                errorProvider.SetError(RetencionnumericUpDown, "Ingre Retencion");
                paso = false;
            }
            if (SueldonumericUpDown.Value <= 0)
            {
                errorProvider.SetError(SueldonumericUpDown, "Digite Sueldo");
            }
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "Ingre Nombre");
                paso = false;
            }
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Vendedor>();
            Vendedor vendedor = repositorio.Buscar((int)IDnumericUpDown.Value);
            return (vendedor != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedor>();
            Vendedor vendedor;
            bool paso = false;

            vendedor = LlenarClase();
            if (!Validar())
                return;

            if (IDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(vendedor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar no Exite!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                paso = MetasBLL.Modificar(vendedor);
            }
            Limpiar();
            if (paso)
            {
                MessageBox.Show("Guadado!!", "Guardo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            repositorio = new RepositorioBase<Vendedor>();
            int.TryParse(IDnumericUpDown.Text, out id);
            if (!ExisteEnLaBaseDeDatos())
            {
                errorProvider.SetError(IDnumericUpDown, "No Eliminado");
                IDnumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
                MessageBox.Show("Eliminada ");
            else
            {
                MessageBox.Show("No Elimino");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            repositorio = new RepositorioBase<Vendedor>();
            Vendedor presupuesto = new Vendedor();
            int.TryParse(IDnumericUpDown.Text, out id);
            presupuesto = repositorio.Buscar(id);
            if (presupuesto != null)
            {
                LlenarCampo(presupuesto);
                MessageBox.Show("Encotrada");
            }
            else
            {
                MessageBox.Show("No Encotro");
            }
        }

        private void SueldonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            decimal Porciento = Convert.ToDecimal(RetencionnumericUpDown.Value);
            Porciento /= 100;
            decimal reticion = sueldo * Porciento;
            TotalnumericUpDown.Value = reticion;
        }

        private void RetencionnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            decimal Porciento = Convert.ToDecimal(RetencionnumericUpDown.Value);
            Porciento /= 100;
            decimal reticion = sueldo * Porciento;
            TotalnumericUpDown.Value = reticion;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Metasbutton_Click(object sender, EventArgs e)
        {
            RMetas rm = new RMetas();
            rm.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MetasdataGridView.DataSource != null)
                this.Detalle = (List<VendedorDetalle>)MetasdataGridView.DataSource;
            this.Detalle.Add(
                new VendedorDetalle(
                     /*Venid: 0,
                    VendorID: (int)vendedorIDNumericUpDown.Value,
                    Cuota: Convert.ToDouble(CuotatextBox.Text),
                    MetasID: conve
                    */
                    )
                );
            errorProvider.Clear();
            CargarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MetasdataGridView.Rows.Count > 0 && MetasdataGridView.CurrentRow != null)
            {
                this.Detalle.RemoveAt(MetasdataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }
    }
}
