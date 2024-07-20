using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace CascadingDropdownCore.Models
{
    public class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        [ValidateNever]
        public Country Country { get; set; }
    }
}
