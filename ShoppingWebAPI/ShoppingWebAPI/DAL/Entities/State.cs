using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entities
{
    public class State : Entity
    {
        [Display(Name = "Estado")] //Así se muestra en la UI. En SQL: 'AS'
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//Longituda máxima de 100 caracteres (nvarchar(50))
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "País")]
        public Country Country { get; set; }

        [Display(Name = "Id País")]
        public Guid CountryId { get; set; }

        [Display(Name = "Ciudades")]
        public ICollection<City> Cities { get; set; }

        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
