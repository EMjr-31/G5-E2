using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5_E2
{
    public partial class Notas : Form
    {
        public Notas(string nom, string car)
        {
            InitializeComponent();
            txtnom.Text = nom;
            txtcarnet.Text = car;
            txtMat.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProviderNotas.SetError(txtMat, "");
            //condicion para solo lletras
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //para backspace 
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            //si no cumple nada de lo anterior que no lo deje pasar 
            else
            {
                e.Handled = true;
                errorProviderNotas.SetError(txtMat, "Solo se admiten letras");
            }
        }

        private void txtp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProviderNotas.SetError(txtp1, "");
            //condicion para solo números 
            if (char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //verifica que pueda ingresar punto y también que solo pueda ingresar un punto
            else if ((e.KeyChar == '.') && (!txtp1.Text.Contains("."))) { e.Handled = false; }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar 
            else
            {
                e.Handled = true;
                errorProviderNotas.SetError(txtp1, "Solo se admiten numeros");
            }
        }

        private void txtp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProviderNotas.SetError(txtp2, "");
            //condicion para solo números 
            if (char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            //para tecla backspace 
            else  if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //verifica que pueda ingresar punto y también que solo pueda ingresar un punto
            else if ((e.KeyChar == '.') && (!txtp2.Text.Contains("."))) { e.Handled = false; }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar 
            else
            {
                e.Handled = true;
                errorProviderNotas.SetError(txtp2, "Solo se admiten numeros");
            }
        }

        private void txtp3_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProviderNotas.SetError(txtp3, "");
            //condicion para solo números 
            if (char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            { e.Handled = false; }
            //verifica que pueda ingresar punto y también que solo pueda ingresar un punto
            else if ((e.KeyChar == '.') && (!txtp3.Text.Contains("."))) { e.Handled = false; }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar 
            else
            {
                e.Handled = true;
                errorProviderNotas.SetError(txtp3, "Solo se admiten numeros");
            }
        }

        //Validacion de compos nulos y fecha 
        private bool validarCampos()
        {
            bool ok = true;
            errorProviderNotas.SetError(txtp1, "");
            errorProviderNotas.SetError(txtp2, "");
            errorProviderNotas.SetError(txtp3, "");
            if (txtMat.Text == "") //vefica que no quede vacío el campo
            {
                ok = false;
                errorProviderNotas.SetError(txtMat, "Ingrese l Materia");
            }
            if (txtp1.Text == "") //vefica que no quede vacío el campo
            {
                ok = false;
                errorProviderNotas.SetError(txtp1, "Ingrese la nota dle primer periodo");
            }
            if (txtp2.Text == "") //vefica que no quede vacío el campo
            {
                ok = false;
                errorProviderNotas.SetError(txtp2, "Ingrese la nota dle primer periodo");
            }
            if (txtp3.Text == "") //vefica que no quede vacío el campo
            {
                ok = false;
                errorProviderNotas.SetError(txtp3, "Ingrese la nota dle primer periodo");
            }
            if (!(double.Parse(txtp1.Text)>=0 && double.Parse(txtp1.Text) <= 10))
            {
                ok = false;
                errorProviderNotas.SetError(txtp1, "nota fuera del rango");
            }
            if (!(double.Parse(txtp2.Text) >= 0 && double.Parse(txtp2.Text) <= 10))
            {
                ok = false;
                errorProviderNotas.SetError(txtp2, "nota fuera del rango");
            }
            if (!(double.Parse(txtp3.Text) >= 0 && double.Parse(txtp3.Text) <= 10))
            {
                ok = false;
                errorProviderNotas.SetError(txtp3, "nota fuera del rango");
            }
            return ok;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            validarCampos();
            if (validarCampos())
            {
                double not1, not2, not3, pro;
                not1 = double.Parse(txtp1.Text);
                not2 = double.Parse(txtp2.Text);
                not3 = double.Parse(txtp3.Text);
                pro = (not1 + not2 + not3) / 3;
                lbNotaProm.Text = "Nota promerio= " + pro.ToString();
            }
        }
    }
}
