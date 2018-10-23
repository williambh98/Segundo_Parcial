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
    public partial class RMetas : Form
    {
        RepositorioBase<Metas> repositorio;
        public RMetas()
        {
            InitializeComponent();
        }

        public Metas LlenarClase()
        {
            Metas metas = new Metas();
            metas.Metaid = Convert.ToInt32(MetaIDnumericUpDown.Value);
            metas.Descripcion = DescripciontextBox.Text;
            metas.Cuota = Convert.ToDecimal(CuotanumericUpDown.Value);
            return metas;
        }

        public void Llenarcampo(Metas metas)
        {
            MetaIDnumericUpDown.Value = metas.Metaid;
            DescripciontextBox.Text = metas.Descripcion;
            CuotanumericUpDown.Value = metas.Cuota;
        }

        public void Limpiar()
        {
            MetaIDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CuotanumericUpDown.Value = 0;
        }

        private bool ExisteEnLaBD()
        {
            repositorio = new RepositorioBase<Metas>();
            Metas metas = repositorio.Buscar((int)MetaIDnumericUpDown.Value);
            return (metas != null);

        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Metas>();

            Metas metas;
            bool paso = false;
            metas = LlenarClase();

            if (MetaIDnumericUpDown.Value >= 0)
            {

                paso = repositorio.Guardar(metas);

            }
            else
            {
                if (!ExisteEnLaBD())
                {
                    MessageBox.Show("No exite ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(metas);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show(" No Guardo !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Metas Mvendedor = new Metas();
            repositorio = new RepositorioBase<Metas>();
            int id;
            int.TryParse(MetaIDnumericUpDown.Text, out id);
            Mvendedor = repositorio.Buscar(id);
            if (Mvendedor != null)
            {
                Llenarcampo(Mvendedor);
                MessageBox.Show("Encontada", "Exito", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("No Encontrado", "Error", MessageBoxButtons.OK);
        }
    }
}
