using System.ComponentModel.DataAnnotations;

namespace PrimerParcial1C.Models
{

public class BarcoModel
    {
        public int iD { get; set; }

        [Required]
        [StringLength(20)]
        public string? nombre { get; set; }

        [Required]
        [Range(1, 200)]
        public int antiguedad { get; set; }

        [Required]
        [Range(1, 500)]
        public int tripulacionMaxima { get; set; }

        public double? tasa { get; set; }
    }

}

