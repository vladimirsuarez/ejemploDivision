using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploDivision
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void limpiar()
        {
            txtDividendo.Clear();
            txtDivisor.Clear();
            txtResultado.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }

        public void calcular()
        {
            double dividendo, divisor, resultado = 0;

            try
            {
                dividendo = Double.Parse(txtDividendo.Text);
                divisor = Double.Parse(txtDivisor.Text);
                resultado = Math.Round((dividendo / divisor),2);
            }
            catch(Exception x)
            {
                MessageBox.Show("Error: " + x.Message + " Ingrese valores númericos", "Validación",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtResultado.Text = "Operación sin éxito. Cálculo inválido.";
                txtDividendo.Focus();
                return;
            }

            if (double.IsInfinity(resultado) || double.IsPositiveInfinity(resultado) || double.IsNegativeInfinity(resultado))
            {
                MessageBox.Show("Se está realizando una división entre cero","Validación",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtDivisor.Focus();
            }
            else
            {
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
