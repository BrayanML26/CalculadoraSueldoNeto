using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSueldoNeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSueldoBrutoMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double SueldoBrutoMensual = double.Parse(txtSueldoBrutoMensual.Text);

            double SueldoBrutoQuincenal = SueldoBrutoMensual / 2;
            txtSueldoBrutoQuincenal.Text = "= " + SueldoBrutoQuincenal;

            double PagoSFSQuincenal = SueldoBrutoMensual * 0.0304 / 2;
            txtPagoSFSQuincenal.Text = "= " + PagoSFSQuincenal;

            double PagoAFPQuincenal = SueldoBrutoMensual * 0.0287 / 2;
            txtPagoAFPQuincenal.Text = "= " + PagoAFPQuincenal;

            double SFSMensual = PagoSFSQuincenal * 2;
            double AFPMensual = PagoAFPQuincenal * 2;
            
            double SueldoBrutoAnual = (SueldoBrutoMensual - SFSMensual - AFPMensual)  * 12;

            double PagoISRQuincenal = 0.00;
            if (SueldoBrutoAnual > 416220.00)
            {
                if (SueldoBrutoAnual > 416220.00 && SueldoBrutoAnual <= 624329.00)
                {
                    PagoISRQuincenal = (SueldoBrutoAnual - 416220.01) * 0.15;
                }
                else if (SueldoBrutoAnual >= 624329.01 && SueldoBrutoAnual <= 867123.00)
                {
                    PagoISRQuincenal = (SueldoBrutoAnual - 624329.001) * 0.20 + 31216.00;
                }
                else
                {
                    PagoISRQuincenal = (SueldoBrutoAnual - 867123.01) * 0.25 + 79776.00;
                }
                txtPagoISRQuincenal.Text = "= " + (PagoISRQuincenal / 24);
            }
            else
            {
                txtPagoISRQuincenal.Text = "= 0.00";
            }

            double SueldoNetoQuincenal = SueldoBrutoQuincenal - PagoSFSQuincenal - PagoAFPQuincenal - (PagoISRQuincenal / 24);
            txtSueldoNetoQuincenal.Text = "= " + SueldoNetoQuincenal;
        }
    }
}
