using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entities
{
    public class Category : Entity
    {
        [Display(Name = "Categoría")] //Así se muestra en la UI. En SQL: 'AS'
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//Longituda máxima de 100 caracteres (nvarchar(50))
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "Descripción")] //Así se muestra en la UI. En SQL: 'AS'
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//Longituda máxima de 100 caracteres (nvarchar(50))
        public string? Description { get; set; }
    }
}
