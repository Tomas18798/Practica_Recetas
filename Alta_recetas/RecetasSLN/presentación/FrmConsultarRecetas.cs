using RecetasSLN.datos;
using RecetasSLN.dominio;
using RecetasSLN.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultarRecetas : Form
    {
        private gestor Gestor;
        private Receta oReceta;

        public FrmConsultarRecetas()
        {
            Gestor = new gestor(new DaoFactory());
            oReceta = new Receta();

            InitializeComponent();

            CargarCombo();
        }

        private void CargarCombo()
        {
            List<Ingrediente> lista = Gestor.obtenerIngredientes();
            cboIngredientes.DataSource = lista;
            cboIngredientes.ValueMember = "IngredienteId";
            cboIngredientes.DisplayMember = "Nombre";
        }

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            Ingrediente ing = (Ingrediente)cboIngredientes.SelectedItem;
            int cantidad = Convert.ToInt32(cantidadIngrediente.Value);
            DetalleReceta detalle = new DetalleReceta(ing, cantidad);

            oReceta.agregarDetalle(detalle);
            grilla.Rows.Add(new object[] { ing.IngredienteId,ing.Nombre,detalle.Cantidad});
        }
    }
}
