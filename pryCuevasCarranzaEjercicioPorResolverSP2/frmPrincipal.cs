using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCuevasCarranzaEjercicioPorResolverSP2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 49 || e.KeyChar > 56)
            {
                e.Handled = true;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            cboTipoBoleto.Items.Add("Estandar");
            cboTipoBoleto.Items.Add("Premium");
            cboTipoBoleto.Items.Add("Ultra");

            cboTipoBoleto.DropDownStyle = ComboBoxStyle.DropDownList;

            rbCorta.Checked = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Complete el código", "Carga Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtCodigo.Focus();
                txtCodigo.BackColor = Color.Red;
            }
            else
            {
                if (cboTipoBoleto.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de boleto", "Carga Datos",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtCodigo.Focus();
                    txtCodigo.BackColor = Color.Red;

                }
                else
                {
                    MessageBox.Show("Registramos su boleto", "Registro de boleto",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text !="")
            {
                txtCodigo.BackColor = SystemColors.ControlLight;
            }

        }
    }
}
