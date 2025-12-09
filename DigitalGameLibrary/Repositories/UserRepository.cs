using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DigitalGameLibrary.Repositories
{
    public class OwnershipRepository
    {
        private string filePath = "ownership.json";

        public Dictionary<string, List<string>> LoadOwnership()
        {
            if (!File.Exists(filePath))
                return new Dictionary<string, List<string>>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json)
                   ?? new Dictionary<string, List<string>>();
        }

        public void SaveOwnership(Dictionary<string, List<string>> ownership)
        {
            string json = JsonSerializer.Serialize(ownership, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
