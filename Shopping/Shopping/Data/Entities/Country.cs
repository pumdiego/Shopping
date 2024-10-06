using System.ComponentModel.DataAnnotations; //para usar required y maxlength

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name="País")]
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener maximo {1} caracteres")] //para que el pais tenga maximo 50 caracteres
        [Required(ErrorMessage ="El campo {0} es obligatorio")] //no va a dejar meter un pais sin nombre, el 0 se reemplaza or el valor de Name
        public string Name { get; set; }
    }
}
