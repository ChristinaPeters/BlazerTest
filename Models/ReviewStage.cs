namespace BlazerTest.Models
{
    public class ReviewStage
    {
        public string Name { get; set; }
        public List<string> ReviewersEmailAddresses { get; set; }
        public int StageNumber { get; set; }
    }

    public class ReviewSettings
    {
        public List<ReviewStage> Stages { get; set; }
    }

}
