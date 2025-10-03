using AlikathWeb.Models.Overwatch;
using System.Net.Http.Json;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace AlikathWeb.Services
{
    public class OverwatchService
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _json = new() { PropertyNameCaseInsensitive = true };

        public OverwatchService(HttpClient http) => _http = http;

        /* WORK ON THIS CODE */
        public async Task<OverwatchProfile?> GetProfileAsync()
        {
            var url = $"https://overfast-api.tekrop.fr/players/Alikath-2288";

            using var resp = await _http.GetAsync(url);
            if (!resp.IsSuccessStatusCode) return null;

            using var stream = await resp.Content.ReadAsStreamAsync();

            // If you have a strongly-typed root object, deserialize directly:
            // var raw = await JsonSerializer.DeserializeAsync<YourRawRoot>(stream, _json);

            // Or, if the JSON is gnarly, use JsonDocument and cherry-pick only what you need:
            using var doc = await JsonDocument.ParseAsync(stream);
            var root = doc.RootElement;

            /* Temporary */
            string username = String.Empty;
            string avatar = String.Empty;
            string namecard = String.Empty;
            string title = String.Empty;

            return new OverwatchProfile(
                Username: username,
                Avatar: avatar,
                Namecard: namecard,
                Title: title
            );
            /* Temporary */
        }
    }
}
