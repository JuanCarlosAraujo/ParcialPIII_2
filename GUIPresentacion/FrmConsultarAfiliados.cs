using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUIPresentacion
{
    public partial class FrmConsultarAfiliados : Form
    {
        AfiliadoService afiliadoService = new AfiliadoService();
        public FrmConsultarAfiliados()
        {
            InitializeComponent();
            cmbFiltro.Text = "TODOS";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbFiltro.Text == "TODOS")
            {
                ConsultarTodos();
            } else if (cmbFiltro.Text == "ACTIVO" || cmbFiltro.Text == "INACTIVO")
            {
                FiltroEstado();
            }
            else if (cmbFiltro.Text == "FECHA")
            {
                FiltroFecha();
            }
        }


        private void FiltroFecha()
        {
            var respuesta = afiliadoService.BuscarFecha(dtpFechaFiltro.Value);
            if (!respuesta.ExistError)
            {
                dtgConsultaAfiliados.DataSource = respuesta.Afiliados;
            }
            else
            {
                MessageBox.Show(respuesta.MessageError, "Informacion de Consulta");
            }
        }

        private void FiltroEstado()
        {

            var respuesta = afiliadoService.FiltrarEstados(cmbFiltro.Text);
            if (!respuesta.Error)
            {
                dtgConsultaAfiliados.DataSource = respuesta.Afiliados;
            }
            else
            {
                MessageBox.Show(respuesta.MensajeDeError, "Informacion de Consulta");
            }
        }

        private void ConsultarTodos()
        {
            var respuesta = afiliadoService.ConsultarTodos();
            if (!respuesta.Error)
            {
                dtgConsultaAfiliados.DataSource = respuesta.Afiliados;
            }
            else
            {
                MessageBox.Show(respuesta.MensajeDeError, "Informacion de Consulta");
            }
        }

        private void cmbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(cmbFiltro, "porfavor no escriba aqui, seleccione los datos previamente cargados");
            e.Handled = true;
        }
    }
}
