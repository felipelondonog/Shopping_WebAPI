using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entities
{
    public class City : Entity
    {
        [Display(Name = "Ciudad")] //Así se muestra en la UI. En SQL: 'AS'
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//Longituda máxima de 100 caracteres (nvarchar(50))
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "Estado")]
        public State State { get; set; }

        //FK
        //[Display(Name = "IdEstado")]
        [Required]
        public Guid StateId { get; set; }
    }
}
