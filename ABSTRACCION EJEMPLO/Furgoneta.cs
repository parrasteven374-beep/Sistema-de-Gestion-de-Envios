using System;

namespace ABSTRACCION_EJEMPLO;

public class Furgoneta : Vehiculo
    
{
    public Furgoneta(string placa, string nombre, int velocidadpro)
        : base(placa, nombre, velocidadpro)
    {

    }

    public override int CalcularCosto(int distancia)
    {
        return 7000 * distancia;
    }



}
