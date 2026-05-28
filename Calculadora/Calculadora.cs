namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        private double resultado;
        public double Resultado {get => resultado;}

        public void Sumar(double termino)
        {
            dato += termino;
            resultado = dato;
        }
        public void Restar(double termino)
        {
            dato -= termino;
            resultado = dato;
        }
        public void Multiplicar(double termino)
        {
            dato *= termino;
            resultado = dato;
        
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
                resultado = dato;
            }
        }
        public void Limpiar(double termino)
        {
            dato =  0;
            termino = 0;
        }

    }


}