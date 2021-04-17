using System;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        double num;
     
        public Numero()
        {
            this.num = 0;
        }
        public Numero(double num)
        {
            this.num = num;
        }
        public Numero(string num) : this(int.Parse(num))
        { }
        private double ValidarNumero(string numero)
        {
            double r = double.Parse(numero);
            foreach (char aux in numero)
            {
                if (aux < '0' || aux > '9')
                {
                    r = 0;
                    break;
                }
            }

            return r;
        }
        public string SetNumero
        {
            get
            {
                return Convert.ToString(this.num);
            }
            set
            {
                this.num = ValidarNumero(value);
            }
        }
        private static bool Es_Binario(string bin)
        {
            bool r = true;
            foreach (char aux in bin)
            {
                if (aux != '1' && aux != '0')
                {
                    r = false;
                    break;
                }
            }
            return r;

        }
        public static string BinarioDecimal(string valor)
        {
            int r = 0;
            Double num;
            string resultado="Valor Invalido";
            int len = valor.Length;
            int j = len - 1;
            if (Es_Binario(valor))
            {
                foreach (char aux in valor)
                {
                    num = Math.Pow(2, j);
                    if (aux == '1')
                    {
                        r = r + Convert.ToInt32(num);
                    }
                    j--;
                }
                resultado = Convert.ToString(r);
            }
            return resultado;
        }
        public static string DecimalBinario(double valor)
        {
            string aux = "";
            string uno = "1";
            string cero = "0";
            int n = 1;
            double copiaValor = valor;
            int i = 0;
            if (valor > 0)
            {
                while (true)
                {
                    n = n * 2;
                    i++;
                    if (n > copiaValor)
                    {
                        n = n / 2;
                        break;
                    }
                }
                for (; i > 0; i--)
                {
                    if (n <= copiaValor)
                    {
                        aux = aux + uno;
                        copiaValor = copiaValor - n;
                        n = n / 2;
                    }
                    else
                    {
                        n = n / 2;
                        aux = aux + cero;
                    }
                }
            }
            else if (valor == 0)
            {
                aux = aux + cero;
            }
            else
            {
                aux = "valor invalido";
            }
            return aux;
        }
        public static string DecimalBinario(string valor)
        {
            return DecimalBinario(double.Parse(valor));
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.num - n2.num;
        }
        public static double operator +(Numero n1,Numero n2)
        {
            return n1.num + n2.num;
        }
        public static double operator /(Numero n1,Numero n2)
        {
            double r = double.MinValue;
            if (n2.num != 0)
            {
                r = n1.num / n2.num;
            }
            return r;
        }
        public static double operator *(Numero n1,Numero n2)
        {
            return n1.num * n2.num;
        }
    }
}
