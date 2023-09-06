
using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace TestApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://tabarja-kfaryassine.gov.lb/ar/municipalities-in-lebanon?page=";
            var final = new List<string>();
            using (HttpClient client = new HttpClient())
            {
                for(int i = 0; i < 21; i++)
                    using (HttpResponseMessage response = await client.GetAsync($"{url}{i}"))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string result = await content.ReadAsStringAsync();
                            var parser = new HtmlParser();
                            var document = parser.ParseDocument(result);
                            foreach (var elem in document.QuerySelectorAll("tbody tr"))
                            {
                                var tds = new List<string>();
                                foreach (var tdelem in elem.QuerySelectorAll("td"))
                                {
                                    tds.Add($"\"{tdelem.Text().Trim()}\"");
                                }
                                if(!final.Contains(string.Join(",", tds.ToArray()))) { 
                                    final.Add(string.Join(",", tds.ToArray()));
                                    Console.WriteLine(string.Join(",", tds.ToArray()));
                                }
                            }
                        }
                    }
            }
            File.WriteAllText("C:\\Users\\96170\\Desktop\\phones.csv", string.Join("\n", final));
        }
    }
}