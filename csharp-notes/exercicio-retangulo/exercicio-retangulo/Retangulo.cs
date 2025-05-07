namespace exercicio_retangulo;
using System.Globalization;


    internal class Retangulo
    {
        public double largura;
        public double altura;
        public double Area() {
            return (double) largura * altura;
        }

        public double Perimetro()
        {
            return 2.0 * (largura + altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2.0) + Math.Pow(altura, 2.0));
        }
    }

