using BlazerTest.Pages;

namespace BlazerTest.Models
{
    public class BewaartermijnCollection
    {
        //Properties
        public Bewaartermijn[] value { get; set; }

        //Constructor
        private readonly List<Bewaartermijn>? _bewaartermijn;

        //Constructor
        public BewaartermijnCollection()
        {
            _bewaartermijn = new List<Bewaartermijn>();
        }

        //Add bewaartermijn
        public void AddBewaartermijn(Bewaartermijn bewaartermijn)
        {
            if (bewaartermijn == null)
            {
                throw new ArgumentNullException(nameof(bewaartermijn), "Bewaartermijn cannot be null.");
            }

            // Assign a new GUID if it's not already set
            if (bewaartermijn.cr971_cr4b0_econtentbewaartermijnensid == Guid.Empty)
            {
                bewaartermijn.cr971_cr4b0_econtentbewaartermijnensid = Guid.NewGuid();
            }

            _bewaartermijn.Add(bewaartermijn);

        }

        //Edit bewaartermijn
        public void EditBewaartermijn(Bewaartermijn updatedBewaartermijn)
        {
            if (updatedBewaartermijn == null)
            {
                throw new ArgumentNullException(nameof(updatedBewaartermijn), "Updated Bewaartermijn cannot be null.");
            }

            var existingBewaartermijn = _bewaartermijn.FirstOrDefault(b => b.cr971_cr4b0_econtentbewaartermijnensid == updatedBewaartermijn.cr971_cr4b0_econtentbewaartermijnensid);
            if (existingBewaartermijn == null)
            {
                throw new ArgumentException("Bewaartermijn not found.", nameof(updatedBewaartermijn));
            }

            existingBewaartermijn.cr971_cr4b0_site = updatedBewaartermijn.cr971_cr4b0_site;
            existingBewaartermijn.cr971_cr4b0_bibliotheek = updatedBewaartermijn.cr971_cr4b0_bibliotheek;
            existingBewaartermijn.cr971_cr4b0_inhoudstype = updatedBewaartermijn.cr971_cr4b0_inhoudstype;
            existingBewaartermijn.cr971_econtenteventtypes = updatedBewaartermijn.cr971_econtenteventtypes;
            existingBewaartermijn.cr971_cr4b0_bewaartermijn = updatedBewaartermijn.cr971_cr4b0_bewaartermijn;
            existingBewaartermijn.cr971_contenttypeabbreviatio = updatedBewaartermijn.cr971_contenttypeabbreviatio;
            existingBewaartermijn.cr971_sitenameabbreviation = updatedBewaartermijn.cr971_sitenameabbreviation;
            existingBewaartermijn.cr971_librarynameabbreviation = updatedBewaartermijn.cr971_librarynameabbreviation;
            existingBewaartermijn.cr971_reviewsettingstest = updatedBewaartermijn.cr971_reviewsettingstest;
            existingBewaartermijn.cr971_labelname = updatedBewaartermijn.cr971_labelname;
        }

        //Delete bewaartermijn by id
        public void DeleteBewaartermijn(Guid bewaartermijnId)
        {
            var bewaartermijn = _bewaartermijn.FirstOrDefault(b => b.cr971_cr4b0_econtentbewaartermijnensid == bewaartermijnId);
            if (bewaartermijn == null)
            {
                throw new ArgumentException("Bewaartermijn not found.", nameof(bewaartermijnId));
            }

            _bewaartermijn.Remove(bewaartermijn);
        }

        //Get all stored bewaartermijnen objects
        public IEnumerable<Bewaartermijn> GetBewaartermijnen()
        {
            return _bewaartermijn;
        }
        //Get bewaartermijn by id
        public Bewaartermijn GetBewaartermijnById(Guid bewaartermijnId)
        {
            var bewaartermijn = _bewaartermijn.FirstOrDefault(b => b.cr971_cr4b0_econtentbewaartermijnensid == bewaartermijnId);
            if (bewaartermijn == null)
            {
                throw new ArgumentException("Bewaartermijn not found.", nameof(bewaartermijnId));
            }
            return bewaartermijn;
        }
    }

}
