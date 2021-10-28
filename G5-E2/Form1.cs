using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace G5_E2
{
    public partial class Form1 : Form
    {
        alumno Alumno = new alumno();
        public Form1()
        {
            InitializeComponent();
        }
        ///Validacion campo Carnet para que admita solo el formato establecido
        ///Metodo de validacion 
        public static bool validarCarnet(string carnet)
        {
            //Expresion regular que verifica a un formato de correo electrónico 
            string expresion = "[A-Z]{2}[0-9]{6}";
            //verifica que el email ingresado corresponda con la expresion válida 
            if (Regex.IsMatch(carnet, expresion))
            {
                //verifica que la direccion corresponda y que la longitud de la cadena no esté vacía 
                if (Regex.Replace(carnet, expresion, string.Empty).Length==0)
                { return true; }
                else
                { return false; }
            } else
            { return false; }
        }
        private void txtCarnet_Leave(object sender, EventArgs e)
        {
            if (validarCarnet(txtCarnet.Text))
            {
                //si es correcto no debe hacer nada 
            }
            else
            {
                /*sino es correcto que envíe este mensaje y se posicione para verificar recuerde que se activará la validación al dar click en otro textbox o simplemente dejar o salir de esa casilla de email*/
                MessageBox.Show("Formata de Carnet invalido");
                txtCarnet.SelectAll(); //selecciona todo lo de la casilla
                txtCarnet.Focus(); //se posiciona ahí de nuevo
            }
        }

        private void txCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        ///VAlidaciond el campo nombres solo admite letras
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProviderAlumnos.SetError(txtNombres, "");
            //condicion para solo lletras
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //para backspace 
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            //si no cumple nada de lo anterior que no lo deje pasar 
            else { e.Handled = true;
                errorProviderAlumnos.SetError(txtNombres, "Solo se admiten letras");
            }

        }

        private void txtResponsable_TextChanged(object sender, EventArgs e)
        {

        }
        ///Validaciond el campo Responsable solo admite letras
        private void txtResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProviderAlumnos.SetError(txtResponsable, "");
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
                errorProviderAlumnos.SetError(txtResponsable, "Solo se admiten letras");
            }
        }
        ////Validacion de correo
        public static bool validaremail(string email)
        {
            //Expresion regular que verifica a un formato de correo electrónico 
            string expresion =@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
            //verifica que el email ingresado corresponda con la expresion válida 
            if (Regex.IsMatch(email,expresion))
            {
                //verifica que la direccion corresponda y que la longitud de la cadena no esté vacía 
                if (Regex.Replace(email,expresion,string.Empty).Length==0)
                { return true; }
                else
                { return false; }
            } else
            { return false; }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (validaremail(txtEmail.Text))
            {
                //si es correcto no debe hacer nada 
            } else {
                /*sino es correcto que envíe este mensaje y se posicione para verificar recuerde que se activará la validación al dar click en otro textbox o simplemente dejar o salir de esa casilla de email*/
                MessageBox.Show("Dirección de correo no válida");
                txtEmail.SelectAll(); //selecciona todo lo de la casilla 
                txtEmail.Focus(); //se posiciona ahí de nuevo
            }
        }
        //Validacion de compos nulos y fecha 
        private bool validarCampos()
        {
            bool ok = true;
            if (txtCarnet.Text == "") //vefica que no quede vacío el campo
            {
                ok = false;
                errorProviderAlumnos.SetError(txtCarnet,"Ingrese el Carnet");
            }
            if (txtNombres.Text == "") //vefica que no quede vacío el campo
            {
                ok = false;
                errorProviderAlumnos.SetError(txtNombres, "Ingrese El nombre compelto");
            }
            if (txtResponsable.Text == "") //vefica que no quede vacío el campo
            {
                ok = false;
                errorProviderAlumnos.SetError(txtResponsable, "Ingrese el del responsable");
            }
            ///Fecha 
            DateTime fecha = dateTimePicker1.Value;
            int anios = System.DateTime.Now.Year - fecha.Year;
            if (anios <= 15)
            {
                ok = false;
                errorProviderAlumnos.SetError(dateTimePicker1, "La Edad debe ser mayor a 15 años");
            }
            return ok;
        }
        ///Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            validarCampos();
            if (validarCampos())
            {
                try
                {
                    alumno Alumno = new alumno();
                    Alumno.Carnet = txtCarnet.Text;
                    Alumno.Nombres = txtNombres.Text;
                    Alumno.Fecha = dateTimePicker1.Value.Date;
                    Alumno.Responsable = txtResponsable.Text;
                    MessageBox.Show("Usuario registrado exitosamente");
                    ///Envio de informacion al segundo form 
                    
                    Notas notas = new Notas(Alumno.Nombres, Alumno.Carnet);
                    notas.Show();
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message);
                }
               
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            errorProviderAlumnos.SetError(dateTimePicker1, "");
        }
    }
}
