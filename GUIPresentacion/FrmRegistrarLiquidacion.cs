using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPresentacion
{
    public partial class FrmRegistrarLiquidacion : Form
    {
        LiquidacionService liquidacionService = new LiquidacionService();
        Liquidacion liquidacion;
        public FrmRegistrarLiquidacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liquidacion = new LiquidacionMensual(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            liquidacionService.Guardar(liquidacion);
        }
    }
}
