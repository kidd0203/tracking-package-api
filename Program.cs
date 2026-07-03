using System.Threading.Tasks;

namespace TrackingPackageSample
{
    internal class Program
    {
        static string RapidAPIKey = "6dc6c4cb1amshcdxxxxxxxx3e6p11ea8ejsn0a3dc8b876b7"; // Replace with your RapidAPI key
        static string Token = "Basic Ym9sZGNoYXQxxxxxxxxxxx1QzkuKz9SLw=="; // Replace with your token

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            TrackPackage().Wait();
        }


        static async Task TrackPackage()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://trackingpackage.p.rapidapi.com/TrackingPackage?trackingNumber=9200190312809701574398");
            request.Headers.Add("X-RapidAPI-Key", RapidAPIKey);
            request.Headers.Add("X-RapidAPI-Host'", "trackingpackage.p.rapidapi.com");
            request.Headers.Add("Authorization", Token);
            var content = new StringContent("", null, "text/plain");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

        }
    }
}
