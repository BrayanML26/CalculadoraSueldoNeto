using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculadoraSueldoNeto
{
    public partial class Form1 : Form
    {
        // Constants for tax rates and brackets
        private const decimal SFS_RATE = 0.0304m;
        private const decimal AFP_RATE = 0.0287m;
        private const decimal ISR_RATE_15 = 0.15m;
        private const decimal ISR_RATE_20 = 0.20m;
        private const decimal ISR_RATE_25 = 0.25m;

        private const decimal ISR_BRACKET_1 = 416220.00m;
        private const decimal ISR_BRACKET_2 = 624329.00m;
        private const decimal ISR_BRACKET_3 = 867123.00m;
        private const decimal ISR_FIXED_AMOUNT_1 = 31216.00m;
        private const decimal ISR_FIXED_AMOUNT_2 = 79776.00m;

        // Update these constants with current values
        //private const decimal ISR_BRACKET_1 = 449996.00m;    // Was: 416220.00m
        //private const decimal ISR_BRACKET_2 = 674994.00m;    // Was: 624329.00m
        //private const decimal ISR_BRACKET_3 = 937492.00m;    // Was: 867123.00m
        //private const decimal ISR_FIXED_AMOUNT_1 = 33749.70m; // Was: 31216.00m
        //private const decimal ISR_FIXED_AMOUNT_2 = 86249.70m; // Was: 79776.00m

        public Form1()
        {
            InitializeComponent();
        }

        private void txtSueldoBrutoMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, decimal point, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                decimal sueldoBrutoMensual = decimal.Parse(txtSueldoBrutoMensual.Text);
                CalculateAndDisplaySalary(sueldoBrutoMensual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtSueldoBrutoMensual.Text))
            {
                MessageBox.Show("Por favor ingrese el sueldo bruto mensual.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtSueldoBrutoMensual.Text, out _))
            {
                MessageBox.Show("El sueldo ingresado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CalculateAndDisplaySalary(decimal sueldoBrutoMensual)
        {
            // Calculate biweekly gross salary
            decimal sueldoBrutoQuincenal = decimal.Round(sueldoBrutoMensual / 2, 2);
            txtSueldoBrutoQuincenal.Text = $"= {sueldoBrutoQuincenal:N2}";

            // Calculate SFS (Health Insurance)
            decimal pagoSFSQuincenal = decimal.Round(sueldoBrutoMensual * SFS_RATE / 2, 2);
            txtPagoSFSQuincenal.Text = $"= {pagoSFSQuincenal:N2}";

            // Calculate AFP (Pension)
            decimal pagoAFPQuincenal = decimal.Round(sueldoBrutoMensual * AFP_RATE / 2, 2);
            txtPagoAFPQuincenal.Text = $"= {pagoAFPQuincenal:N2}";

            // Calculate annual taxable income
            decimal sfsMensual = pagoSFSQuincenal * 2;
            decimal afpMensual = pagoAFPQuincenal * 2;
            decimal sueldoBrutoAnual = (sueldoBrutoMensual - sfsMensual - afpMensual) * 12;

            // Calculate ISR (Income Tax)
            decimal pagoISRQuincenal = CalculateISR(sueldoBrutoAnual);
            decimal isrQuincenal = decimal.Round(pagoISRQuincenal / 24, 2);
            txtPagoISRQuincenal.Text = $"= {isrQuincenal:N2}";

            // Calculate net biweekly salary
            decimal sueldoNetoQuincenal = sueldoBrutoQuincenal - pagoSFSQuincenal - pagoAFPQuincenal - isrQuincenal;
            txtSueldoNetoQuincenal.Text = $"= {sueldoNetoQuincenal:N2}";
        }

        private decimal CalculateISR(decimal sueldoBrutoAnual)
        {
            if (sueldoBrutoAnual <= ISR_BRACKET_1)
                return 0;

            if (sueldoBrutoAnual <= ISR_BRACKET_2)
                return (sueldoBrutoAnual - ISR_BRACKET_1) * ISR_RATE_15;

            if (sueldoBrutoAnual <= ISR_BRACKET_3)
                return (sueldoBrutoAnual - ISR_BRACKET_2) * ISR_RATE_20 + ISR_FIXED_AMOUNT_1;

            return (sueldoBrutoAnual - ISR_BRACKET_3) * ISR_RATE_25 + ISR_FIXED_AMOUNT_2;
        }
    }
}