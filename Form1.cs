using System.Text.RegularExpressions;

namespace FFLF;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void fetchButton_Click(object sender, EventArgs e)
    {
        string[] lines = urlTextBox.Text.Split([Environment.NewLine], StringSplitOptions.RemoveEmptyEntries);
        List<string> urls = new List<string>();
        
        foreach (var url in lines)
        {
            if (ValidateUrl(url))
            {
                Console.WriteLine(url);
                urls.Add(url);
            }
        }
        var downloadLinks = await FetchDownloadLinksAsync(urls);
        foreach (var downloadLink in downloadLinks)
        {
            fetchedTextBox.Text += downloadLink + Environment.NewLine;
        }
    }
    
    private async Task<List<string>> FetchDownloadLinksAsync(List<string> urls)
    {
        int failedCount = 0;
        var downloadLinks = new List<string>();
        if (urls.Count == 0)
        {
            return downloadLinks;
        }
        extractionProgressBar.Maximum = urls.Count;
        extractionProgressBar.Value = 0;
        extractionProgressBar.Visible = true;
        fetchButton.Enabled = false;
        using (var httpClient = new HttpClient())
        {
            foreach (var url in urls)
            {
                try
                {
                    var response = await httpClient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var downloadLink = ExtractDownloadLink(content);
                        if (!string.IsNullOrEmpty(downloadLink))
                        {
                            downloadLinks.Add(downloadLink);
                        }
                        else
                        {
                            failedCount++;
                        }
                    }
                    else
                    {
                        failedCount++;
                    }
                }
                catch (Exception)
                {
                    failedCount++;
                }

                extractionProgressBar.Value++;
            }
        }

        extractionProgressBar.Visible = false;
        fetchButton.Enabled = true;
        resultLabel.Text = $"Successful: {urls.Count - failedCount}, Failed: {failedCount}";
        
        return downloadLinks;
    }

    private string? ExtractDownloadLink(string htmlContent)
    {
        string pattern = @"window\.open\(""(https://fuckingfast\.co/dl/[^""]+)""";
        
        var match = Regex.Match(htmlContent, pattern);
        
        return match is { Success: true, Groups.Count: > 1 } ? match.Groups[1].Value : null;
    }
    
    private static bool ValidateUrl(string strUrl)
    {
        return Uri.TryCreate(strUrl, UriKind.RelativeOrAbsolute, out _);
    }
}
