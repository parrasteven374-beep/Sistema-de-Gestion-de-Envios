using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACCION_EJEMPLO;

public abstract class Vehiculo
{
    public string Placa;
    public string Nombre;
    public int VelocidadPro;

    public Vehiculo(string placa, string nombre, int velocidadpro)
    {
        this.Placa = placa;
        this.Nombre = nombre;
        this.VelocidadPro = velocidadpro;
    }

    public int CalcularTiempoEstimado(int distancia)
    {
        return distancia / VelocidadPro;
    }

    public abstract int CalcularCosto(int distancia);
}
