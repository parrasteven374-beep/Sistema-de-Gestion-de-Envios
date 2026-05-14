using System;
using ABSTRACCION_EJEMPLO;


Vehiculo moto1      = new Moto         ("ABC123", "MICHAEL", 90);
Vehiculo camion1    = new Camion       ("ABC369", "PARRA", 80);
Vehiculo bicicleta1 = new Bicicleta    ("ABC321", "MANTILLA", 30);
Vehiculo furgoneta1 = new Furgoneta    ("ABC321", "STEVEN", 60);


Console.WriteLine("Moto: " + moto1.CalcularTiempoEstimado(100) + " horas, costo = $" + moto1.CalcularCosto(100));
Console.WriteLine("Camion: = " + camion1.CalcularTiempoEstimado(100) + " horas, costo = $" + camion1.CalcularCosto(100));
Console.WriteLine("Bicicleta: = " + bicicleta1.CalcularTiempoEstimado(100) + " horas, costo = $" + bicicleta1.CalcularCosto(100));
Console.WriteLine("Furgoneta: = " + furgoneta1.CalcularTiempoEstimado(100) + " horas, costo = $" + furgoneta1.CalcularCosto(100));
