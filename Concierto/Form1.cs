using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concierto
{
    public partial class frmConcierto : Form
    {
        public frmConcierto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                // instanciar a la clase Concierto
                CONCIERTO obj = new CONCIERTO(txtNroEntrada.Text, cboSector.Text,
                                                cboTipoComprador.Text, int.Parse(txtCantidad.Text));
                //

                MessageBox.Show("Nueva entrada grabada con éxito", "INFORMATIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
                // agregar el nuevo vehiculo al ListView
                // crear un nuevo elemento del ListView (ListViewItem)
                ListViewItem fila = new ListViewItem(obj.NroEntrada.ToString());
                // agregar las demás columnas por medio de la propiedad subitems
                fila.SubItems.Add(DateTime.Now.ToString ("dd/MM/yyyy"));
                fila.SubItems.Add(obj.Sector);
                fila.SubItems.Add(obj.Precio.ToString());
                fila.SubItems.Add(obj.Cantidad.ToString());
                fila.SubItems.Add(obj.Subtotal.ToString());
                fila.SubItems.Add(obj.Descuento.ToString());
                fila.SubItems.Add(obj.TotalPago.ToString());

                // agregar el nuevo elemento al ListView
                lvEntradas.Items.Add(fila);

                // mostrar la cantidad de elementos en lblCantidad
                lblCantidad.Text = lvEntradas.Items.Count.ToString();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show("Error en el código, revise que hayan datos ingresados y correctos. " +
                    "               \n \n Valores permitidos: \n" +
                    "               \n * Nro Entrada es texto. " +
                    "               \n * Sector es item de lista." +
                    "               \n * Tipo Comprador es item de lista." + 
                    "               \n * Cantidad es número entero.", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtNroEntrada.Text = "";
            cboSector.Text = "";
            cboTipoComprador.Text = "";
            lvEntradas.Clear();
            lblCantidad.Text = "0";
            txtNroEntrada.Focus();
        }
    }
}
