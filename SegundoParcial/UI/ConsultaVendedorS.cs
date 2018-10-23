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
    public partial class ConsultaVendedorS : Form
    {
        RepositorioBase<Vendedor> repositorio;
        public ConsultaVendedorS()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Vendedor>();
            if (CristeriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0:
                        listado = repositorio.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CristeriotextBox.Text);
                        listado = repositorio.GetList(p => p.VendedorID == id);
                        break;
                    case 2:
                        listado = repositorio.GetList(p => p.Nombre.Contains(CristeriotextBox.Text));
                        break;
                    case 3:
                        decimal sueldo = Convert.ToDecimal(CristeriotextBox.Text);
                        listado = repositorio.GetList(p => p.Sueldo == sueldo);
                        break;
                    case 4:
                        decimal retencion = Convert.ToDecimal(CristeriotextBox.Text);
                        listado = repositorio.GetList(p => p.Restencion == retencion);
                        break;
                    case 5:
                        decimal total = Convert.ToDecimal(CristeriotextBox.Text);
                        listado = repositorio.GetList(p => p.Total == total);
                        break;
                }
                listado = listado.Where(c => c.FechaVendedor.Date >= DesdedateTimePicker.Value.Date && c.FechaVendedor.Date <= HastadateTimePicker.Value.Date).ToList();

            }
            else
            {
                listado = repositorio.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;

        }

    }
}


