using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACCION_EJEMPLO;
public class Camion : Vehiculo
{
    public Camion(string placa, string nombre, int velocidadpro)
        : base(placa, nombre, velocidadpro)
    {

    }

    public override int CalcularCosto(int distancia)
    {
        return 5000 * distancia;
    }

}