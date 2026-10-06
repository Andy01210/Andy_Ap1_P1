using System.ComponentModel.DataAnnotations;
namespace  Parcial1.Models;


    public class Autor{
        [Key]
        public int IdAutor{get; set;}
        [Required(ErrorMessage ="Debe ingresar el nombre del autor")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage ="Debe ingresar el nombre del autor")]
        public string? Nacionalidad { get; set; }
        [Required(ErrorMessage ="Debe ingresar el nombre del autor")]
        public DateOnly FechaNacimiento { get; set; }
        [Required(ErrorMessage ="Debe ingresar el nombre del autor")]
        public double Sueldo { get; set; }
        
    }
