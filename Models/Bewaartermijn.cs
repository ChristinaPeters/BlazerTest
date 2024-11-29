using System.ComponentModel.DataAnnotations;

namespace BlazerTest.Models
{
    public class Bewaartermijn
    {
        public Guid cr971_cr4b0_econtentbewaartermijnensid
        { get; set; }

        [Required(ErrorMessage = "Enter the site name")]
        public string cr971_cr4b0_site { get; set; }

        [Required(ErrorMessage = "Enter which Bibliotheek it needs to be in")]
        public string cr971_cr4b0_bibliotheek { get; set; }

        [Required(ErrorMessage = "Enter the purpose of this Retention Label.")]
        public string cr971_cr4b0_inhoudstype { get; set; }

        [Required(ErrorMessage = "Choose one of the options")]
        public string cr971_econtenteventtypes { get; set; }

        [Required(ErrorMessage = "Specify the number of years it needs to be retained.")]
        public string cr971_cr4b0_bewaartermijn { get; set; }

        [Required(ErrorMessage = "Enter the Content Type Abbreviation")]
        public string cr971_contenttypeabbreviatio { get; set; }

        [Required(ErrorMessage = "Enter the Site name Abbreviation")]
        public string cr971_sitenameabbreviation { get; set; }

        [Required(ErrorMessage = "Enter the Library name Abbreviation")]
        public string cr971_librarynameabbreviation { get; set; }

        [Required(ErrorMessage = "Fill in the Review Settings")]
        public string cr971_reviewsettingstest { get; set; }

        public string cr971_labelname { get; set; }
    }

}
