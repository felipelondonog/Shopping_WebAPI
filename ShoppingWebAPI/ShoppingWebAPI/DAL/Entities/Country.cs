﻿using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name = "País")] //Así se muestra en la UI. En SQL: 'AS'
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//Longituda máxima de 100 caracteres (nvarchar(50))
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "Estado")]
        public ICollection<State> States { get; set; } //Un país puede tener n estados

        //Propiedad de lectura que no se mapea en la tabla de la DB
        public int StatesNumber => States == null ? 0 : States.Count; //if ternario. (? -> Entonces). (: -> Sino)
    }
}
