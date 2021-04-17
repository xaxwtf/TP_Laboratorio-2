using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Calculadora
    {
        private static string ValidarOperador(char operador)
        {
            string r = "+";
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                r = Convert.ToString(operador);
            }
            return r;
        }
        public static double Operar(Numero n1, Numero n2, string op)
        {
            double r = 0;
            if (op=="+"|| op == "-" || op == "*" || op == "/")
            {
                switch (Calculadora.ValidarOperador(char.Parse(op)))
                {
                    case "+":
                        r = n1 + n2;
                        break;
                    case "-":
                        r = n1 - n2;
                        break;
                    case "*":
                        r = n1 * n2;
                        break;
                    case "/":
                        r = n1 / n2;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                r = n1 + n2;
            }
            return r;
        }
    }
    
}
