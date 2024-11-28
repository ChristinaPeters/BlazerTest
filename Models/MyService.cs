namespace BlazerTest.Models
{
    public class MyService
    {
        private static List<Bewaartermijn> _data { get; set; } = new List<Bewaartermijn>();

        public static async Task Create(Bewaartermijn itemToInsert)
        {
            await Task.Delay(1000); // simulate actual long running async operation

            itemToInsert.cr971_cr4b0_econtentbewaartermijnensid = Guid.NewGuid();
            _data.Insert(0, itemToInsert);
        }

        public static async Task<List<Bewaartermijn>> Read()
        {
            await Task.Delay(1000); // Simulate a long-running async operation

            if (_data.Count < 1)
            {
                for (int i = 1; i <= 50; i++)
                {
                    _data.Add(new Bewaartermijn
                    {
                        cr971_cr4b0_econtentbewaartermijnensid = Guid.NewGuid(),
                        cr971_cr4b0_site = $"Site {i}",
                        cr971_cr4b0_bibliotheek = $"Bibliotheek {i}",
                        cr971_cr4b0_inhoudstype = $"Inhoudstype {i}",
                        cr971_econtenteventtypes = $"EventType {i}",
                        cr971_cr4b0_bewaartermijn = $"{30 + i} days",
                        cr971_contenttypeabbreviatio = $"CTA {i}",
                        cr971_sitenameabbreviation = $"SNA {i}",
                        cr971_librarynameabbreviation = $"LNA {i}",
                        cr971_reviewsettingstest = $"ReviewSetting {i}",
                        cr971_labelname = $"Label {i}"
                    });
                }
            }

            return await Task.FromResult(_data);
        }


        public static async Task Update(Bewaartermijn itemToUpdate)
        {
            await Task.Delay(1000); // Simulate a long-running async operation

            // Find the index of the item to update
            var index = _data.FindIndex(i => i.cr971_cr4b0_econtentbewaartermijnensid == itemToUpdate.cr971_cr4b0_econtentbewaartermijnensid);
            if (index != -1)
            {
                // Update the item at the found index
                _data[index] = itemToUpdate;
            }
        }

        public static async Task Delete(Bewaartermijn itemToDelete)
        {
            await Task.Delay(1000); // Simulate a long-running async operation

            // Find the item in the list by matching its ID and remove it
            _data.RemoveAll(i => i.cr971_cr4b0_econtentbewaartermijnensid == itemToDelete.cr971_cr4b0_econtentbewaartermijnensid);
        }

    }
}
