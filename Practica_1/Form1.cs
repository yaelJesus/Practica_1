using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtDato1.Text == "" || txtDato2.Text == "")
            {
                MessageBox.Show("Ingrese los valores en los campos deseados");
            }
            double suma, resta, multi, divicion, min, max, rc, pow, redoneo, total;
            double d1 = double.Parse(txtDato1.Text), d2 = double.Parse(txtDato2.Text);
            total = suma = d1 + d2;
            total = resta = d1 - d2;
            total = multi = d1 * d2;
            total = divicion = d1 / d2;
            min = Math.Min(d1, d2);
            max = Math.Max(d1, d2);
            rc = Math.Sqrt(total);
            pow = Math.Pow(d1, d2);
            redoneo = Math.Round(total);

            if (rbSuma.Checked == true)
            {
                label3.Text = "El resultado de la suma es: " + suma;
            }
            if (rbResta.Checked == true)
            {
                label3.Text = "El resultado de la resta es: " + resta;
            }
            if (rbMulti.Checked == true)
            {
                label3.Text = "El resultado de la multiplicación es: " + multi;
            }
            if (rbDivicion.Checked == true)
            {
                label3.Text = "El resultado de la divición es: " + divicion;
            }
            if (rbMin.Checked == true)
            {
                label4.Text = "El valor minimo es: " + min;
            }
            if (rbMax.Checked == true)
            {
                label4.Text = "El valor maximo es: " + max;
            }
            if (rbRC.Checked == true)
            {
                label4.Text = "El resultado de la raiz es: " + rc;
            }
            if (rbPow.Checked == true)
            {
                label4.Text = "EL valor " + d1 + " potenciado a " + d2 + " es: " + pow;
            }
            if (rbRedondeo.Checked == true)
            {
                label4.Text = "El valor redondeado es: " + redoneo;
            }
            if (rbPI.Checked == true)
            {
                label4.Text = "La constante de PI es: " + Math.PI;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDato1.Clear();
            txtDato2.Clear();
            rbSuma.Checked = rbResta.Checked = rbMulti.Checked = rbDivicion.Checked = rbMin.Checked = 
                rbMax.Checked = rbRC.Checked = rbPow.Checked = rbRedondeo.Checked = rbPI.Checked = false;
            label3.Text = "";
            label4.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
