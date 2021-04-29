using System;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double num;
     
        public Numero()
        {
            this.num = 0;
        }
        public Numero(double num)
        {
            this.num = num;
        }
        public Numero(string num) : this(double.Parse(num))
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
            int num;
            string resultado="Valor Invalido";
            int len = valor.Length;
            int j = len - 1;
            if (Es_Binario(valor))
            {
                foreach (char aux in valor)
                {
                    num = Convert.ToInt32(Math.Pow(2, j));
                    if (aux == '1')
                    {
                        r = r + num;
                    }
                    j--;
                }
                resultado = Convert.ToString(r);
            }
            return resultado;
        }
        public static string DecimalBinario(double valor)
        {
            long binario = 0;
            int numero = Convert.ToInt32(valor);
            long digito = 0;
            if (valor >= 0)
            {
                if (valor - numero < 0)
                {
                    numero = numero - 1;
                }
                for (int i = numero % 2, j = 0; numero > 0; numero /= 2, i = numero % 2, j++)
                {
                    digito = i % 2;
                    binario += digito * (long)Math.Pow(10, j);
                }
            }
            else
            {
                return "Valor Invalido";
            }
            
            return Convert.ToString(binario);
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
