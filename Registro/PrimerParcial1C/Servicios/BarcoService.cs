// Services/BarcoService.cs


using System.Collections.Generic;
using PrimerParcial1C.Servicios;
using PrimerParcial1C.Models;

public class BarcoService : IBarcoService
{
    public static List<BarcoModel> barcos = new List<BarcoModel>();

    public void RegistrarBarco(BarcoModel barco)
    {
        barco.tasa = CalcularTasa(barco.antiguedad, barco.tripulacionMaxima);
        barco.iD = barcos.Count + 1;
        barcos.Add(barco);
    }

    public List<BarcoModel> ObtenerBarcos()
    {
        return barcos;
    }

    private double CalcularTasa(int antiguedad, int tripulacionMaxima)
    {
        return (antiguedad * 0.10) + (tripulacionMaxima / 2.0);
    }
}
