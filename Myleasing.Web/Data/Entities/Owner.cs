using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Myleasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "First Mame")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }


        // campos bse de datos nueva
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Gender { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Etnia { get; set; }

        //[MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //public string Titulo { get; set; }
        //******************

        public string Address { get; set; }

        // propiedad de lectura
        [Display(Name = "Owner name")]
        public string Fullname => $"{FirstName} {LastName}";

        [Display(Name = "Owner name")]
        public string FullnameWithDocument => $"{FirstName} {LastName} - {Document}";

        // relacion uno a varios
        public ICollection<Property> Properties  { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}
