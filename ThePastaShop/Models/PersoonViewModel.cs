using System.ComponentModel.DataAnnotations;


namespace ThePastaShop.Models
{
    public class PersoonViewModel
    {
        [Display(Name = "Naam")]
        [Required(ErrorMessage = "Naam is verplicht")]
        public string? Naam { get; set; }

        [Display(Name = "Voornaam")]
        [Required(ErrorMessage = "Voornaam is verplicht")]
        public string? Voornaam { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is verplicht")]
        [RegularExpression("\\w+@\\w+\\.\\w+",ErrorMessage = "Dit Email is niet geldig.")]
        public string? Email { get; set; }

        [Display(Name = "Telefoon")]
        [Required(ErrorMessage = "Telefoon is verplicht")]
        public string? Telefoon { get; set; }

        [Display(Name = "GeboorteDatum")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "GeboorteDatum is verplicht")]
        [DateCheck(ErrorMessage = "Foetieve geboortedatum")]
        public DateTime? GeboorteDatum { get; set; }
    }
}
