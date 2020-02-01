using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFConversor.Funciones
{
    internal class Calculadora
    {
        double factorDeConversionCentimetrosPulgadas = 2.54;
        public double CorvertirCelsiusAFarenheit(double celsius)
        {
            //(0 °C × 9/5) + 32 =
            
            return Math.Round((celsius * 1.8) + 32,2);
        }

        public double CorvertirCentimetrosAPulgadas(double centimetros)
        {
            //2,54
            return Math.Round(centimetros / factorDeConversionCentimetrosPulgadas,2);
        }

        public double CorvertirFarenheitACelsius(double farenheit)
        {
            //(32 °F − 32) × 5/9 = 0 °C

            return Math.Round((farenheit - 32) * 0.5555,2);
        }

        public double CorvertirPulgadasACentimetros(double pulgadas)
        {
            return Math.Round(pulgadas * factorDeConversionCentimetrosPulgadas,2);
        }
    }
}