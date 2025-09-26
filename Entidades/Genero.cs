using System.ComponentModel.DataAnnotations;
using PeliculasApi.Validaciones;

namespace PeliculasApi.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "EL campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres ")]
        [PrimeraLetraMayus]
        public required string Nombre { get; set; }
    }
}