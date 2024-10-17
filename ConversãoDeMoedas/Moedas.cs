using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversãoDeMoedas
{
    internal class Moedas
    {
        //Real para outras Moedas
        public double RealParaDolar(double ValorEmReal)
        {
            double dolar = ValorEmReal * 0.18;
            return dolar;
        }
        public double RealParaEuro(double ValorEmReal)
        {
            double dolar = ValorEmReal * 0.16;
            return dolar;
        }
       public double RealParaPesos(double ValorEmReal)
        {
            double dolar = ValorEmReal * 173.39;
            return dolar;
        }
        //Dolar para outras Moedas
        public double DolarParaReal(double ValorEmDolar)
        {
            double dolar = ValorEmDolar * 5.66;
            return dolar;
        }
        public double DolarParaEuro(double ValorEmDolar)
        {
            double dolar = ValorEmDolar * 0.92;
            return dolar;
        }
        public double DolarParaPesos(double ValorEmDolar)
        {
            double dolar = ValorEmDolar * 980.75;
            return dolar;
        }
        //Euro para outras Moedas 
        public double EuroParaReal(double ValorEmDolar)
        {
            double dolar = ValorEmDolar * 6.13;
            return dolar;
        }
        public double EuroParaDolar(double ValorEmDolar)
        {
            double dolar = ValorEmDolar * 1.08;
            return dolar;
        }
        public double EuroParaPesos(double ValorEmDolar)
        {
            double dolar = ValorEmDolar * 1061.94;
            return dolar;
        }
        //Pesso para outras Moedas 
        public double PesosParaReal(double ValorEmDolar)
        {
            double dolar = ValorEmDolar * 0.0058;
            return dolar;
        }
        public double PesosParaDolar(double ValorEmDolar)
        {
            double dolar = ValorEmDolar * 0.0010;
            return dolar;
        }
        public double PesosParaEuro(double ValorEmDolar)
        {
            double dolar = ValorEmDolar * 0.00094;
            return dolar;
        }
    }
}
