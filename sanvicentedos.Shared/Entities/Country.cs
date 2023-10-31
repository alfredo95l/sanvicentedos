using System.ComponentModel.DataAnnotations;

namespace sanvicentedos.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "Pais")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null!;
        public ICollection<State>? States { get; set; }
        [Display(Name = "Estado/Departamento")]
        public int SatesNumber => States == null ? 0 : States.Count;
    }
}
