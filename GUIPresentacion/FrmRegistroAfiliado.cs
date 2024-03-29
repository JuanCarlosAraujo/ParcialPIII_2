﻿using BLL;
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
    public partial class FrmRegistroAfiliado : Form
    {
        public AfiliadoService afiliadoService = new AfiliadoService();
        public Afiliado afiliado;
        public FrmRegistroAfiliado()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txtNombre, "solo se admiten letras");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private bool ValidarCamposVacios()
        {
            if (cmbID.Text == "")
            {
                errorProvider1.SetError(cmbID, "Campos vacios");
                return false;
            }
            else if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Campos vacios");
                return false;
            }
            else if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Campos vacios");
                return false;
            }
            else if (cmbEstado.Text == "")
            {
                errorProvider1.SetError(cmbID, "CamposVacios");
                return false;
            }
            else return true;
        }
        private bool ValidarRepetido()
        {
            var afiliado = afiliadoService.BuscarID(Convert.ToInt32(txtID.Text));
            if (afiliado.Repetido)
            {
                MessageBox.Show("Ya existe un afilidiado con esta ID", "Informacion al guardar");
            }
            return afiliado.Repetido;
        }
        private bool ValidarFecha()
        {
            if (dtpFechaNacimiento.Value > dtpFechaAfiliacion.Value)
            {
                errorProvider1.SetError(dtpFechaNacimiento,
                    "La fecha de Afiliación debe ser mayor o igual a la fecha de nacimiento");
                return false;
            }
            else return true;
        }

        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(cmbEstado, "porfavor no escriba aqui, seleccione los datos previamente cargados");
            e.Handled = true;
        }

        private void cmbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(cmbID, "porfavor no escriba aqui, seleccione los datos previamente cargados");
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios() && ValidarFecha() && !ValidarRepetido())
            {
                MessageBox.Show(Guardar(), "Informacion al guardar");
            }
        }

        private string Guardar()
        {
            afiliado = new Afiliado(cmbID.Text, Convert.ToInt32(txtID.Text),
                txtNombre.Text, dtpFechaNacimiento.Value, dtpFechaAfiliacion.Value, cmbEstado.Text );
            return afiliadoService.Guardar(afiliado);
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txtID, "solo se admiten numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }
    }
    
}
