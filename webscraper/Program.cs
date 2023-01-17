internal class Program
{
    private static void Main(string[] args)
    {
        HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
        HtmlAgilityPack.HtmlDocument doc = web.Load("https://app.slack.com/client/T02EW3SC4/C02EW4SDY");
        foreach (var item in doc.DocumentNode.SelectNodes("feedback"))
        {
            Console.WriteLine(item.InnerText);
        }
    }
}