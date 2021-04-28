using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            Text = "Calculadora de S. Ariel Limachi Ramos del Curso 2°A";
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.textNumero1.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.textNumero1.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Convert.ToString(Operar(this.textNumero1.Text ,this.textNumero2.Text,this.cmbOperador.Text));
        }
        private void Limpiar()
        {
            this.textNumero1.Text = "0";
            this.textNumero2.Text = "0";
            this.lblResultado.Text = "0";
            this.cmbOperador.Text = "+";
        }
        private double Operar(string numero1,string numero2,string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);
        }
    }
}
