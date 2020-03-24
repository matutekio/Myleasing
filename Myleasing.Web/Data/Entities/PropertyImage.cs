using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Myleasing.Web.Data.Entities
{
    
    
    public class PropertyImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string ImageUrl { get; set; }

        private Property property;

        public Property GetProperty()
        {
            return property;
        }

        public void SetProperty(Property value)
        {
            property = value;
        }

        // TODO: Change the path when publish
        public string ImageFullPath => $"https://TBD.azurewebsites.net{ImageUrl.Substring(1)}";

        // relacion varios a uno
        public Property Property { get; set; }
    }

}
