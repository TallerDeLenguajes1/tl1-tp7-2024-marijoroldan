namespace EspacioCalculadora;

public class Calculadora
{
    public double Resultado {get => dato;}
    private double dato = 0;
    public void Sumar(double termino)
    {
        dato += termino;
    }
    public void Restar(double termino)
    {
        dato = termino - dato;
    }
    public void Multiplicar(double termino)
    {
        dato *= termino;
    }
    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            dato = dato / termino;
        }
    }
    public void Limpiar()
    {
        dato = 0;
    }

}