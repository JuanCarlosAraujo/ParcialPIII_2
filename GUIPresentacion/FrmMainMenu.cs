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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnRegistrarAfiliado_Click(object sender, EventArgs e)
        {
            openFormChild(new FrmRegistroAfiliado());
        }

        private void openFormChild(object formChild)
        {
            if (this.panelChild.Controls.Count > 0)
            {
                this.panelChild.Controls.RemoveAt(0);
            }

            Form child = formChild as Form;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.panelChild.Controls.Add(child);
            this.panelChild.Tag = child;
            child.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFormChild(new FrmConsultarAfiliados());
        }

        private void btnRegistroLiquidacion_Click(object sender, EventArgs e)
        {
            openFormChild(new FrmRegistrarLiquidacion());
        }
    }
}
