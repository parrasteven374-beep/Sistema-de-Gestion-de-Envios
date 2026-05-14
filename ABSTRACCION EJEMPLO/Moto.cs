using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACCION_EJEMPLO;

public class Moto : Vehiculo
{
    public Moto(string placa, string nombre, int velocidadpro)
        : base(placa, nombre, velocidadpro)
    {

    }
    public override int CalcularCosto(int distancia)
    {    
    return 2000 * distancia;
    }

}

