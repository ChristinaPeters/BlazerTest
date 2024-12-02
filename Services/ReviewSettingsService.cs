using BlazerTest.Models;
using System.Linq;
using System.Text.Json;
using System.Text;

public class ReviewSettingsService
{
    public string FormatReviewSettings(string json)
    {
        try
        {
            var reviewSettings = JsonSerializer.Deserialize<ReviewSettings>(json);

            if (reviewSettings?.Stages != null && reviewSettings.Stages.Any())
            {
                return string.Join("<br />", reviewSettings.Stages.Select(stage =>
                    $"Stage {stage.StageNumber}: {stage.Name}<br />" +
                    $"Reviewers: {string.Join(", ", stage.ReviewersEmailAddresses)}"
                ));
            }
            return "No stages found in the review settings.";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing JSON: {ex.Message}");
            return "Error processing review settings.";
        }
    }
}

