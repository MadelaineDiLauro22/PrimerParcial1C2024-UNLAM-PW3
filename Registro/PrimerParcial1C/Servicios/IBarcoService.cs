namespace PrimerParcial1C.Servicios
{
    using PrimerParcial1C.Models;
    using System.Collections.Generic;

    public interface IBarcoService
    {
        void RegistrarBarco(BarcoModel barco);
        List<BarcoModel> ObtenerBarcos();
    }

}
