using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Every job must have a name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Every job must have a location!")]
        public string Location { get; set; }

    }
}