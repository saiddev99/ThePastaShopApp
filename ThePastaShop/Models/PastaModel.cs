using System.ComponentModel.DataAnnotations;

namespace ThePastaShop.Models
{
    public class PastaModel
    {
        [Display(Name = "1. Kies de pasta")]
        public PastaNaam Naam { get; set; }

        [Display(Name = "2. Kies de grootte")]
        public Grootte Grootte { get; set; }

        [Display(Name = "3. Kies de saus")]
        public Saus Saus { get; set; }
    }
}
